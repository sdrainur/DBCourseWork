
namespace WindowsFormsApp3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataSet2 = new WindowsFormsApp3.DataSet2();
            this.dataTable1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataTable1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.areas = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Button();
            this.production_number = new System.Windows.Forms.Button();
            this.btnUpdate_click = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.productionnumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp3.DataSet1();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areasTableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.areasTableAdapter();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsTableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.detailsTableAdapter();
            this.production_numberTableAdapter = new WindowsFormsApp3.DataSet1TableAdapters.production_numberTableAdapter();
            this.lblTableName = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new WindowsFormsApp3.DataSet1TableAdapters.TableAdapterManager();
            this.tableAdapterManager2 = new WindowsFormsApp3.DataSet1TableAdapters.TableAdapterManager();
            this.releaseplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workshopidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingNavigator)).BeginInit();
            this.dataTable1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionnumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingNavigator
            // 
            this.dataTable1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataTable1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataTable1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataTable1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dataTable1BindingNavigatorSaveItem});
            this.dataTable1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataTable1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataTable1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataTable1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataTable1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataTable1BindingNavigator.Name = "dataTable1BindingNavigator";
            this.dataTable1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataTable1BindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.dataTable1BindingNavigator.TabIndex = 0;
            this.dataTable1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataTable1BindingNavigatorSaveItem
            // 
            this.dataTable1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataTable1BindingNavigatorSaveItem.Enabled = false;
            this.dataTable1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataTable1BindingNavigatorSaveItem.Image")));
            this.dataTable1BindingNavigatorSaveItem.Name = "dataTable1BindingNavigatorSaveItem";
            this.dataTable1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dataTable1BindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // areas
            // 
            this.areas.Location = new System.Drawing.Point(12, 184);
            this.areas.Name = "areas";
            this.areas.Size = new System.Drawing.Size(140, 54);
            this.areas.TabIndex = 2;
            this.areas.Text = "Участки";
            this.areas.UseVisualStyleBackColor = true;
            this.areas.Click += new System.EventHandler(this.areas_Click);
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(158, 184);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(148, 54);
            this.details.TabIndex = 3;
            this.details.Text = "Детали";
            this.details.UseVisualStyleBackColor = true;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // production_number
            // 
            this.production_number.Location = new System.Drawing.Point(312, 184);
            this.production_number.Name = "production_number";
            this.production_number.Size = new System.Drawing.Size(144, 54);
            this.production_number.TabIndex = 4;
            this.production_number.Text = "Производственная программа";
            this.production_number.UseVisualStyleBackColor = true;
            this.production_number.Click += new System.EventHandler(this.production_number_Click);
            // 
            // btnUpdate_click
            // 
            this.btnUpdate_click.Location = new System.Drawing.Point(462, 184);
            this.btnUpdate_click.Name = "btnUpdate_click";
            this.btnUpdate_click.Size = new System.Drawing.Size(160, 54);
            this.btnUpdate_click.TabIndex = 5;
            this.btnUpdate_click.Text = "Обновить";
            this.btnUpdate_click.UseVisualStyleBackColor = true;
            this.btnUpdate_click.Click += new System.EventHandler(this.btnUpdate_click_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(628, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 54);
            this.button5.TabIndex = 6;
            this.button5.Text = "Закрыть";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // productionnumberBindingSource
            // 
            this.productionnumberBindingSource.DataMember = "production_number";
            this.productionnumberBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // production_numberTableAdapter
            // 
            this.production_numberTableAdapter.ClearBeforeFill = true;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(288, 9);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(35, 13);
            this.lblTableName.TabIndex = 8;
            this.lblTableName.Text = "label1";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.areas1TableAdapter = null;
            this.tableAdapterManager1.areas2TableAdapter = null;
            this.tableAdapterManager1.areasTableAdapter = this.areasTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.detailsTableAdapter = this.detailsTableAdapter;
            this.tableAdapterManager1.production_numberTableAdapter = this.production_numberTableAdapter;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp3.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.areas1TableAdapter = null;
            this.tableAdapterManager2.areas2TableAdapter = null;
            this.tableAdapterManager2.areasTableAdapter = null;
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.detailsTableAdapter = null;
            this.tableAdapterManager2.production_numberTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = WindowsFormsApp3.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // releaseplanDataGridViewTextBoxColumn
            // 
            this.releaseplanDataGridViewTextBoxColumn.DataPropertyName = "release_plan";
            this.releaseplanDataGridViewTextBoxColumn.HeaderText = "release_plan";
            this.releaseplanDataGridViewTextBoxColumn.Name = "releaseplanDataGridViewTextBoxColumn";
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // areaidDataGridViewTextBoxColumn
            // 
            this.areaidDataGridViewTextBoxColumn.DataPropertyName = "area_id";
            this.areaidDataGridViewTextBoxColumn.HeaderText = "area_id";
            this.areaidDataGridViewTextBoxColumn.Name = "areaidDataGridViewTextBoxColumn";
            // 
            // workshopidDataGridViewTextBoxColumn
            // 
            this.workshopidDataGridViewTextBoxColumn.DataPropertyName = "workshop_id";
            this.workshopidDataGridViewTextBoxColumn.HeaderText = "workshop_id";
            this.workshopidDataGridViewTextBoxColumn.Name = "workshopidDataGridViewTextBoxColumn";
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.workshopidDataGridViewTextBoxColumn,
            this.areaidDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.releaseplanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productionnumberBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnUpdate_click);
            this.Controls.Add(this.production_number);
            this.Controls.Add(this.details);
            this.Controls.Add(this.areas);
            this.Controls.Add(this.dataTable1BindingNavigator);
            this.Name = "Form2";
            this.Text = "Альтернативная форма";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingNavigator)).EndInit();
            this.dataTable1BindingNavigator.ResumeLayout(false);
            this.dataTable1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionnumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
   //     private DataSet2TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
   //     private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataTable1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dataTable1BindingNavigatorSaveItem;
        private System.Windows.Forms.Button areas;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.Button production_number;
        private System.Windows.Forms.Button btnUpdate_click;
        private System.Windows.Forms.Button button5;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private DataSet1TableAdapters.areasTableAdapter areasTableAdapter;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private DataSet1TableAdapters.detailsTableAdapter detailsTableAdapter;
        private System.Windows.Forms.BindingSource productionnumberBindingSource;
        private DataSet1TableAdapters.production_numberTableAdapter production_numberTableAdapter;
        private System.Windows.Forms.Label lblTableName;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workshopidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}