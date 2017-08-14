namespace CST_117___Inventory_Project
{
    partial class DonutUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonutUI));
            this.DonutMenuLabel = new System.Windows.Forms.Label();
            this.RemoveDonutButton = new System.Windows.Forms.Button();
            this.AddDonutButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.MyBoxButton = new System.Windows.Forms.Button();
            this.tst_InventorySystemDataSet = new CST_117___Inventory_Project.tst_InventorySystemDataSet();
            this.donutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donutTableAdapter = new CST_117___Inventory_Project.tst_InventorySystemDataSetTableAdapters.DonutTableAdapter();
            this.tableAdapterManager = new CST_117___Inventory_Project.tst_InventorySystemDataSetTableAdapters.TableAdapterManager();
            this.donutBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.donutBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tst_InventorySystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donutBindingNavigator)).BeginInit();
            this.donutBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DonutMenuLabel
            // 
            this.DonutMenuLabel.AutoSize = true;
            this.DonutMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonutMenuLabel.Location = new System.Drawing.Point(293, 42);
            this.DonutMenuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DonutMenuLabel.Name = "DonutMenuLabel";
            this.DonutMenuLabel.Size = new System.Drawing.Size(183, 55);
            this.DonutMenuLabel.TabIndex = 18;
            this.DonutMenuLabel.Text = "Donuts";
            // 
            // RemoveDonutButton
            // 
            this.RemoveDonutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveDonutButton.Location = new System.Drawing.Point(14, 243);
            this.RemoveDonutButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveDonutButton.Name = "RemoveDonutButton";
            this.RemoveDonutButton.Size = new System.Drawing.Size(184, 79);
            this.RemoveDonutButton.TabIndex = 20;
            this.RemoveDonutButton.Text = "Remove Donut";
            this.RemoveDonutButton.UseVisualStyleBackColor = true;
            // 
            // AddDonutButton
            // 
            this.AddDonutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDonutButton.Location = new System.Drawing.Point(13, 148);
            this.AddDonutButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddDonutButton.Name = "AddDonutButton";
            this.AddDonutButton.Size = new System.Drawing.Size(185, 79);
            this.AddDonutButton.TabIndex = 21;
            this.AddDonutButton.Text = "Add Donut";
            this.AddDonutButton.UseVisualStyleBackColor = true;
            this.AddDonutButton.Click += new System.EventHandler(this.AddDonutButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.Location = new System.Drawing.Point(14, 424);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(184, 43);
            this.MenuButton.TabIndex = 23;
            this.MenuButton.Text = "Main Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // MyBoxButton
            // 
            this.MyBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyBoxButton.Location = new System.Drawing.Point(226, 424);
            this.MyBoxButton.Margin = new System.Windows.Forms.Padding(2);
            this.MyBoxButton.Name = "MyBoxButton";
            this.MyBoxButton.Size = new System.Drawing.Size(185, 43);
            this.MyBoxButton.TabIndex = 24;
            this.MyBoxButton.Text = "Your Box";
            this.MyBoxButton.UseVisualStyleBackColor = true;
            this.MyBoxButton.Click += new System.EventHandler(this.MyBoxButton_Click);
            // 
            // tst_InventorySystemDataSet
            // 
            this.tst_InventorySystemDataSet.DataSetName = "tst_InventorySystemDataSet";
            this.tst_InventorySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donutBindingSource
            // 
            this.donutBindingSource.DataMember = "Donut";
            this.donutBindingSource.DataSource = this.tst_InventorySystemDataSet;
            // 
            // donutTableAdapter
            // 
            this.donutTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DonutTableAdapter = this.donutTableAdapter;
            this.tableAdapterManager.UpdateOrder = CST_117___Inventory_Project.tst_InventorySystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // donutBindingNavigator
            // 
            this.donutBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.donutBindingNavigator.BindingSource = this.donutBindingSource;
            this.donutBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.donutBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.donutBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.donutBindingNavigatorSaveItem});
            this.donutBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.donutBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.donutBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.donutBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.donutBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.donutBindingNavigator.Name = "donutBindingNavigator";
            this.donutBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.donutBindingNavigator.Size = new System.Drawing.Size(839, 25);
            this.donutBindingNavigator.TabIndex = 25;
            this.donutBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // donutBindingNavigatorSaveItem
            // 
            this.donutBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.donutBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("donutBindingNavigatorSaveItem.Image")));
            this.donutBindingNavigatorSaveItem.Name = "donutBindingNavigatorSaveItem";
            this.donutBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.donutBindingNavigatorSaveItem.Text = "Save Data";
            this.donutBindingNavigatorSaveItem.Click += new System.EventHandler(this.donutBindingNavigatorSaveItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(226, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 231);
            this.dataGridView1.TabIndex = 26;
            // 
            // DonutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 488);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.donutBindingNavigator);
            this.Controls.Add(this.MyBoxButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.AddDonutButton);
            this.Controls.Add(this.RemoveDonutButton);
            this.Controls.Add(this.DonutMenuLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DonutUI";
            this.Text = "Donut";
            this.Load += new System.EventHandler(this.DonutUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tst_InventorySystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donutBindingNavigator)).EndInit();
            this.donutBindingNavigator.ResumeLayout(false);
            this.donutBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DonutMenuLabel;
        private System.Windows.Forms.Button RemoveDonutButton;
        private System.Windows.Forms.Button AddDonutButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button MyBoxButton;
        private tst_InventorySystemDataSet tst_InventorySystemDataSet;
        private System.Windows.Forms.BindingSource donutBindingSource;
        private tst_InventorySystemDataSetTableAdapters.DonutTableAdapter donutTableAdapter;
        private tst_InventorySystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator donutBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton donutBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}