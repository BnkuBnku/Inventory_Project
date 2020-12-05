namespace Inventory_Project
{
    partial class AddCustomerForm
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
            this.lbl_CN = new System.Windows.Forms.Label();
            this.lbl_IB = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_CN = new System.Windows.Forms.TextBox();
            this.tb_IB = new System.Windows.Forms.TextBox();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.ACI_addButton = new System.Windows.Forms.Button();
            this.ACI_deleteButton = new System.Windows.Forms.Button();
            this.ACI_cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CN
            // 
            this.lbl_CN.AutoSize = true;
            this.lbl_CN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CN.Location = new System.Drawing.Point(30, 48);
            this.lbl_CN.Name = "lbl_CN";
            this.lbl_CN.Size = new System.Drawing.Size(124, 20);
            this.lbl_CN.TabIndex = 1;
            this.lbl_CN.Text = "Customer Name";
            // 
            // lbl_IB
            // 
            this.lbl_IB.AutoSize = true;
            this.lbl_IB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IB.Location = new System.Drawing.Point(30, 99);
            this.lbl_IB.Name = "lbl_IB";
            this.lbl_IB.Size = new System.Drawing.Size(102, 20);
            this.lbl_IB.TabIndex = 2;
            this.lbl_IB.Text = "Item Brought";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(30, 150);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(44, 20);
            this.lbl_Date.TabIndex = 3;
            this.lbl_Date.Text = "Date";
            // 
            // tb_CN
            // 
            this.tb_CN.Location = new System.Drawing.Point(195, 48);
            this.tb_CN.Name = "tb_CN";
            this.tb_CN.Size = new System.Drawing.Size(386, 20);
            this.tb_CN.TabIndex = 4;
            // 
            // tb_IB
            // 
            this.tb_IB.Location = new System.Drawing.Point(195, 99);
            this.tb_IB.Name = "tb_IB";
            this.tb_IB.Size = new System.Drawing.Size(386, 20);
            this.tb_IB.TabIndex = 5;
            // 
            // tb_Date
            // 
            this.tb_Date.Location = new System.Drawing.Point(195, 150);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(386, 20);
            this.tb_Date.TabIndex = 6;
            // 
            // ACI_addButton
            // 
            this.ACI_addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACI_addButton.Location = new System.Drawing.Point(587, 264);
            this.ACI_addButton.Name = "ACI_addButton";
            this.ACI_addButton.Size = new System.Drawing.Size(89, 32);
            this.ACI_addButton.TabIndex = 9;
            this.ACI_addButton.Text = "&add";
            this.ACI_addButton.UseVisualStyleBackColor = true;
            this.ACI_addButton.Click += new System.EventHandler(this.ACI_addButton_Click);
            // 
            // ACI_deleteButton
            // 
            this.ACI_deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACI_deleteButton.Location = new System.Drawing.Point(34, 264);
            this.ACI_deleteButton.Name = "ACI_deleteButton";
            this.ACI_deleteButton.Size = new System.Drawing.Size(89, 32);
            this.ACI_deleteButton.TabIndex = 10;
            this.ACI_deleteButton.Text = "Clear";
            this.ACI_deleteButton.UseVisualStyleBackColor = true;
            this.ACI_deleteButton.Click += new System.EventHandler(this.ACI_deleteButton_Click);
            // 
            // ACI_cancelButton
            // 
            this.ACI_cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACI_cancelButton.Location = new System.Drawing.Point(492, 264);
            this.ACI_cancelButton.Name = "ACI_cancelButton";
            this.ACI_cancelButton.Size = new System.Drawing.Size(89, 32);
            this.ACI_cancelButton.TabIndex = 11;
            this.ACI_cancelButton.Text = "cancel";
            this.ACI_cancelButton.UseVisualStyleBackColor = true;
            this.ACI_cancelButton.Click += new System.EventHandler(this.ACI_cancelButton_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 311);
            this.Controls.Add(this.ACI_cancelButton);
            this.Controls.Add(this.ACI_deleteButton);
            this.Controls.Add(this.ACI_addButton);
            this.Controls.Add(this.tb_Date);
            this.Controls.Add(this.tb_IB);
            this.Controls.Add(this.tb_CN);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_IB);
            this.Controls.Add(this.lbl_CN);
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer Info";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CN;
        private System.Windows.Forms.Label lbl_IB;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_CN;
        private System.Windows.Forms.TextBox tb_IB;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.Button ACI_addButton;
        private System.Windows.Forms.Button ACI_deleteButton;
        private System.Windows.Forms.Button ACI_cancelButton;
    }
}