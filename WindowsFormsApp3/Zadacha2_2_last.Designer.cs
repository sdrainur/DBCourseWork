
namespace WindowsFormsApp3
{
    partial class Zadacha2_2_last
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
            this.dataSet11 = new WindowsFormsApp3.DataSet1();
            this.dataSet1 = new WindowsFormsApp3.DataSet1();
            this.dataTable6TableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.DataTable6TableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.dataTable7TableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.DataTable7TableAdapter();
            this.dataTable6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6BindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.dataTable6BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable6TableAdapter
            // 
            this.dataTable6TableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(555, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(662, 9);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Ввод";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataTable7TableAdapter
            // 
            this.dataTable7TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable6BindingSource
            // 
            this.dataTable6BindingSource.DataMember = "DataTable6";
            this.dataTable6BindingSource.DataSource = this.dataSet11;
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
            // Zadacha2_2_last
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zadacha2_2_last";
            this.Text = "Задача 2";
            this.Load += new System.EventHandler(this.Zadacha2_2_last_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.DataTable6TableAdapter dataTable6TableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.DataTable7TableAdapter dataTable7TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable6BindingSource;
    }
}