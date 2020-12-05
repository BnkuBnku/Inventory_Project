namespace Inventory_Project
{
    partial class AddProductForm
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
            var addProductForm = this;
            addProductForm.lbl_productname = new System.Windows.Forms.Label();
            addProductForm.lbl_model = new System.Windows.Forms.Label();
            addProductForm.lbl_Brand = new System.Windows.Forms.Label();
            addProductForm.lbl_attr = new System.Windows.Forms.Label();
            addProductForm.tb_PN = new System.Windows.Forms.TextBox();
            addProductForm.tb_M = new System.Windows.Forms.TextBox();
            addProductForm.tb_B = new System.Windows.Forms.TextBox();
            addProductForm.tb_AT = new System.Windows.Forms.TextBox();
            addProductForm.AP_addButton = new System.Windows.Forms.Button();
            addProductForm.AP_clearButton = new System.Windows.Forms.Button();
            addProductForm.AP_cancelButton = new System.Windows.Forms.Button();
            addProductForm.SuspendLayout();
            // 
            // lbl_productname
            // 
            addProductForm.lbl_productname.AutoSize = true;
            addProductForm.lbl_productname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addProductForm.lbl_productname.Location = new System.Drawing.Point(31, 42);
            addProductForm.lbl_productname.Name = "lbl_productname";
            addProductForm.lbl_productname.Size = new System.Drawing.Size(110, 20);
            addProductForm.lbl_productname.TabIndex = 0;
            addProductForm.lbl_productname.Text = "Product Name";
            // 
            // lbl_model
            // 
            addProductForm.lbl_model.AutoSize = true;
            addProductForm.lbl_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addProductForm.lbl_model.Location = new System.Drawing.Point(31, 94);
            addProductForm.lbl_model.Name = "lbl_model";
            addProductForm.lbl_model.Size = new System.Drawing.Size(52, 20);
            addProductForm.lbl_model.TabIndex = 1;
            addProductForm.lbl_model.Text = "Model";
            // 
            // lbl_Brand
            // 
            addProductForm.lbl_Brand.AutoSize = true;
            addProductForm.lbl_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addProductForm.lbl_Brand.Location = new System.Drawing.Point(31, 143);
            addProductForm.lbl_Brand.Name = "lbl_Brand";
            addProductForm.lbl_Brand.Size = new System.Drawing.Size(52, 20);
            addProductForm.lbl_Brand.TabIndex = 2;
            addProductForm.lbl_Brand.Text = "Brand";
            // 
            // lbl_attr
            // 
            addProductForm.lbl_attr.AutoSize = true;
            addProductForm.lbl_attr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addProductForm.lbl_attr.Location = new System.Drawing.Point(31, 191);
            addProductForm.lbl_attr.Name = "lbl_attr";
            addProductForm.lbl_attr.Size = new System.Drawing.Size(78, 20);
            addProductForm.lbl_attr.TabIndex = 3;
            addProductForm.lbl_attr.Text = "Attributes";
            // 
            // tb_PN
            // 
            addProductForm.tb_PN.Location = new System.Drawing.Point(163, 41);
            addProductForm.tb_PN.Name = "tb_PN";
            addProductForm.tb_PN.Size = new System.Drawing.Size(349, 20);
            addProductForm.tb_PN.TabIndex = 4;
            // 
            // tb_M
            // 
            addProductForm.tb_M.Location = new System.Drawing.Point(163, 94);
            addProductForm.tb_M.Name = "tb_M";
            addProductForm.tb_M.Size = new System.Drawing.Size(349, 20);
            addProductForm.tb_M.TabIndex = 5;
            // 
            // tb_B
            // 
            addProductForm.tb_B.Location = new System.Drawing.Point(163, 143);
            addProductForm.tb_B.Name = "tb_B";
            addProductForm.tb_B.Size = new System.Drawing.Size(108, 20);
            addProductForm.tb_B.TabIndex = 6;
            // 
            // tb_AT
            // 
            addProductForm.tb_AT.Location = new System.Drawing.Point(163, 191);
            addProductForm.tb_AT.Name = "tb_AT";
            addProductForm.tb_AT.Size = new System.Drawing.Size(108, 20);
            addProductForm.tb_AT.TabIndex = 7;
            // 
            // AP_addButton
            // 
            addProductForm.AP_addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addProductForm.AP_addButton.Location = new System.Drawing.Point(423, 329);
            addProductForm.AP_addButton.Name = "AP_addButton";
            addProductForm.AP_addButton.Size = new System.Drawing.Size(89, 32);
            addProductForm.AP_addButton.TabIndex = 8;
            addProductForm.AP_addButton.Text = "&add";
            addProductForm.AP_addButton.UseVisualStyleBackColor = true;
            addProductForm.AP_addButton.Click += new System.EventHandler(addProductForm.AP_addButton_Click);
            // 
            // AP_clearButton
            // 
            addProductForm.AP_clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addProductForm.AP_clearButton.Location = new System.Drawing.Point(20, 329);
            addProductForm.AP_clearButton.Name = "AP_clearButton";
            addProductForm.AP_clearButton.Size = new System.Drawing.Size(89, 32);
            addProductForm.AP_clearButton.TabIndex = 9;
            addProductForm.AP_clearButton.Text = "clear";
            addProductForm.AP_clearButton.UseVisualStyleBackColor = true;
            addProductForm.AP_clearButton.Click += new System.EventHandler(addProductForm.AP_clearButton_Click);
            // 
            // AP_cancelButton
            // 
            addProductForm.AP_cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addProductForm.AP_cancelButton.Location = new System.Drawing.Point(328, 329);
            addProductForm.AP_cancelButton.Name = "AP_cancelButton";
            addProductForm.AP_cancelButton.Size = new System.Drawing.Size(89, 32);
            addProductForm.AP_cancelButton.TabIndex = 10;
            addProductForm.AP_cancelButton.Text = "cancel";
            addProductForm.AP_cancelButton.UseVisualStyleBackColor = true;
            addProductForm.AP_cancelButton.Click += new System.EventHandler(addProductForm.AP_cancelButton_Click);
            // 
            // AddProductForm
            // 
            addProductForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            addProductForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            addProductForm.ClientSize = new System.Drawing.Size(523, 389);
            addProductForm.Controls.Add(addProductForm.AP_cancelButton);
            addProductForm.Controls.Add(addProductForm.AP_clearButton);
            addProductForm.Controls.Add(addProductForm.AP_addButton);
            addProductForm.Controls.Add(addProductForm.tb_AT);
            addProductForm.Controls.Add(addProductForm.tb_B);
            addProductForm.Controls.Add(addProductForm.tb_M);
            addProductForm.Controls.Add(addProductForm.tb_PN);
            addProductForm.Controls.Add(addProductForm.lbl_attr);
            addProductForm.Controls.Add(addProductForm.lbl_Brand);
            addProductForm.Controls.Add(addProductForm.lbl_model);
            addProductForm.Controls.Add(addProductForm.lbl_productname);
            addProductForm.Name = "AddProductForm";
            addProductForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            addProductForm.Text = "Add Product";
            addProductForm.ResumeLayout(false);
            addProductForm.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_productname;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Label lbl_attr;
        private System.Windows.Forms.TextBox tb_PN;
        private System.Windows.Forms.TextBox tb_M;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.TextBox tb_AT;
        private System.Windows.Forms.Button AP_addButton;
        private System.Windows.Forms.Button AP_clearButton;
        private System.Windows.Forms.Button AP_cancelButton;
    }
}