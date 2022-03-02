
namespace WindowsFormsApp3
{
    partial class Zadacha_3_1
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
            this.workshopidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areas2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp3.DataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.areas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areasTableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.areasTableAdapter();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsTableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.detailsTableAdapter();
            this.productionnumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.production_numberTableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.production_numberTableAdapter();
            this.areas1TableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.areas1TableAdapter();
            this.areas2TableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.areas2TableAdapter();
            this.dataSet11 = new WindowsFormsApp3.DataSet1();
            this.dataSet12 = new WindowsFormsApp3.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areas2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areas1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionnumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workshopidDataGridViewTextBoxColumn,
            this.areaidDataGridViewTextBoxColumn,
            this.areanameDataGridViewTextBoxColumn,
            this.masteridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.areas2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // workshopidDataGridViewTextBoxColumn
            // 
            this.workshopidDataGridViewTextBoxColumn.DataPropertyName = "workshop_id";
            this.workshopidDataGridViewTextBoxColumn.HeaderText = "workshop_id";
            this.workshopidDataGridViewTextBoxColumn.Name = "workshopidDataGridViewTextBoxColumn";
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
            // masteridDataGridViewTextBoxColumn
            // 
            this.masteridDataGridViewTextBoxColumn.DataPropertyName = "master_id";
            this.masteridDataGridViewTextBoxColumn.HeaderText = "master_id";
            this.masteridDataGridViewTextBoxColumn.Name = "masteridDataGridViewTextBoxColumn";
            // 
            // areas2BindingSource
            // 
            this.areas2BindingSource.DataMember = "areas2";
            this.areas2BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(548, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Год";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(547, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // areas1BindingSource
            // 
            this.areas1BindingSource.DataMember = "areas1";
            this.areas1BindingSource.DataSource = this.dataSet1;
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "areas";
            this.areasBindingSource.DataSource = this.dataSet1;
            // 
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "details";
            this.detailsBindingSource.DataSource = this.dataSet1;
            // 
            // detailsTableAdapter
            // 
            this.detailsTableAdapter.ClearBeforeFill = true;
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
            // areas1TableAdapter
            // 
            this.areas1TableAdapter.ClearBeforeFill = true;
            // 
            // areas2TableAdapter
            // 
            this.areas2TableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Zadacha_3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zadacha_3_1";
            this.Text = "Задача 3";
            this.Load += new System.EventHandler(this.Zadacha_3_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areas2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areas1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionnumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private DataSet1TableAdapters.areasTableAdapter areasTableAdapter;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private DataSet1TableAdapters.detailsTableAdapter detailsTableAdapter;
        private System.Windows.Forms.BindingSource productionnumberBindingSource;
        private DataSet1TableAdapters.production_numberTableAdapter production_numberTableAdapter;
        private System.Windows.Forms.BindingSource areas1BindingSource;
        private DataSet1TableAdapters.areas1TableAdapter areas1TableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workshopidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masteridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource areas2BindingSource;
        private DataSet1TableAdapters.areas2TableAdapter areas2TableAdapter;
        private DataSet1 dataSet11;
        private DataSet1 dataSet12;
    }
}