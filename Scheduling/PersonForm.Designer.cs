namespace Scheduling
{
    partial class PersonForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmergName = new System.Windows.Forms.Label();
            this.txtEmergName = new System.Windows.Forms.TextBox();
            this.lblEmergPhone = new System.Windows.Forms.Label();
            this.txtEmergPhone = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnAddress
            // 
            this.btnAddress.AutoSize = true;
            this.btnAddress.Location = new System.Drawing.Point(16, 99);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(48, 13);
            this.btnAddress.TabIndex = 2;
            this.btnAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(19, 139);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(19, 203);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(19, 239);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // lblEmergName
            // 
            this.lblEmergName.AutoSize = true;
            this.lblEmergName.Location = new System.Drawing.Point(19, 290);
            this.lblEmergName.Name = "lblEmergName";
            this.lblEmergName.Size = new System.Drawing.Size(134, 13);
            this.lblEmergName.TabIndex = 6;
            this.lblEmergName.Text = "Emergency Contact Name:";
            // 
            // txtEmergName
            // 
            this.txtEmergName.Location = new System.Drawing.Point(22, 335);
            this.txtEmergName.Name = "txtEmergName";
            this.txtEmergName.Size = new System.Drawing.Size(100, 20);
            this.txtEmergName.TabIndex = 7;
            // 
            // lblEmergPhone
            // 
            this.lblEmergPhone.AutoSize = true;
            this.lblEmergPhone.Location = new System.Drawing.Point(193, 13);
            this.lblEmergPhone.Name = "lblEmergPhone";
            this.lblEmergPhone.Size = new System.Drawing.Size(137, 13);
            this.lblEmergPhone.TabIndex = 8;
            this.lblEmergPhone.Text = "Emergency Contact Phone:";
            // 
            // txtEmergPhone
            // 
            this.txtEmergPhone.Location = new System.Drawing.Point(196, 45);
            this.txtEmergPhone.Name = "txtEmergPhone";
            this.txtEmergPhone.Size = new System.Drawing.Size(100, 20);
            this.txtEmergPhone.TabIndex = 9;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(196, 99);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender:";
            this.lblGender.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbGender
            // 
            this.cmbGender.AllowDrop = true;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbGender.Location = new System.Drawing.Point(196, 139);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 11;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtEmergPhone);
            this.Controls.Add(this.lblEmergPhone);
            this.Controls.Add(this.txtEmergName);
            this.Controls.Add(this.lblEmergName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "PersonForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label btnAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmergName;
        private System.Windows.Forms.TextBox txtEmergName;
        private System.Windows.Forms.Label lblEmergPhone;
        private System.Windows.Forms.TextBox txtEmergPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}