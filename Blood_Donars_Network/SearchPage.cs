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
    public partial class SearchPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0KRJNN2;Initial Catalog=" + "blood donars network" + ";Integrated Security=True");
        public SearchPage()
        {
            InitializeComponent();
            selectBloodGroup.Checked=false;
            bloodBank.Checked = false;
            checkArea.Checked = false;
            label1.Hide();
            textBox1.Hide();

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void selectBloodGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (selectBloodGroup.Checked == true)
            {
                bloodBank.Checked = false;
                checkArea.Checked = false;
                label1.Text = "Blood Group";
                label1.Show();
                textBox1.Show();
                textBox1.Text = "";
            }
            if(selectBloodGroup.Checked==false && checkArea.Checked==false && bloodBank.Checked== false)
            {
                textBox1.Text = "";
                label1.Hide();
                textBox1.Hide();
            }
        }

        private void checkArea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkArea.Checked == true)
            {
                selectBloodGroup.Checked = false;
                bloodBank.Checked = false;
                label1.Text = "Area";
                label1.Show();
                textBox1.Text = "";
                textBox1.Show();
            }
            if (selectBloodGroup.Checked == false && checkArea.Checked == false && bloodBank.Checked == false)
            {
                textBox1.Text = "";
                label1.Hide();
                textBox1.Hide();
            }
        }

        private void bloodBank_CheckedChanged(object sender, EventArgs e)
        {
            if (bloodBank.Checked == true)
            {
                selectBloodGroup.Checked = false;
                checkArea.Checked = false;
                textBox1.Text = "";
                label1.Hide();
                textBox1.Hide();
            }
            if (selectBloodGroup.Checked == false && checkArea.Checked == false && bloodBank.Checked == false)
            {
                label1.Hide();
                textBox1.Hide();
                textBox1.Text = "";
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (selectBloodGroup.Checked == false && checkArea.Checked == false && bloodBank.Checked == false)
            {
                MessageBox.Show("Please Select an Area of search.");
            }
            else if(checkArea.Checked == true)
            {
                if(textBox1.Text == "")
                {
                    MessageBox.Show("Please Specify a location.");
                }
                else
                {
                    cmd.CommandText = "select donar.donar_Name, donar.donar_email, donar.blood_Group_of_donar,donar.contact_Number_of_donar, donar.last_date_of_blood_donation from donar where donar.donar_Address = '" + textBox1.Text.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sa = new SqlDataAdapter(cmd);
                    sa.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

            }
            else if(selectBloodGroup.Checked == true)
            {
                if(textBox1.Text == "")
                {
                    MessageBox.Show("Please Specify a blood group.");
                }
                else
                {
                    cmd.CommandText = "select donar.donar_Name, donar.donar_email, donar.blood_Group_of_donar,donar.contact_Number_of_donar, donar.last_date_of_blood_donation from donar where donar.blood_Group_of_donar = '"+textBox1.Text.ToString()+"'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sa = new SqlDataAdapter(cmd);
                    sa.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (bloodBank.Checked == true)
            {
                cmd.CommandText = "select  * from blood_banks";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            con.Close();
        }
    }
}
