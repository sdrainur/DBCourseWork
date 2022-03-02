using Npgsql;
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
    public partial class Zadacha1_5 : Form
    {
        public int year, month;
        public Zadacha1_5()
        {
            InitializeComponent();
            fillByDataReader();
        }

        private void dataTable1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataTable1BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void fillByDataReader()
        {
            string constr = String.Format("Host = localhost; Database=postgres;Username=postgres;Password=qwerty");
            NpgsqlConnection con = new NpgsqlConnection(constr);
            con.Open();
            String str = "SELECT areas.workshop_id, areas.area_name, production_number.product_id, production_number.release_plan "
            + " FROM areas INNER JOIN production_number ON areas.workshop_id = production_number.workshop_id " +
            " WHERE(production_number.month = " + month + ") AND(production_number.year = " + year + ") ";
            NpgsqlCommand cmd = new NpgsqlCommand(str, con);
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataTable1DataGridView.DataSource = bs;
            dataTable1BindingNavigator.BindingSource = bs;
            dataTable1DataGridView.Refresh();
        }

        private void Zadacha1_5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            fillByDataReader();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            month = Convert.ToInt32(textBox1.Text);
            year = Convert.ToInt32(textBox2.Text);
            fillByDataReader();
        }
    }
}
