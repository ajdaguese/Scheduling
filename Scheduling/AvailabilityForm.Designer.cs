namespace Scheduling
{
    partial class AvailabilityForm
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
            this.lblPerson = new System.Windows.Forms.Label();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStartHour = new System.Windows.Forms.Label();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.lblStartMinue = new System.Windows.Forms.Label();
            this.cmbStartMinute = new System.Windows.Forms.ComboBox();
            this.cmbStartAP = new System.Windows.Forms.ComboBox();
            this.cmbEndAP = new System.Windows.Forms.ComboBox();
            this.cmbEndMinute = new System.Windows.Forms.ComboBox();
            this.lblEndMinute = new System.Windows.Forms.Label();
            this.cmbEndHour = new System.Windows.Forms.ComboBox();
            this.lblEndHour = new System.Windows.Forms.Label();
            this.lblTier = new System.Windows.Forms.Label();
            this.chkTier = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(13, 13);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(43, 13);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "Person:";
            // 
            // cmbPerson
            // 
            this.cmbPerson.AllowDrop = true;
            this.cmbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(16, 44);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(121, 21);
            this.cmbPerson.TabIndex = 1;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(16, 86);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(86, 13);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Start Time/Date:";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(19, 117);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 4;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(452, 117);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 5;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(452, 86);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(83, 13);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "End Time/Date:";
            // 
            // lblStartHour
            // 
            this.lblStartHour.AutoSize = true;
            this.lblStartHour.Location = new System.Drawing.Point(13, 156);
            this.lblStartHour.Name = "lblStartHour";
            this.lblStartHour.Size = new System.Drawing.Size(36, 13);
            this.lblStartHour.TabIndex = 7;
            this.lblStartHour.Text = "Hour: ";
            // 
            // cmbHour
            // 
            this.cmbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbHour.Location = new System.Drawing.Point(55, 153);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(38, 21);
            this.cmbHour.TabIndex = 8;
            // 
            // lblStartMinue
            // 
            this.lblStartMinue.AutoSize = true;
            this.lblStartMinue.Location = new System.Drawing.Point(112, 156);
            this.lblStartMinue.Name = "lblStartMinue";
            this.lblStartMinue.Size = new System.Drawing.Size(42, 13);
            this.lblStartMinue.TabIndex = 9;
            this.lblStartMinue.Text = "Minute:";
            this.lblStartMinue.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbStartMinute
            // 
            this.cmbStartMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartMinute.FormattingEnabled = true;
            this.cmbStartMinute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbStartMinute.Location = new System.Drawing.Point(161, 153);
            this.cmbStartMinute.Name = "cmbStartMinute";
            this.cmbStartMinute.Size = new System.Drawing.Size(39, 21);
            this.cmbStartMinute.TabIndex = 10;
            // 
            // cmbStartAP
            // 
            this.cmbStartAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartAP.FormattingEnabled = true;
            this.cmbStartAP.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbStartAP.Location = new System.Drawing.Point(221, 153);
            this.cmbStartAP.Name = "cmbStartAP";
            this.cmbStartAP.Size = new System.Drawing.Size(41, 21);
            this.cmbStartAP.TabIndex = 11;
            // 
            // cmbEndAP
            // 
            this.cmbEndAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndAP.FormattingEnabled = true;
            this.cmbEndAP.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbEndAP.Location = new System.Drawing.Point(657, 156);
            this.cmbEndAP.Name = "cmbEndAP";
            this.cmbEndAP.Size = new System.Drawing.Size(41, 21);
            this.cmbEndAP.TabIndex = 16;
            // 
            // cmbEndMinute
            // 
            this.cmbEndMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndMinute.FormattingEnabled = true;
            this.cmbEndMinute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbEndMinute.Location = new System.Drawing.Point(597, 156);
            this.cmbEndMinute.Name = "cmbEndMinute";
            this.cmbEndMinute.Size = new System.Drawing.Size(39, 21);
            this.cmbEndMinute.TabIndex = 15;
            // 
            // lblEndMinute
            // 
            this.lblEndMinute.AutoSize = true;
            this.lblEndMinute.Location = new System.Drawing.Point(548, 159);
            this.lblEndMinute.Name = "lblEndMinute";
            this.lblEndMinute.Size = new System.Drawing.Size(42, 13);
            this.lblEndMinute.TabIndex = 14;
            this.lblEndMinute.Text = "Minute:";
            // 
            // cmbEndHour
            // 
            this.cmbEndHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndHour.FormattingEnabled = true;
            this.cmbEndHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbEndHour.Location = new System.Drawing.Point(491, 156);
            this.cmbEndHour.Name = "cmbEndHour";
            this.cmbEndHour.Size = new System.Drawing.Size(38, 21);
            this.cmbEndHour.TabIndex = 13;
            // 
            // lblEndHour
            // 
            this.lblEndHour.AutoSize = true;
            this.lblEndHour.Location = new System.Drawing.Point(449, 159);
            this.lblEndHour.Name = "lblEndHour";
            this.lblEndHour.Size = new System.Drawing.Size(36, 13);
            this.lblEndHour.TabIndex = 12;
            this.lblEndHour.Text = "Hour: ";
            // 
            // lblTier
            // 
            this.lblTier.AutoSize = true;
            this.lblTier.Location = new System.Drawing.Point(16, 227);
            this.lblTier.Name = "lblTier";
            this.lblTier.Size = new System.Drawing.Size(93, 13);
            this.lblTier.TabIndex = 17;
            this.lblTier.Text = "Only If Necessary:";
            // 
            // chkTier
            // 
            this.chkTier.AutoSize = true;
            this.chkTier.Location = new System.Drawing.Point(115, 227);
            this.chkTier.Name = "chkTier";
            this.chkTier.Size = new System.Drawing.Size(15, 14);
            this.chkTier.TabIndex = 18;
            this.chkTier.UseVisualStyleBackColor = true;
            // 
            // AvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.chkTier);
            this.Controls.Add(this.lblTier);
            this.Controls.Add(this.cmbEndAP);
            this.Controls.Add(this.cmbEndMinute);
            this.Controls.Add(this.lblEndMinute);
            this.Controls.Add(this.cmbEndHour);
            this.Controls.Add(this.lblEndHour);
            this.Controls.Add(this.cmbStartAP);
            this.Controls.Add(this.cmbStartMinute);
            this.Controls.Add(this.lblStartMinue);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.lblStartHour);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.cmbPerson);
            this.Controls.Add(this.lblPerson);
            this.Name = "AvailabilityForm";
            this.Text = "AvailabilityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStartHour;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Label lblStartMinue;
        private System.Windows.Forms.ComboBox cmbStartMinute;
        private System.Windows.Forms.ComboBox cmbStartAP;
        private System.Windows.Forms.ComboBox cmbEndAP;
        private System.Windows.Forms.ComboBox cmbEndMinute;
        private System.Windows.Forms.Label lblEndMinute;
        private System.Windows.Forms.ComboBox cmbEndHour;
        private System.Windows.Forms.Label lblEndHour;
        private System.Windows.Forms.Label lblTier;
        private System.Windows.Forms.CheckBox chkTier;
    }
}