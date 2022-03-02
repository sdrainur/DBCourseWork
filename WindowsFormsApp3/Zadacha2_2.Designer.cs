
namespace WindowsFormsApp3
{
    partial class Zadacha2_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataTable6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new WindowsFormsApp3.DataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp3.DataSet1();
            this.dataTable4TableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.DataTable4TableAdapter();
            this.productionnumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.production_numberTableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.production_numberTableAdapter();
            this.dataTable6TableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.DataTable6TableAdapter();
            this.dataTable6BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionnumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.areaidDataGridViewTextBoxColumn,
            this.areanameDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable6BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataTable6BindingSource
            // 
            this.dataTable6BindingSource.DataMember = "DataTable6";
            this.dataTable6BindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(517, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataTable4BindingSource
            // 
            this.dataTable4BindingSource.DataMember = "DataTable4";
            this.dataTable4BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable4TableAdapter
            // 
            this.dataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // productionnumberBindingSource
            // 
            this.productionnumberBindingSource.DataMember = "production_number";
            this.productionnumberBindingSource.DataSource = this.dataSet1;
            // 
            // production_numberTableAdapter
            // 
            this.production_numberTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable6TableAdapter
            // 
            this.dataTable6TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable6BindingSource1
            // 
            this.dataTable6BindingSource1.DataMember = "DataTable6";
            this.dataTable6BindingSource1.DataSource = this.dataSet11;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            // 
            // areaidDataGridViewTextBoxColumn
            // 
            this.areaidDataGridViewTextBoxColumn.DataPropertyName = "area_id";
            this.areaidDataGridViewTextBoxColumn.HeaderText = "area_id";
            this.areaidDataGridViewTextBoxColumn.Name = "areaidDataGridViewTextBoxColumn";
            // 
            // areanameDataGridViewTextBoxColumn
            // 
            this.areanameDataGridViewTextBoxColumn.DataPropertyName = "area_name";
            this.areanameDataGridViewTextBoxColumn.HeaderText = "area_name";
            this.areanameDataGridViewTextBoxColumn.Name = "areanameDataGridViewTextBoxColumn";
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "expr1";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            // 
            // Zadacha2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zadacha2_2";
            this.Text = "Zadacha2_2";
            this.Load += new System.EventHandler(this.Zadacha2_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionnumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dataTable4BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.DataTable4TableAdapter dataTable4TableAdapter;
        private System.Windows.Forms.BindingSource productionnumberBindingSource;
        private DataSet1TableAdapters.production_numberTableAdapter production_numberTableAdapter;
        private System.Windows.Forms.BindingSource dataTable6BindingSource;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.DataTable6TableAdapter dataTable6TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable6BindingSource1;
    }
}