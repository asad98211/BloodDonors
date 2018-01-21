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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0KRJNN2;Initial Catalog="+"blood donars network"+";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(distinct admin.admin_email) from admin where admin.admin_email='"+userName.Text+"' and admin.admin_Password='"+password.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            cmd.CommandText = "select count(distinct donar.donar_email) from donar where donar.donar_email='"+userName.Text+"' and donar.donar_password='"+password.Text+"'";
            cmd.ExecuteNonQuery();
            sa.Fill(dt1);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Admin_Page page = new Admin_Page();
                page.ShowDialog();
                password.Text = null;
                this.Show();
            }
            else if (dt1.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                main page = new main(2, userName.Text);
                page.ShowDialog();
                password.Text = null;
                this.Show();
            }
            else
            {
                MessageBox.Show("Email or Password incorrect");
            }
            con.Close();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signpage = new SignUp();
            signpage.ShowDialog();
            this.Show();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!ShowPassword.Checked)
            {
                password.UseSystemPasswordChar = true;
            }
            else
            {
                password.UseSystemPasswordChar = false;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (!ShowPassword.Checked)
            {
                password.UseSystemPasswordChar=true;
            }
            else
            {
                password.UseSystemPasswordChar = false;
            }

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
