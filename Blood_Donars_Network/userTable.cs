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
    public partial class userTable : Form
    {
        public userTable()
        {
            InitializeComponent();
        }

        private void userTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blood_donars_networkDataSet1.donar' table. You can move, or remove it, as needed.
            this.donarTableAdapter.Fill(this.blood_donars_networkDataSet1.donar);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
