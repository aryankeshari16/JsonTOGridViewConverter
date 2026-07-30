using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonTOGridViewConverter
{
    public partial class GridView : Form
    {

        private string jsonData;


        public GridView(string json)
        {
            InitializeComponent();

            jsonData = json;
        }


        private void GridView_Load(object sender, EventArgs e)
        {

            DataTable table =
                Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(jsonData);
            dataGridView1.DataSource = table;
            //foreach (DataRow row in table.Rows)
            //{
            //    int adult = Convert.ToInt32(row["Adult"]);
            //    int child = Convert.ToInt32(row["Child"]);

            //    row["PAX"] = adult + child;
            //}


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "PAX")
            {
                int rowIndex = e.RowIndex;

                int adult =
                Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Adult"].Value);

                int child =
                Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Child"].Value);


                e.Value = adult + child;
            }
        }
    }
}
