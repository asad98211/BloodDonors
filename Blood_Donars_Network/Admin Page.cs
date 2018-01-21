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
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Table aTable = new Admin_Table();
            aTable.ShowDialog();
            this.Show();
        }

        private void logOff_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void user_Click(object sender, EventArgs e)
        {
            userTable page = new userTable();
            this.Hide();
            page.ShowDialog();
            this.Show();
        }

        private void bloodBank_Click(object sender, EventArgs e)
        {
            bloodBank page = new bloodBank();
            this.Hide();
            page.ShowDialog();
            this.Show();
        }
    }
}
