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
    public partial class Zadacha2_1 : Form
    {
        private int year;
        public Zadacha2_1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fill()
        {
                dataSet1.DataTable1.Clear();
                int detailId = -1, amount = 0, wh=-1;
            string name = null;
                DataSet1.DataTable1Row zRow = null;
                foreach (DataSet1.production_numberRow pRow in dataSet1.production_number.Rows)
                {
                    if (pRow.year == year)
                    {
                        if (zRow == null)
                        {
                            detailId = pRow.product_id;
                            amount = pRow.release_plan;
                            wh = pRow.workshop_id;
                            name = dataSet1.areas.FindByworkshop_idarea_id(pRow.workshop_id, pRow.area_id).area_name;
                            zRow = dataSet1.DataTable1.NewDataTable1Row();
                        }
                        else if (detailId == pRow.product_id) 
                        {
                            amount += pRow.release_plan;
                        }
                        else 
                        {
                            zRow.release_plan = amount;
                            zRow.workshop_id = wh;
                            zRow.product_id = detailId;
                            zRow.area_name = name;
                            dataSet1.DataTable1.Rows.Add(zRow);
                            detailId = pRow.product_id;
                            wh = pRow.workshop_id;
                            name = dataSet1.areas.FindByworkshop_idarea_id(pRow.workshop_id, pRow.area_id).area_name;
                            amount = pRow.release_plan;
                            zRow = dataSet1.DataTable1.NewDataTable1Row();
                        }
                    }
                }
                if (zRow != null)
                {
                    zRow.release_plan = amount;
                    zRow.workshop_id = wh;
                    zRow.product_id = detailId;
                    zRow.area_name = name;
                    dataSet1.DataTable1.Rows.Add(zRow);
                }
                dataTable1DataGridView.Refresh();
            }
            private void Zadacha2_1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.production_number". При необходимости она может быть перемещена или удалена.
            this.production_numberTableAdapter.Fill(this.dataSet1.production_number);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.details". При необходимости она может быть перемещена или удалена.
            this.detailsTableAdapter.Fill(this.dataSet1.details);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.areas". При необходимости она может быть перемещена или удалена.
            this.areasTableAdapter.Fill(this.dataSet1.areas);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            fill();
        }

        private void dataTable1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            year = Convert.ToInt32(textBox1.Text);
            fill();
        }
    }
}
