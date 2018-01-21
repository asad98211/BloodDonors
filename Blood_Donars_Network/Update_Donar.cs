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

    public partial class Update_Donar : Form
    {
        string donarId;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0KRJNN2;Initial Catalog=" + "blood donars network" + ";Integrated Security=True");
        public Update_Donar(string donarId)
        {
            this.donarId = donarId;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from donar where donar.donar_email='" + donarId + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            con.Close();
            InitializeComponent();
            updateField(dt);
        }
        private void updateField(DataTable dt)
        {
            Name.Text = dt.Rows[0][0].ToString();
            Id.Text = dt.Rows[0][1].ToString();
            Password.Text = dt.Rows[0][2].ToString();
            Email.Text = dt.Rows[0][3].ToString();
            National_Id.Text = dt.Rows[0][4].ToString();
            Address.Text = dt.Rows[0][5].ToString();
            Contact_Number.Text = dt.Rows[0][6].ToString();
            Blood_Group.Text = dt.Rows[0][7].ToString();
            if (dt.Rows[0][8].ToString() == "NULL")
            {
                checkBox1.CheckState = CheckState.Checked;
            }
            else
            {
                checkBox1.Hide();
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0][8].ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE donar SET Donar_Name = '"+Name.Text+"', Blood_group_of_Donar = '"+Blood_Group.Text+"', Donar_password = '"+Password.Text+"', donar_email = '"+Email.Text+"', donar_address = '"+Address.Text+"', contact_number_of_donar = '"+Contact_Number.Text+"', last_date_of_blood_donation='"+dateTimePicker1.Value.Date.ToString("yyyy-MM-dd")+"' WHERE Donar_ID = '"+Id.Text+"'; ";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully.");
            Cancel.Text = "Back";
            con.Close();
        }
    }
}
