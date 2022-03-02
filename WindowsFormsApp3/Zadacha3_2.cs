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
    public partial class Zadacha3_2 : Form
    {
        private int price;
        private int production;
        private int year;
        public Zadacha3_2()
        {
            InitializeComponent();
        }

        private void Zadacha3_2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.areas1". При необходимости она может быть перемещена или удалена.
            this.areas1TableAdapter.Fill(this.dataSet1.areas1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.production_number". При необходимости она может быть перемещена или удалена.
            this.production_numberTableAdapter.Fill(this.dataSet1.production_number);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.details". При необходимости она может быть перемещена или удалена.
            this.detailsTableAdapter.Fill(this.dataSet1.details);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.areas". При необходимости она может быть перемещена или удалена.
            this.areasTableAdapter.Fill(this.dataSet1.areas);
            fill();

            dataSet1.areas2.Clear();
        }

        private void areasDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fill()
        {
 
            bool t1, t2;
            dataSet1.areas2.Clear();
            foreach (DataSet1.areasRow sRow in dataSet1.areas.Rows)
            {
                t1 = false;
                foreach (DataSet1.detailsRow dRow in dataSet1.details.Rows)
                {
                    
                    if (dRow.price > price)
                    {
                        t2 = true;
                        foreach (DataSet1.production_numberRow pRow in dataSet1.production_number.Rows)
                        {
                            if (pRow.product_id == dRow.detail_id &
                                         (pRow.area_id == sRow.area_id))
                            {
                                t2 = ((pRow.release_plan <= production) &
                                         (pRow.year == year));
                            }
                        }
                        t1 = t2;
                    }
                    if (!t1 & dRow.price > price)
                    {
                        DataSet1.areas2Row zRow = dataSet1.areas2.Newareas2Row();
                        zRow.area_id = sRow.area_id;
                        zRow.workshop_id = sRow.workshop_id;
                        zRow.area_name = sRow.area_name;
                        zRow.master_id = sRow.master_id;
                        dataSet1.areas2.Rows.Add(zRow);
                        break;
                    }
                }
            }
            dataGridView1.Refresh();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            price = Convert.ToInt32(textBox1.Text);
            production = Convert.ToInt32(textBox2.Text);
            year = Convert.ToInt32(textBox3.Text);
            fill();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
