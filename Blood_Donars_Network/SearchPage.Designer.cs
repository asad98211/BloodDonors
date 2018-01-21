namespace Blood_Donars_Network
{
    partial class SearchPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectBloodGroup = new System.Windows.Forms.CheckBox();
            this.checkArea = new System.Windows.Forms.CheckBox();
            this.bloodBank = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(465, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // selectBloodGroup
            // 
            this.selectBloodGroup.AutoSize = true;
            this.selectBloodGroup.Location = new System.Drawing.Point(86, 26);
            this.selectBloodGroup.Name = "selectBloodGroup";
            this.selectBloodGroup.Size = new System.Drawing.Size(85, 17);
            this.selectBloodGroup.TabIndex = 1;
            this.selectBloodGroup.Text = "Blood Group";
            this.selectBloodGroup.UseVisualStyleBackColor = true;
            this.selectBloodGroup.CheckedChanged += new System.EventHandler(this.selectBloodGroup_CheckedChanged);
            // 
            // checkArea
            // 
            this.checkArea.AutoSize = true;
            this.checkArea.Location = new System.Drawing.Point(177, 26);
            this.checkArea.Name = "checkArea";
            this.checkArea.Size = new System.Drawing.Size(48, 17);
            this.checkArea.TabIndex = 2;
            this.checkArea.Text = "Area";
            this.checkArea.UseVisualStyleBackColor = true;
            this.checkArea.CheckedChanged += new System.EventHandler(this.checkArea_CheckedChanged);
            // 
            // bloodBank
            // 
            this.bloodBank.AutoSize = true;
            this.bloodBank.Location = new System.Drawing.Point(231, 26);
            this.bloodBank.Name = "bloodBank";
            this.bloodBank.Size = new System.Drawing.Size(81, 17);
            this.bloodBank.TabIndex = 3;
            this.bloodBank.Text = "Blood Bank";
            this.bloodBank.UseVisualStyleBackColor = true;
            this.bloodBank.CheckedChanged += new System.EventHandler(this.bloodBank_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Blood Group";
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(351, 62);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 6;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(441, 62);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 378);
            this.Controls.Add(this.back);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bloodBank);
            this.Controls.Add(this.checkArea);
            this.Controls.Add(this.selectBloodGroup);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchPage";
            this.Text = "SearchPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox selectBloodGroup;
        private System.Windows.Forms.CheckBox checkArea;
        private System.Windows.Forms.CheckBox bloodBank;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button back;
    }
}