namespace Inventory_Project
{
    partial class UpdateProductForm
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
            this.lbl_productname = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_attr = new System.Windows.Forms.Label();
            this.tb_PN = new System.Windows.Forms.TextBox();
            this.tb_M = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.tb_AT = new System.Windows.Forms.TextBox();
            this.UP_updateButton = new System.Windows.Forms.Button();
            this.UP_clearButton = new System.Windows.Forms.Button();
            this.UP_cancelButton = new System.Windows.Forms.Button();
            this.lbl_productid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productname.Location = new System.Drawing.Point(31, 42);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(110, 20);
            this.lbl_productname.TabIndex = 0;
            this.lbl_productname.Text = "Product Name";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(31, 94);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(52, 20);
            this.lbl_model.TabIndex = 1;
            this.lbl_model.Text = "Model";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand.Location = new System.Drawing.Point(31, 143);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(52, 20);
            this.lbl_Brand.TabIndex = 2;
            this.lbl_Brand.Text = "Brand";
            // 
            // lbl_attr
            // 
            this.lbl_attr.AutoSize = true;
            this.lbl_attr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attr.Location = new System.Drawing.Point(31, 191);
            this.lbl_attr.Name = "lbl_attr";
            this.lbl_attr.Size = new System.Drawing.Size(78, 20);
            this.lbl_attr.TabIndex = 3;
            this.lbl_attr.Text = "Attributes";
            // 
            // tb_PN
            // 
            this.tb_PN.Location = new System.Drawing.Point(163, 41);
            this.tb_PN.Name = "tb_PN";
            this.tb_PN.Size = new System.Drawing.Size(349, 20);
            this.tb_PN.TabIndex = 4;
            // 
            // tb_M
            // 
            this.tb_M.Location = new System.Drawing.Point(163, 94);
            this.tb_M.Name = "tb_M";
            this.tb_M.Size = new System.Drawing.Size(349, 20);
            this.tb_M.TabIndex = 5;
            // 
            // tb_B
            // 
            this.tb_B.Location = new System.Drawing.Point(163, 143);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(108, 20);
            this.tb_B.TabIndex = 6;
            // 
            // tb_AT
            // 
            this.tb_AT.Location = new System.Drawing.Point(163, 191);
            this.tb_AT.Name = "tb_AT";
            this.tb_AT.Size = new System.Drawing.Size(108, 20);
            this.tb_AT.TabIndex = 7;
            // 
            // UP_updateButton
            // 
            this.UP_updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UP_updateButton.Location = new System.Drawing.Point(423, 329);
            this.UP_updateButton.Name = "UP_updateButton";
            this.UP_updateButton.Size = new System.Drawing.Size(89, 32);
            this.UP_updateButton.TabIndex = 8;
            this.UP_updateButton.Text = "&update";
            this.UP_updateButton.UseVisualStyleBackColor = true;
            this.UP_updateButton.Click += new System.EventHandler(this.UP_updateButton_Click);
            // 
            // UP_clearButton
            // 
            this.UP_clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UP_clearButton.Location = new System.Drawing.Point(20, 329);
            this.UP_clearButton.Name = "UP_clearButton";
            this.UP_clearButton.Size = new System.Drawing.Size(89, 32);
            this.UP_clearButton.TabIndex = 9;
            this.UP_clearButton.Text = "clear";
            this.UP_clearButton.UseVisualStyleBackColor = true;
            this.UP_clearButton.Click += new System.EventHandler(this.UP_clearButton_Click);
            // 
            // UP_cancelButton
            // 
            this.UP_cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UP_cancelButton.Location = new System.Drawing.Point(328, 329);
            this.UP_cancelButton.Name = "UP_cancelButton";
            this.UP_cancelButton.Size = new System.Drawing.Size(89, 32);
            this.UP_cancelButton.TabIndex = 10;
            this.UP_cancelButton.Text = "cancel";
            this.UP_cancelButton.UseVisualStyleBackColor = true;
            this.UP_cancelButton.Click += new System.EventHandler(this.UP_cancelButton_Click);
            // 
            // lbl_productid
            // 
            this.lbl_productid.AutoSize = true;
            this.lbl_productid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productid.Location = new System.Drawing.Point(31, 74);
            this.lbl_productid.Name = "lbl_productid";
            this.lbl_productid.Size = new System.Drawing.Size(85, 20);
            this.lbl_productid.TabIndex = 11;
            this.lbl_productid.Text = "Product ID";
            this.lbl_productid.Visible = false;
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 389);
            this.Controls.Add(this.lbl_productid);
            this.Controls.Add(this.UP_cancelButton);
            this.Controls.Add(this.UP_clearButton);
            this.Controls.Add(this.UP_updateButton);
            this.Controls.Add(this.tb_AT);
            this.Controls.Add(this.tb_B);
            this.Controls.Add(this.tb_M);
            this.Controls.Add(this.tb_PN);
            this.Controls.Add(this.lbl_attr);
            this.Controls.Add(this.lbl_Brand);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_productname);
            this.Name = "UpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.UpdateProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button UP_updateButton;
        private System.Windows.Forms.Button UP_clearButton;
        private System.Windows.Forms.Button UP_cancelButton;
        private System.Windows.Forms.Label lbl_productid;
    }
}