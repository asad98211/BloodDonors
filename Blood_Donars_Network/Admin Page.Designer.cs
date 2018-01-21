namespace Blood_Donars_Network
{
    partial class Admin_Page
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
            this.admin = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.logOff = new System.Windows.Forms.Button();
            this.bloodBank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(270, 59);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(75, 23);
            this.admin.TabIndex = 0;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(270, 106);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(75, 23);
            this.user.TabIndex = 1;
            this.user.Text = "User";
            this.user.UseVisualStyleBackColor = true;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // logOff
            // 
            this.logOff.Location = new System.Drawing.Point(270, 199);
            this.logOff.Name = "logOff";
            this.logOff.Size = new System.Drawing.Size(75, 23);
            this.logOff.TabIndex = 2;
            this.logOff.Text = "Log off";
            this.logOff.UseVisualStyleBackColor = true;
            this.logOff.Click += new System.EventHandler(this.logOff_Click);
            // 
            // bloodBank
            // 
            this.bloodBank.Location = new System.Drawing.Point(270, 149);
            this.bloodBank.Name = "bloodBank";
            this.bloodBank.Size = new System.Drawing.Size(75, 23);
            this.bloodBank.TabIndex = 3;
            this.bloodBank.Text = "Blood Bank";
            this.bloodBank.UseVisualStyleBackColor = true;
            this.bloodBank.Click += new System.EventHandler(this.bloodBank_Click);
            // 
            // Admin_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 298);
            this.Controls.Add(this.bloodBank);
            this.Controls.Add(this.logOff);
            this.Controls.Add(this.user);
            this.Controls.Add(this.admin);
            this.Name = "Admin_Page";
            this.Text = "Admin_Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Button logOff;
        private System.Windows.Forms.Button bloodBank;
    }
}