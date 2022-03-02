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
    public partial class Zadacha1_3 : Form
    {
        public int year, month;
        
        public Zadacha1_3()
        {
            InitializeComponent();
        }

        private void Zadacha1_3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.production_number". При необходимости она может быть перемещена или удалена.
            this.production_numberTableAdapter.Fill(this.dataSet1.production_number);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.areas". При необходимости она может быть перемещена или удалена.
            this.areasTableAdapter.Fill(this.dataSet1.areas);
            QueryZapr3();
        }

        private void dataTable1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataTable1BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        public void QueryZapr3()
        {
            dataSet1.DataTable1.Clear();
            foreach (DataSet1.production_numberRow nRow in
                    dataSet1.production_number.Rows)
            {
                if (nRow.year == year && nRow.month == month)
                {
                    DataSet1.areasRow mRow = dataSet1.areas.FindByworkshop_idarea_id(nRow.workshop_id, nRow.area_id);

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

        private void button1_Click(object sender, EventArgs e)
        {
            month = Convert.ToInt32(textBox1.Text);
            year = Convert.ToInt32(textBox2.Text);
            QueryZapr3();
        }
    }
}
