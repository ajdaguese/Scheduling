namespace Scheduling
{
    partial class Form1
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
            this.btnAddAvailability = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnCreateSched = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAvailability
            // 
            this.btnAddAvailability.Location = new System.Drawing.Point(143, 93);
            this.btnAddAvailability.Name = "btnAddAvailability";
            this.btnAddAvailability.Size = new System.Drawing.Size(110, 23);
            this.btnAddAvailability.TabIndex = 0;
            this.btnAddAvailability.Text = "Add Availability";
            this.btnAddAvailability.UseVisualStyleBackColor = true;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(143, 12);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(110, 23);
            this.btnAddPerson.TabIndex = 1;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // btnCreateSched
            // 
            this.btnCreateSched.Location = new System.Drawing.Point(143, 183);
            this.btnCreateSched.Name = "btnCreateSched";
            this.btnCreateSched.Size = new System.Drawing.Size(110, 23);
            this.btnCreateSched.TabIndex = 2;
            this.btnCreateSched.Text = "Create Schedule";
            this.btnCreateSched.UseVisualStyleBackColor = true;
            this.btnCreateSched.Click += new System.EventHandler(this.btnCreateSched_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 405);
            this.Controls.Add(this.btnCreateSched);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnAddAvailability);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAvailability;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnCreateSched;
    }
}

