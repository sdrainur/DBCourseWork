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
    public partial class Zadacha2_2 : Form
    {
        int year;
        public Zadacha2_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            year = Convert.ToInt32(textBox1.Text);
            this.dataTable6TableAdapter.Fill(this.dataSet1.DataTable6, year);
            dataGridView1.Refresh();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Zadacha2_2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.production_number". При необходимости она может быть перемещена или удалена.
            //this.production_numberTableAdapter.Fill(this.dataSet1.production_number);
            /*dataGridView1.AutoGenerateColumns = true;
            this.dataTable6TableAdapter.Fill(this.dataSet1.DataTable6, 0);
            this.Text = "Запрос";*/
        }
    }
}
