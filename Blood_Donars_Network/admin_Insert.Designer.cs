namespace Blood_Donars_Network
{
    partial class admin_Insert
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
            this.Ad_name = new System.Windows.Forms.Label();
            this.Ad_ji = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.admin_name = new System.Windows.Forms.TextBox();
            this.admin_id = new System.Windows.Forms.TextBox();
            this.admin_pass = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ad_name
            // 
            this.Ad_name.AutoSize = true;
            this.Ad_name.Location = new System.Drawing.Point(184, 50);
            this.Ad_name.Name = "Ad_name";
            this.Ad_name.Size = new System.Drawing.Size(70, 13);
            this.Ad_name.TabIndex = 0;
            this.Ad_name.Text = "Admin_Name";
            // 
            // Ad_ji
            // 
            this.Ad_ji.AutoSize = true;
            this.Ad_ji.Location = new System.Drawing.Point(206, 94);
            this.Ad_ji.Name = "Ad_ji";
            this.Ad_ji.Size = new System.Drawing.Size(48, 13);
            this.Ad_ji.TabIndex = 1;
            this.Ad_ji.Text = "Admin Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Password";
            // 
            // admin_name
            // 
            this.admin_name.Location = new System.Drawing.Point(262, 50);
            this.admin_name.Name = "admin_name";
            this.admin_name.Size = new System.Drawing.Size(100, 20);
            this.admin_name.TabIndex = 3;
            // 
            // admin_id
            // 
            this.admin_id.Location = new System.Drawing.Point(262, 94);
            this.admin_id.Name = "admin_id";
            this.admin_id.Size = new System.Drawing.Size(100, 20);
            this.admin_id.TabIndex = 4;
            // 
            // admin_pass
            // 
            this.admin_pass.Location = new System.Drawing.Point(262, 138);
            this.admin_pass.Name = "admin_pass";
            this.admin_pass.Size = new System.Drawing.Size(100, 20);
            this.admin_pass.TabIndex = 5;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(287, 187);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(287, 237);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // admin_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 307);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add);
            this.Controls.Add(this.admin_pass);
            this.Controls.Add(this.admin_id);
            this.Controls.Add(this.admin_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ad_ji);
            this.Controls.Add(this.Ad_name);
            this.Name = "admin_Insert";
            this.Text = "admin_Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ad_name;
        private System.Windows.Forms.Label Ad_ji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox admin_name;
        private System.Windows.Forms.TextBox admin_id;
        private System.Windows.Forms.TextBox admin_pass;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button back;
    }
}