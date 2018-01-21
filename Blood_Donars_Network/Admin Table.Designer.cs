namespace Blood_Donars_Network
{
    partial class Admin_Table
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.blood_donars_networkDataSet4 = new Blood_Donars_Network.blood_donars_networkDataSet4();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blood_donars_networkDataSet = new Blood_Donars_Network.blood_donars_networkDataSet();
            this.adminTableAdapter = new Blood_Donars_Network.blood_donars_networkDataSetTableAdapters.adminTableAdapter();
            this.backButton = new System.Windows.Forms.Button();
            this.adminTableAdapter1 = new Blood_Donars_Network.blood_donars_networkDataSet4TableAdapters.adminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_donars_networkDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_donars_networkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminnameDataGridViewTextBoxColumn,
            this.admin_email,
            this.adminidDataGridViewTextBoxColumn,
            this.adminPasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adminnameDataGridViewTextBoxColumn
            // 
            this.adminnameDataGridViewTextBoxColumn.DataPropertyName = "admin_name";
            this.adminnameDataGridViewTextBoxColumn.HeaderText = "admin_name";
            this.adminnameDataGridViewTextBoxColumn.Name = "adminnameDataGridViewTextBoxColumn";
            // 
            // admin_email
            // 
            this.admin_email.DataPropertyName = "admin_email";
            this.admin_email.HeaderText = "admin_email";
            this.admin_email.Name = "admin_email";
            // 
            // adminidDataGridViewTextBoxColumn
            // 
            this.adminidDataGridViewTextBoxColumn.DataPropertyName = "admin_id";
            this.adminidDataGridViewTextBoxColumn.HeaderText = "admin_id";
            this.adminidDataGridViewTextBoxColumn.Name = "adminidDataGridViewTextBoxColumn";
            // 
            // adminPasswordDataGridViewTextBoxColumn
            // 
            this.adminPasswordDataGridViewTextBoxColumn.DataPropertyName = "admin_Password";
            this.adminPasswordDataGridViewTextBoxColumn.HeaderText = "admin_Password";
            this.adminPasswordDataGridViewTextBoxColumn.Name = "adminPasswordDataGridViewTextBoxColumn";
            // 
            // adminBindingSource1
            // 
            this.adminBindingSource1.DataMember = "admin";
            this.adminBindingSource1.DataSource = this.blood_donars_networkDataSet4;
            // 
            // blood_donars_networkDataSet4
            // 
            this.blood_donars_networkDataSet4.DataSetName = "blood_donars_networkDataSet4";
            this.blood_donars_networkDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this.blood_donars_networkDataSet;
            // 
            // blood_donars_networkDataSet
            // 
            this.blood_donars_networkDataSet.DataSetName = "blood_donars_networkDataSet";
            this.blood_donars_networkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(287, 266);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // adminTableAdapter1
            // 
            this.adminTableAdapter1.ClearBeforeFill = true;
            // 
            // Admin_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 301);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_Table";
            this.Text = "Admin_Table";
            this.Load += new System.EventHandler(this.Admin_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_donars_networkDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_donars_networkDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private blood_donars_networkDataSet blood_donars_networkDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private blood_donars_networkDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.Button backButton;
        private blood_donars_networkDataSet4 blood_donars_networkDataSet4;
        private System.Windows.Forms.BindingSource adminBindingSource1;
        private blood_donars_networkDataSet4TableAdapters.adminTableAdapter adminTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminPasswordDataGridViewTextBoxColumn;
    }
}