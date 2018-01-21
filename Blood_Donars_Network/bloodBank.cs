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
    public partial class bloodBank : Form
    {
        public bloodBank()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void bloodBank_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_donars_networkDataSet2.blood_banks' table. You can move, or remove it, as needed.
            this.blood_banksTableAdapter.Fill(this.blood_donars_networkDataSet2.blood_banks);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
