namespace Blood_Donars_Network
{
    partial class userTable
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
            this.blood_donars_networkDataSet1 = new Blood_Donars_Network.blood_donars_networkDataSet1();
            this.donarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donarTableAdapter = new Blood_Donars_Network.blood_donars_networkDataSet1TableAdapters.donarTableAdapter();
            this.donarNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donaridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donarPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donaremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donarnationalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donarAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberofdonarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupofdonarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastdateofblooddonationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_donars_networkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donarNameDataGridViewTextBoxColumn,
            this.donaridDataGridViewTextBoxColumn,
            this.donarPasswordDataGridViewTextBoxColumn,
            this.donaremailDataGridViewTextBoxColumn,
            this.donarnationalidDataGridViewTextBoxColumn,
            this.donarAddressDataGridViewTextBoxColumn,
            this.contactNumberofdonarDataGridViewTextBoxColumn,
            this.bloodGroupofdonarDataGridViewTextBoxColumn,
            this.lastdateofblooddonationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.donarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // blood_donars_networkDataSet1
            // 
            this.blood_donars_networkDataSet1.DataSetName = "blood_donars_networkDataSet1";
            this.blood_donars_networkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donarBindingSource
            // 
            this.donarBindingSource.DataMember = "donar";
            this.donarBindingSource.DataSource = this.blood_donars_networkDataSet1;
            // 
            // donarTableAdapter
            // 
            this.donarTableAdapter.ClearBeforeFill = true;
            // 
            // donarNameDataGridViewTextBoxColumn
            // 
            this.donarNameDataGridViewTextBoxColumn.DataPropertyName = "donar_Name";
            this.donarNameDataGridViewTextBoxColumn.HeaderText = "donar_Name";
            this.donarNameDataGridViewTextBoxColumn.Name = "donarNameDataGridViewTextBoxColumn";
            // 
            // donaridDataGridViewTextBoxColumn
            // 
            this.donaridDataGridViewTextBoxColumn.DataPropertyName = "donar_id";
            this.donaridDataGridViewTextBoxColumn.HeaderText = "donar_id";
            this.donaridDataGridViewTextBoxColumn.Name = "donaridDataGridViewTextBoxColumn";
            // 
            // donarPasswordDataGridViewTextBoxColumn
            // 
            this.donarPasswordDataGridViewTextBoxColumn.DataPropertyName = "donar_Password";
            this.donarPasswordDataGridViewTextBoxColumn.HeaderText = "donar_Password";
            this.donarPasswordDataGridViewTextBoxColumn.Name = "donarPasswordDataGridViewTextBoxColumn";
            // 
            // donaremailDataGridViewTextBoxColumn
            // 
            this.donaremailDataGridViewTextBoxColumn.DataPropertyName = "donar_email";
            this.donaremailDataGridViewTextBoxColumn.HeaderText = "donar_email";
            this.donaremailDataGridViewTextBoxColumn.Name = "donaremailDataGridViewTextBoxColumn";
            // 
            // donarnationalidDataGridViewTextBoxColumn
            // 
            this.donarnationalidDataGridViewTextBoxColumn.DataPropertyName = "donar_national_id";
            this.donarnationalidDataGridViewTextBoxColumn.HeaderText = "donar_national_id";
            this.donarnationalidDataGridViewTextBoxColumn.Name = "donarnationalidDataGridViewTextBoxColumn";
            // 
            // donarAddressDataGridViewTextBoxColumn
            // 
            this.donarAddressDataGridViewTextBoxColumn.DataPropertyName = "donar_Address";
            this.donarAddressDataGridViewTextBoxColumn.HeaderText = "donar_Address";
            this.donarAddressDataGridViewTextBoxColumn.Name = "donarAddressDataGridViewTextBoxColumn";
            // 
            // contactNumberofdonarDataGridViewTextBoxColumn
            // 
            this.contactNumberofdonarDataGridViewTextBoxColumn.DataPropertyName = "contact_Number_of_donar";
            this.contactNumberofdonarDataGridViewTextBoxColumn.HeaderText = "contact_Number_of_donar";
            this.contactNumberofdonarDataGridViewTextBoxColumn.Name = "contactNumberofdonarDataGridViewTextBoxColumn";
            // 
            // bloodGroupofdonarDataGridViewTextBoxColumn
            // 
            this.bloodGroupofdonarDataGridViewTextBoxColumn.DataPropertyName = "blood_Group_of_donar";
            this.bloodGroupofdonarDataGridViewTextBoxColumn.HeaderText = "blood_Group_of_donar";
            this.bloodGroupofdonarDataGridViewTextBoxColumn.Name = "bloodGroupofdonarDataGridViewTextBoxColumn";
            // 
            // lastdateofblooddonationDataGridViewTextBoxColumn
            // 
            this.lastdateofblooddonationDataGridViewTextBoxColumn.DataPropertyName = "last_date_of_blood_donation";
            this.lastdateofblooddonationDataGridViewTextBoxColumn.HeaderText = "last_date_of_blood_donation";
            this.lastdateofblooddonationDataGridViewTextBoxColumn.Name = "lastdateofblooddonationDataGridViewTextBoxColumn";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(508, 296);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // userTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 346);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "userTable";
            this.Text = "userTable";
            this.Load += new System.EventHandler(this.userTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_donars_networkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private blood_donars_networkDataSet1 blood_donars_networkDataSet1;
        private System.Windows.Forms.BindingSource donarBindingSource;
        private blood_donars_networkDataSet1TableAdapters.donarTableAdapter donarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn donarNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donaridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donarPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donaremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donarnationalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donarAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberofdonarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupofdonarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastdateofblooddonationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backButton;
    }
}