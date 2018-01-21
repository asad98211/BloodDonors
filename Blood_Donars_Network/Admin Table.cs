using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donars_Network
{
    public partial class Admin_Table : Form
    {
        public Admin_Table()
        {
            InitializeComponent();
        }

        private void Admin_Table_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_donars_networkDataSet.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.blood_donars_networkDataSet.admin);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
