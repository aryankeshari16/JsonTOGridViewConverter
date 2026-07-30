using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace JsonTOGridViewConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter ="Supported Files (*.json;*.jsonl;*.csv;*.xlsx;*.txt)|*.json;*.jsonl;*.csv;*.xlsx;*.txt|All Files (*.*)|*.*";


                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;


                        string jsonData = ConvertFileToJson(filePath);


                        // Open GridView Form

                        GridView grid = new GridView(jsonData);

                        grid.Show();

                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string ConvertFileToJson(string filePath)
        {
            DataTable table = new DataTable();

            string extension = Path.GetExtension(filePath).ToLower();


            if (extension == ".xlsx")
            {
                using (var workbook = new ClosedXML.Excel.XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);


                    bool firstRow = true;


                    foreach (var row in worksheet.RowsUsed())
                    {
                        if (firstRow)
                        {
                            foreach (var cell in row.Cells())
                            {
                                table.Columns.Add(cell.Value.ToString());
                            }

                            firstRow = false;
                        }
                        else
                        {
                            DataRow dataRow = table.NewRow();

                            int index = 0;

                            foreach (var cell in row.Cells())
                            {
                                dataRow[index] = cell.Value.ToString();
                                index++;
                            }

                            table.Rows.Add(dataRow);
                        }
                    }
                }
            }


            else if (extension == ".csv")
            {
                string[] lines = File.ReadAllLines(filePath);


                string[] headers = lines[0].Split(',');


                foreach (string header in headers)
                {
                    table.Columns.Add(header);
                }


                for (int i = 1; i < lines.Length; i++)
                {
                    table.Rows.Add(lines[i].Split(','));
                }
            }


            else if (extension == ".txt")
            {
                table.Columns.Add("Content");


                foreach (string line in File.ReadLines(filePath))
                {
                    table.Rows.Add(line);
                }
            }

            else if (extension == ".jsonl")
            {
                string[] lines = File.ReadAllLines(filePath);

                DataTable jsonTable = new DataTable();


                foreach (string line in lines)
                {
                    JObject obj = JObject.Parse(line);


                    if (jsonTable.Columns.Count == 0)
                    {
                        foreach (var property in obj.Properties())
                        {
                            jsonTable.Columns.Add(property.Name);
                        }
                    }


                    DataRow row = jsonTable.NewRow();


                    foreach (var property in obj.Properties())
                    {
                        row[property.Name] = property.Value.ToString();
                    }


                    jsonTable.Rows.Add(row);
                }


                table = jsonTable;
            }

            else
            {
                throw new Exception("Unsupported file format");
            }



            return Newtonsoft.Json.JsonConvert.SerializeObject(
                table,
                Newtonsoft.Json.Formatting.Indented
            );
        }
    }
}
