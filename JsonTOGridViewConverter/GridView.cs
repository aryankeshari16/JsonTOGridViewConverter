using ClosedXML.Excel;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonTOGridViewConverter
{
    public partial class GridView : Form
    {

        private string jsonData;
        private DataTable originalTable;

        public GridView(string json)
        {
            InitializeComponent();

            jsonData = json;
        }


        private void GridView_Load(object sender, EventArgs e)
        {
            // DateTime Picker Setup
            EntryDate_From.Format = DateTimePickerFormat.Custom;
            EntryDate_From.CustomFormat = "dd-MM-yyyy HH:mm";
            EntryDate_From.ShowUpDown = true;
            
            entrydate_to.Format = DateTimePickerFormat.Custom;
            entrydate_to.CustomFormat = "dd-MM-yyyy HH:mm";
            entrydate_to.ShowUpDown = true;


            DataTable tempTable =
    Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(jsonData);


            DataTable table = tempTable.Clone();


            // Change datatype only if column exists
            if (table.Columns.Contains("JourneyDate"))
            {
                table.Columns["JourneyDate"].DataType = typeof(DateTime);
            }


            if (table.Columns.Contains("EventTimeUtc"))
            {
                table.Columns["EventTimeUtc"].DataType = typeof(DateTime);
            }



            foreach (DataRow row in tempTable.Rows)
            {
                DataRow newRow = table.NewRow();


                foreach (DataColumn col in tempTable.Columns)
                {

                    if (col.ColumnName == "JourneyDate")
                    {
                        newRow[col.ColumnName] =
                            Convert.ToDateTime(row[col]);
                    }


                    else if (col.ColumnName == "EventTimeUtc")
                    {

                        DateTimeOffset dto;


                        if (DateTimeOffset.TryParse(
                            row[col].ToString(),
                            out dto))
                        {

                            // Convert UTC to IST
                            DateTime ist =
                                dto.ToOffset(
                                TimeSpan.FromHours(5.5))
                                .DateTime;


                            newRow[col.ColumnName] = ist;
                        }
                        else
                        {
                            newRow[col.ColumnName] = DBNull.Value;
                        }

                    }


                    else
                    {
                        newRow[col.ColumnName] = row[col];
                    }

                }


                table.Rows.Add(newRow);

            }



            // Add PAX Column
            table.Columns.Add("PAX", typeof(int));


            foreach (DataRow row in table.Rows)
            {
                int adult = Convert.ToInt32(row["Adult"]);
                int child = Convert.ToInt32(row["Child"]);

                row["PAX"] = adult + child;
            }



            originalTable = table;



            // Bind Grid
            dataGridView1.DataSource = originalTable;


            if (dataGridView1.Columns.Contains("EventTimeUtc"))
            {
                dataGridView1.Columns["EventTimeUtc"]
                .DefaultCellStyle.Format =
                "dd-MM-yyyy HH:mm";
            }


            if (dataGridView1.Columns.Contains("PAX"))
            {
                dataGridView1.Columns["PAX"].DisplayIndex = 12;
            }



            // Sector Dropdown
            var sectors = table.AsEnumerable()
                .Select(row =>
                    row["Origin"].ToString()
                    + " // "
                    +
                    row["Destination"].ToString()
                )
                .Distinct()
                .OrderBy(x => x)
                .ToList();


            sectors.Insert(0, "All Sector");


            sectorComboBox.DataSource = sectors;



            CountData();



        }



        private void CountData()
        {
            int count = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Count(r => !r.IsNewRow);


            CountRecordsLbl.Text =
                $"[ {count} Record(s) Found. ]";
            
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (originalTable == null)
                return;


            DataView view = new DataView(originalTable);


            List<string> filters = new List<string>();


            // Sector Filter

            string selectedSector = sectorComboBox.SelectedItem?.ToString();


            if (!string.IsNullOrEmpty(selectedSector) &&
                selectedSector != "All Sector")
            {

                string[] sector = selectedSector.Split(
                    new string[] { " // " },
                    StringSplitOptions.None
                );


                string origin = sector[0];
                string destination = sector[1];


                filters.Add(
                    $"Origin = '{origin}' AND Destination = '{destination}'"
                );
            }



            // Account ID Filter
            if (!string.IsNullOrWhiteSpace(accIdtextBox.Text))
            {
                filters.Add(
                    $"AccountId = '{accIdtextBox.Text.Trim()}'"
                );
            }


            if (TravelDate_From.Checked && TravelDate_To.Checked)
            {
                DateTime from = TravelDate_From.Value.Date;
                DateTime to = TravelDate_To.Value.Date.AddDays(1);


                filters.Add(
                    $"(JourneyDate >= #{from:yyyy-MM-dd}# AND JourneyDate < #{to:yyyy-MM-dd}#)"
                );
            }
            else if (TravelDate_From.Checked)
            {
                DateTime from = TravelDate_From.Value.Date;


                filters.Add(
                    $"JourneyDate >= #{from:yyyy-MM-dd}#"
                );
            }
            else if (TravelDate_To.Checked)
            {
                DateTime to = TravelDate_To.Value.Date.AddDays(1);


                filters.Add(
                    $"JourneyDate < #{to:yyyy-MM-dd}#"
                );
            }

            if (EntryDate_From.Checked && entrydate_to.Checked)
            {
                DateTime from = EntryDate_From.Value;
                DateTime to = entrydate_to.Value;


                filters.Add(
                    $"EventTimeUtc  >= #{from:MM/dd/yyyy HH:mm}# AND EventTimeUtc  <= #{to:MM/dd/yyyy HH:mm}#"
                );
            }
            else if (EntryDate_From.Checked)
            {
                DateTime from = EntryDate_From.Value;


                filters.Add(
                    $"EventTimeUtc  >= #{from:MM/dd/yyyy HH:mm}#"
                );
            }
            else if (entrydate_to.Checked)
            {
                DateTime to = entrydate_to.Value;


                filters.Add(
                    $"EventTimeUtc  <= #{to:MM/dd/yyyy HH:mm}#"
                );
            }


            if (trueRadioButton1.Checked)
            {
                filters.Add($"Success = True");
            }
            else if (falseRadioButton1.Checked)
            {
                filters.Add($"Success = False");
            }
            else if (noneRadioButton1.Checked)
            {
                filters.Add("(Success = False OR Success = True)");
            }
            if (int.TryParse(paxTextBox.Text, out int pax))
            {
                filters.Add($"PAX = {pax}");
            }

            if (filters.Count > 0)
            {
                view.RowFilter = string.Join(" AND ", filters);
            }


            dataGridView1.DataSource = view;


            CountData();
        }

        private void accIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void paxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void export_to_excel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export");
                return;
            }


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            sfd.FileName = "Export_" + DateTime.Now.ToString("ddMMyyyy_HHmm");


            if (sfd.ShowDialog() == DialogResult.OK)
            {

                using (XLWorkbook wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Data");


                    // Get only visible columns and sort by DisplayIndex
                    var visibleColumns = dataGridView1.Columns
                        .Cast<DataGridViewColumn>()
                        .Where(c => c.Visible)
                        .OrderBy(c => c.DisplayIndex)
                        .ToList();



                    // Header
                    for (int i = 0; i < visibleColumns.Count; i++)
                    {
                        ws.Cell(1, i + 1).Value =
                            visibleColumns[i].HeaderText;
                    }



                    // Data
                    for (int row = 0; row < dataGridView1.Rows.Count; row++)
                    {

                        if (dataGridView1.Rows[row].IsNewRow)
                            continue;


                        for (int col = 0; col < visibleColumns.Count; col++)
                        {

                            var value =
                                dataGridView1.Rows[row]
                                .Cells[visibleColumns[col].Index]
                                .Value;


                            ws.Cell(row + 2, col + 1)
                                .Value =
                                value == null ? "" : value.ToString();

                        }
                    }



                    // Auto width
                    ws.Columns().AdjustToContents();


                    wb.SaveAs(sfd.FileName);
                }


                MessageBox.Show("File Saved Successfully");
            }
        }
    }
}
