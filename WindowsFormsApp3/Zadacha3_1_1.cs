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
    public partial class Zadacha3_1_1 : Form
    {
        public Zadacha3_1_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            this.zadacha3TableAdapter.Fill(this.dataSet1.Zadacha3, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),
                Convert.ToInt32(textBox3.Text));
            dataGridView1.Refresh();
        }
    }
}
