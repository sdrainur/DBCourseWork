using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void areasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.production_number". При необходимости она может быть перемещена или удалена.
            this.production_numberTableAdapter.Fill(this.dataSet1.production_number);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.production_number". При необходимости она может быть перемещена или удалена.
            this.production_numberTableAdapter.Fill(this.dataSet1.production_number);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.details". При необходимости она может быть перемещена или удалена.
            this.detailsTableAdapter.Fill(this.dataSet1.details);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.areas". При необходимости она может быть перемещена или удалена.
            this.areasTableAdapter.Fill(this.dataSet1.areas);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.production_number". При необходимости она может быть перемещена или удалена.
            this.production_numberTableAdapter.Fill(this.dataSet1.production_number);
        }

        private void lblTable_Click(object sender, EventArgs e)
        {

        }
        /*private void areasdataGridView_Click(object sender, EventArgs e) 
        { 
            bindingNavigator1.BindingSource = areasBindingSource; 
            lblTable.Text = "Покупатели";
            this workshop_iddataGridView.DataSource = rASHTOVBindingSource;
            this.pOKUPATELIdataGridView.DataSource = rASHPOKBindingSource;
        }
        private void detailsdataGridView_Click(object sender, EventArgs e) 
        { 
            bindingNavigator1.BindingSource = detailsBindingSource; 
            lblTable.Text = "Товары"; 
        }
        private void production_numberdataGridView_Click(object sender, EventArgs e)
        {
            production_numberDataGridView.DataSource = production_numberBindingSource; 
            lblTable.Text = "Покупки"; 
        }*/

        private void areasBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            int nRow = production_numberDataGridView.RowCount;
            int nCol = production_numberDataGridView.CurrentCell.ColumnIndex;
            production_numberDataGridView.CurrentCell = production_numberDataGridView[nCol, nRow-2];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Считываем номер строки и столбца активной ячейки.
            int nRow = production_numberDataGridView.CurrentCell.RowIndex;
            int nCol = production_numberDataGridView.CurrentCell.ColumnIndex;
            // Если строка –не последняя, увеличиваем номер строки на 1, 
            // в противном случае соответству
            if (nRow < production_numberDataGridView.RowCount - 1)
                production_numberDataGridView.CurrentCell = production_numberDataGridView[nCol, ++nRow];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                production_numberTableAdapter.Update(dataSet1.production_number);
                areasTableAdapter.Update(dataSet1.areas);
                detailsTableAdapter.Update(dataSet1.details);
                //this.production_numberTableAdapter.Update(this.dataSet1.production_number);
                //this.production_numberTableAdapter.Fill(this.dataSet1.production_number);
                //this.production_numberDataGridView.CurrentCellChanged(production_numberDataGridView, e);
                MessageBox.Show("Данные сохранны");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

