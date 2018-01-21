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
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void user_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sUp = new SignUp();
            sUp.ShowDialog();
            this.Show();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_Insert aInsPage = new admin_Insert();
            aInsPage.ShowDialog();
            this.Show();
        }
    }
}
