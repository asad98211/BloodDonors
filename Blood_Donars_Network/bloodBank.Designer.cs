namespace Blood_Donars_Network
{
    partial class bloodBank
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
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.blood_donars_networkDataSet2 = new Blood_Donars_Network.blood_donars_networkDataSet2();
            this.bloodbanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blood_banksTableAdapter = new Blood_Donars_Network.blood_donars_networkDataSet2TableAdapters.blood_banksTableAdapter();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressofbankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberofbankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offdaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_donars_networkDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodbanksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(346, 266);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankNameDataGridViewTextBoxColumn,
            this.addressofbankDataGridViewTextBoxColumn,
            this.contactNumberofbankDataGridViewTextBoxColumn,
            this.openingtimeDataGridViewTextBoxColumn,
            this.closetimeDataGridViewTextBoxColumn,
            this.offdaysDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bloodbanksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 226);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // blood_donars_networkDataSet2
            // 
            this.blood_donars_networkDataSet2.DataSetName = "blood_donars_networkDataSet2";
            this.blood_donars_networkDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bloodbanksBindingSource
            // 
            this.bloodbanksBindingSource.DataMember = "blood_banks";
            this.bloodbanksBindingSource.DataSource = this.blood_donars_networkDataSet2;
            // 
            // blood_banksTableAdapter
            // 
            this.blood_banksTableAdapter.ClearBeforeFill = true;
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            this.bankNameDataGridViewTextBoxColumn.DataPropertyName = "bank_Name";
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "bank_Name";
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            // 
            // addressofbankDataGridViewTextBoxColumn
            // 
            this.addressofbankDataGridViewTextBoxColumn.DataPropertyName = "address_of_bank";
            this.addressofbankDataGridViewTextBoxColumn.HeaderText = "address_of_bank";
            this.addressofbankDataGridViewTextBoxColumn.Name = "addressofbankDataGridViewTextBoxColumn";
            // 
            // contactNumberofbankDataGridViewTextBoxColumn
            // 
            this.contactNumberofbankDataGridViewTextBoxColumn.DataPropertyName = "contact_Number_of_bank";
            this.contactNumberofbankDataGridViewTextBoxColumn.HeaderText = "contact_Number_of_bank";
            this.contactNumberofbankDataGridViewTextBoxColumn.Name = "contactNumberofbankDataGridViewTextBoxColumn";
            // 
            // openingtimeDataGridViewTextBoxColumn
            // 
            this.openingtimeDataGridViewTextBoxColumn.DataPropertyName = "opening_time";
            this.openingtimeDataGridViewTextBoxColumn.HeaderText = "opening_time";
            this.openingtimeDataGridViewTextBoxColumn.Name = "openingtimeDataGridViewTextBoxColumn";
            // 
            // closetimeDataGridViewTextBoxColumn
            // 
            this.closetimeDataGridViewTextBoxColumn.DataPropertyName = "close_time";
            this.closetimeDataGridViewTextBoxColumn.HeaderText = "close_time";
            this.closetimeDataGridViewTextBoxColumn.Name = "closetimeDataGridViewTextBoxColumn";
            // 
            // offdaysDataGridViewTextBoxColumn
            // 
            this.offdaysDataGridViewTextBoxColumn.DataPropertyName = "off_days";
            this.offdaysDataGridViewTextBoxColumn.HeaderText = "off_days";
            this.offdaysDataGridViewTextBoxColumn.Name = "offdaysDataGridViewTextBoxColumn";
            // 
            // bloodBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 301);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Name = "bloodBank";
            this.Text = "bloodBank";
            this.Load += new System.EventHandler(this.bloodBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_donars_networkDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodbanksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private blood_donars_networkDataSet2 blood_donars_networkDataSet2;
        private System.Windows.Forms.BindingSource bloodbanksBindingSource;
        private blood_donars_networkDataSet2TableAdapters.blood_banksTableAdapter blood_banksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressofbankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberofbankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offdaysDataGridViewTextBoxColumn;
    }
}