/*
        private void production_numberDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (production_numberDataGridView.CurrentCell != null)
                int nRow = production_numberDataGridView.CurrentCell.RowIndex;
            int nRow = production_numberDataGridView.CurrentCell.RowIndex;
            if (nRow == 0)
            {
                btnPrev.Enabled = false;
                btnFirst.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
                btnFirst.Enabled = true;
            }

            if (nRow == rASXODdataGridView.RowCount - 1)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
        }
    */
    



            private void btnRefresh_Click(object sender, EventArgs e)
            {
            this.detailsTableAdapter.Fill(this.dataSet1.details);
     
            this.areasTableAdapter.Fill(this.dataSet1.areas);
            
            this.production_numberTableAdapter.Fill(this.dataSet1.production_number);

            MessageBox.Show("Данные обновлены");

        }

            private void btnPrev_Click(object sender, EventArgs e)
            {
                int nRow = production_numberDataGridView.CurrentCell.RowIndex;
                int nCol = production_numberDataGridView.CurrentCell.ColumnIndex;
                if (nRow > 0)
                    production_numberDataGridView.CurrentCell = production_numberDataGridView[nCol, --nRow];
            }

            private void btnFirst_Click(object sender, EventArgs e)
            {
                int nCol = production_numberDataGridView.CurrentCell.ColumnIndex;
                production_numberDataGridView.CurrentCell = production_numberDataGridView[nCol, 0];
            }

            private void areasDataGridView1_Click(object sender, EventArgs e)
            {/*
            bindingNavigator1.BindingSource = areasBindingSource;
            this.areasDataGridView1.DataSource = areasBindingSource;*/
            }

            private void areasDataGridView_Click(object sender, EventArgs e)
            {/*
            bindingNavigator1.BindingSource = detailsBindingSource;
            this.areasDataGridView.DataSource = detailsBindingSource;*/
            }

            private void production_numberDataGridView_Click(object sender, EventArgs e)
            {/*
            production_numberDataGridView.DataSource = production_numberBindingSource;
            this.areasDataGridView1.DataSource = areasproductionnumberBindingSource;
            this.areasDataGridView.DataSource = detailsproductionnumberBindingSource;*/
            }

            private void areasDataGridView1_Click_1(object sender, EventArgs e)
            {
                bindingNavigator1.BindingSource = areasBindingSource;
                production_numberDataGridView.DataSource = areasproductionnumberBindingSource1;
                label2.Text = "Участки";
        }

            private void areasDataGridView_Click_1(object sender, EventArgs e)
            {
                bindingNavigator1.BindingSource = detailsBindingSource;
                production_numberDataGridView.DataSource = detailsproductionnumberBindingSource; 
                label2.Text = "Детали";
        }

            private void production_numberDataGridView_Click_1(object sender, EventArgs e)
            {
                production_numberDataGridView.DataSource = production_numberBindingSource;
                production_numberDataGridView.DataSource = production_numberBindingSource;
                label2.Text = "Произвоственная программа";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
            string det = areasDataGridView.CurrentRow.Cells["detailidDataGridViewTextBoxColumn"]
                .Value.ToString();
            string conStr = Properties.Settings.Default.postgresConnectionString;
            Npgsql.NpgsqlConnection con = new Npgsql.NpgsqlConnection("Host = localhost; Database = postgres; Username = postgres; Password = qwerty");
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand();
//            Command cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "@name_function";
            cmd.Parameters.AddWithValue("@temp_detail_id", det);

            Npgsql.NpgsqlParameter param = new Npgsql.NpgsqlParameter()
            {
                ParameterName = "@temp_release_plan",
                Direction = ParameterDirection.Output,
                DbType = DbType.Int32,
                Size = 13,
                Precision = 2
            };
            
            cmd.Parameters.Add(param);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string result = cmd.Parameters["@temp_release_plan"].Value.ToString();
            label1.Text = result; */

            string connstring = String.Format("Host = localhost; Database=postgres;Username=postgres;Password=qwerty");
            label1.Visible = true;
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            int det_id = Int32.Parse(areasDataGridView.CurrentRow.Cells["detailidDataGridViewTextBoxColumn"].Value.ToString());
            string sql = @"CALL name_procedure2(:detail_id, :release_plan)";
            //sql = @"CALL name_function(:detail_id)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("detail_id", det_id);
            cmd.Parameters.AddWithValue("release_plan", 0);
            DataTable data_table = new DataTable();
            data_table.Load(cmd.ExecuteReader());
            //string result = cmd.Parameters["release_plan"].Value.ToString();
            //label1.Text = result;
            DataRow[] rows = data_table.Select();
            label1.Text = "Результат работы процедуры: " + rows[0][0].ToString();
            conn.Close();
        }

        private void label1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void formsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void основнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void альтернативнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); 
            f2.Show();
        }

        private void вариант1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void вариант2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha1_2 z2 = new Zadacha1_2();
            z2.Show();
        }

        private void вариант3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha1_3 z3 = new Zadacha1_3();
            z3.Show();
        }

        private void вариант4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha1_4 z4 = new Zadacha1_4();
            z4.Show();
        }

        private void areasDataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = "Участки";
        }

        private void вариант5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha1_5 z5 = new Zadacha1_5();
            z5.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void частьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 number3 = new Form4();
            number3.Show();
        }

        private void вариант1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Zadacha2_1 zadacha2_1 = new Zadacha2_1();
            zadacha2_1.Show();
        }

        private void вариант2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Zadacha3_2 zadacha3_2 = new Zadacha3_2();
            zadacha3_2.Show();
        }

        private void вариант1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Zadacha_3_1 zadacha_3_1 = new Zadacha_3_1();
            zadacha_3_1.Show();
        }

        private void вариант2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Zadacha2_2 zadacha2_2 = new Zadacha2_2();
            zadacha2_2.Show();
        }

        private void вариант2ИсправлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha2_2_last zadacha2_2_Last = new Zadacha2_2_last();
            zadacha2_2_Last.Show();
        }

        private void вариант2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Zadacha2_2_ispr zadacha2_2_Ispr = new Zadacha2_2_ispr();
            zadacha2_2_Ispr.Show();
        }

        private void вариант11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zadacha3_1_1 zadacha3_1_1 = new Zadacha3_1_1();
            zadacha3_1_1.Show();
        }
    }
}
    
