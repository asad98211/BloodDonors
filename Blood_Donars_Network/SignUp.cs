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
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0KRJNN2;Initial Catalog=" + "blood donars network" + ";Integrated Security=True");
        public SignUp()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void D_submit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(distinct donar.donar_email) from donar where donar.donar_email='" + D_Email.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Error: Email already Exists.");
            }
            else if(string.IsNullOrWhiteSpace(D_Name.Text)|| string.IsNullOrWhiteSpace(D_Id.Text) || string.IsNullOrWhiteSpace(D_Password.Text) || string.IsNullOrWhiteSpace(D_Address.Text) || string.IsNullOrWhiteSpace(D_Bloodgroup.Text)|| string.IsNullOrWhiteSpace(D_Email.Text))
            {
                MessageBox.Show("Error: fill the blank boxes.");
            }
            else
            {
                int contact, nid;
                if (int.TryParse(D_Contact.Text,out contact)&& int.TryParse(D_Nid.Text,out nid))
                {
                    //MessageBox.Show(Donation_date.Value.Date.ToString("yyyy-MM-dd"));
                    if (Never_Donated.Checked)
                    {

                        cmd.CommandText = "insert into donar (donar_Name, donar_id, donar_Password, donar_email, donar_national_id, donar_Address,contact_Number_of_donar, blood_Group_of_donar) values('"+ D_Name.Text + "', '" + D_Id.Text + "', '"+D_Password.Text+"', '"+D_Email.Text+"', '"+D_Nid.Text+"', '"+D_Address.Text+"', "+D_Contact.Text+", '"+D_Bloodgroup.Text+"'); ";
                    }
                    else
                    {
                        cmd.CommandText = "insert into donar values('" + D_Name.Text + "','" + D_Id.Text + "','" + D_Password.Text + "','" + D_Email.Text + "','" + D_Nid.Text + "','" + D_Address.Text + "'," + D_Contact.Text + ",'" + D_Bloodgroup.Text + "','" + Donation_date.Value.Date.ToString("yyyy-MM-dd") + "');";
                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User_ID is created successfully.");
                    con.Close();
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Error: N_ID and Contact Must Be Ineger.");
                }

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Never_Donated_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
