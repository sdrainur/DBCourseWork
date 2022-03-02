using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Zadacha1_4 : Form
    {
        public int year, month;
        public Zadacha1_4()
        {
            InitializeComponent();
        }

        private void Zadacha1_4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.production_number". При необходимости она может быть перемещена или удалена.
            this.production_numberTableAdapter.Fill(this.dataSet1.production_number);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.areas". При необходимости она может быть перемещена или удалена.
            this.areasTableAdapter.Fill(this.dataSet1.areas);
            QueryZapr4();
        }

        public void QueryZapr4()
        {
            dataSet1.DataTable1.Clear();
            foreach (DataSet1.production_numberRow nRow in
                    dataSet1.production_number.Rows)
            {
                if (nRow.year == year && nRow.month == month)
                { 
                    DataSet1.areasRow mRow = nRow.GetParentRow("areas_production_number") as DataSet1.areasRow;
                    DataSet1.DataTable1Row zrow = dataSet1.DataTable1.NewDataTable1Row();
                    zrow.release_plan = nRow.release_plan;
                    zrow.area_name = mRow.area_name;
                    zrow.workshop_id = nRow.workshop_id;
                    zrow.product_id = nRow.product_id;
                    dataSet1.DataTable1.Rows.Add(zrow);

                }
            }
            dataTable1DataGridView.Refresh();
        }
        private void dataTable1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            month = Convert.ToInt32(textBox1.Text);
            year = Convert.ToInt32(textBox2.Text);
            QueryZapr4();
        }
    }
}
