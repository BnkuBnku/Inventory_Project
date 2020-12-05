namespace Inventory_Project
{
    partial class Inventory
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
            this.P_datagrid = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.P_updateButton = new System.Windows.Forms.Button();
            this.P_addButton = new System.Windows.Forms.Button();
            this.P_deleteButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.C_updateButton = new System.Windows.Forms.Button();
            this.C_addButton = new System.Windows.Forms.Button();
            this.C_deleteButton = new System.Windows.Forms.Button();
            this.C_datagrid = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBrought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBrought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.P_datagrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // P_datagrid
            // 
            this.P_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.P_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductID,
            this.Model,
            this.Brand,
            this.Attributes});
            this.P_datagrid.Location = new System.Drawing.Point(3, 6);
            this.P_datagrid.Name = "P_datagrid";
            this.P_datagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.P_datagrid.Size = new System.Drawing.Size(740, 378);
            this.P_datagrid.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 445);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.P_updateButton);
            this.tabPage1.Controls.Add(this.P_datagrid);
            this.tabPage1.Controls.Add(this.P_addButton);
            this.tabPage1.Controls.Add(this.P_deleteButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // P_updateButton
            // 
            this.P_updateButton.Location = new System.Drawing.Point(592, 390);
            this.P_updateButton.Name = "P_updateButton";
            this.P_updateButton.Size = new System.Drawing.Size(75, 23);
            this.P_updateButton.TabIndex = 3;
            this.P_updateButton.Text = "Update";
            this.P_updateButton.UseVisualStyleBackColor = true;
            this.P_updateButton.Click += new System.EventHandler(this.P_updateButton_Click);
            // 
            // P_addButton
            // 
            this.P_addButton.Location = new System.Drawing.Point(673, 390);
            this.P_addButton.Name = "P_addButton";
            this.P_addButton.Size = new System.Drawing.Size(75, 23);
            this.P_addButton.TabIndex = 2;
            this.P_addButton.Text = "Add Product";
            this.P_addButton.UseVisualStyleBackColor = true;
            this.P_addButton.Click += new System.EventHandler(this.AP_addButton_Click);
            // 
            // P_deleteButton
            // 
            this.P_deleteButton.Location = new System.Drawing.Point(3, 390);
            this.P_deleteButton.Name = "P_deleteButton";
            this.P_deleteButton.Size = new System.Drawing.Size(75, 23);
            this.P_deleteButton.TabIndex = 1;
            this.P_deleteButton.Text = "Delete";
            this.P_deleteButton.UseVisualStyleBackColor = true;
            this.P_deleteButton.Click += new System.EventHandler(this.P_deleteButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.C_updateButton);
            this.tabPage2.Controls.Add(this.C_addButton);
            this.tabPage2.Controls.Add(this.C_deleteButton);
            this.tabPage2.Controls.Add(this.C_datagrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // C_updateButton
            // 
            this.C_updateButton.Location = new System.Drawing.Point(574, 390);
            this.C_updateButton.Name = "C_updateButton";
            this.C_updateButton.Size = new System.Drawing.Size(84, 23);
            this.C_updateButton.TabIndex = 6;
            this.C_updateButton.Text = "Update Customer";
            this.C_updateButton.UseVisualStyleBackColor = true;
            this.C_updateButton.Click += new System.EventHandler(this.C_updateButton_Click);
            // 
            // C_addButton
            // 
            this.C_addButton.Location = new System.Drawing.Point(664, 390);
            this.C_addButton.Name = "C_addButton";
            this.C_addButton.Size = new System.Drawing.Size(84, 23);
            this.C_addButton.TabIndex = 5;
            this.C_addButton.Text = "Add Customer";
            this.C_addButton.UseVisualStyleBackColor = true;
            this.C_addButton.Click += new System.EventHandler(this.C_addButton_Click);
            // 
            // C_deleteButton
            // 
            this.C_deleteButton.Location = new System.Drawing.Point(3, 390);
            this.C_deleteButton.Name = "C_deleteButton";
            this.C_deleteButton.Size = new System.Drawing.Size(75, 23);
            this.C_deleteButton.TabIndex = 4;
            this.C_deleteButton.Text = "Delete";
            this.C_deleteButton.UseVisualStyleBackColor = true;
            this.C_deleteButton.Click += new System.EventHandler(this.C_deleteButton_Click);
            // 
            // C_datagrid
            // 
            this.C_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.ItemBrought,
            this.DateBrought});
            this.C_datagrid.Location = new System.Drawing.Point(7, 7);
            this.C_datagrid.Name = "C_datagrid";
            this.C_datagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C_datagrid.Size = new System.Drawing.Size(741, 377);
            this.C_datagrid.TabIndex = 0;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 83;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 61;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 60;
            // 
            // Attributes
            // 
            this.Attributes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Attributes.HeaderText = "Attributes";
            this.Attributes.Name = "Attributes";
            this.Attributes.ReadOnly = true;
            this.Attributes.Width = 76;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 90;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 98;
            // 
            // ItemBrought
            // 
            this.ItemBrought.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ItemBrought.HeaderText = "Item Brought";
            this.ItemBrought.Name = "ItemBrought";
            this.ItemBrought.ReadOnly = true;
            this.ItemBrought.Width = 85;
            // 
            // DateBrought
            // 
            this.DateBrought.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DateBrought.HeaderText = "Date Brought";
            this.DateBrought.Name = "DateBrought";
            this.DateBrought.ReadOnly = true;
            this.DateBrought.Width = 87;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P_datagrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.C_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView P_datagrid;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button P_addButton;
        private System.Windows.Forms.Button P_deleteButton;
        private System.Windows.Forms.DataGridView C_datagrid;
        private System.Windows.Forms.Button C_addButton;
        private System.Windows.Forms.Button C_deleteButton;
        private System.Windows.Forms.Button P_updateButton;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button C_updateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemBrought;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBrought;
    }
}

