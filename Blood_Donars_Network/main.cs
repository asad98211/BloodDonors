using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Blood_Donars_Network
{
    public partial class main : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0KRJNN2;Initial Catalog="+"blood donars network"+";Integrated Security=True");
        int userLevel;
        string userName;
        public main(int number,string str)
        {
            this.userLevel = number;
            this.userName = str;
            InitializeComponent();
            if (userLevel == 2)
            {

                greetings.Text = "User Panel";
                insert.Hide();
                delete.Hide();
            }
            else
            {
                greetings.Text = "Admin Panel";
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }

        private void logOff_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            this.Hide();
            insert insPage = new insert();
            insPage.ShowDialog();
            this.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (userLevel == 2)
            {
                this.Hide();
                Update_Donar upDonar = new Update_Donar(userName);
                upDonar.ShowDialog();
                this.Show();
            }
            else
            {
                this.Hide();
                Update_Admin upAdmin = new Update_Admin(userName);
                upAdmin.ShowDialog();
                this.Show();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            SearchPage page = new SearchPage();
            this.Hide();
            page.ShowDialog();
            this.Show();
        }

        private void greetings_Click(object sender, EventArgs e)
        {

        }
    }
}
