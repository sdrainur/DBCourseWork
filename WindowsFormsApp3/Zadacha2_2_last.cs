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
    public partial class Zadacha2_2_last : Form
    {
        public Zadacha2_2_last()
        {
            InitializeComponent();
        }

        private void Zadacha2_2_last_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.DataTable6". При необходимости она может быть перемещена или удалена.
            this.dataTable6TableAdapter.Fill(this.dataSet1.DataTable6, 0);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.dataTable6TableAdapter.Fill(this.dataSet1.DataTable6, Convert.ToInt32(textBox1.Text));
            dataGridView1.Refresh();
        }
    }
}
