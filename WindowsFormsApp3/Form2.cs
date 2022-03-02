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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.production_number". При необходимости она может быть перемещена или удалена.
            this.production_numberTableAdapter.Fill(this.dataSet1.production_number);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.details". При необходимости она может быть перемещена или удалена.
            this.detailsTableAdapter.Fill(this.dataSet1.details);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.areas". При необходимости она может быть перемещена или удалена.
            this.areasTableAdapter.Fill(this.dataSet1.areas);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.production_number". При необходимости она может быть перемещена или удалена.
            this.production_numberTableAdapter.Fill(this.dataSet1.production_number);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.details". При необходимости она может быть перемещена или удалена.
            this.detailsTableAdapter.Fill(this.dataSet1.details);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.areas". При необходимости она может быть перемещена или удалена.
            this.areasTableAdapter.Fill(this.dataSet1.areas);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.DataTable1". При необходимости она может быть перемещена или удалена.
            dataGridView1.AutoGenerateColumns = true;
        }

        private void dataTable1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void areas_Click(object sender, EventArgs e)
        {
            if(lblTableName.Text != "Участки")
            {
                dataGridView1.Columns.Clear(); 
                dataGridView1.DataSource = areasBindingSource;
                dataTable1BindingNavigator.BindingSource = areasBindingSource;
                lblTableName.Text = "Участки";
            }
        }

        private void details_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "Детали")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = detailsBindingSource;
                dataTable1BindingNavigator.BindingSource = areasBindingSource;
                lblTableName.Text = "Детали";
            }
        }

        private void production_number_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "Производственная программа")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = productionnumberBindingSource;
                dataTable1BindingNavigator.BindingSource = areasBindingSource;
                lblTableName.Text = "Производственная программа";
            }
        }

        private void btnUpdate_click_Click(object sender, EventArgs e)
        {
            tableAdapterManager1.UpdateAll(dataSet1);
            MessageBox.Show("Изменения сохранены");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }
    }
}
