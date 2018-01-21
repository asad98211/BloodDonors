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
    public partial class Update_Admin : Form
    {
        string adminId;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0KRJNN2;Initial Catalog=" + "blood donars network" + ";Integrated Security=True");
        public Update_Admin(string adminId)
        {
            this.adminId = adminId;

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from admin where admin.admin_id='" + adminId + "'";
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
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void Update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE admin SET admin_name = '" + Name.Text + "', admin_password = '" + Password.Text + "' WHERE admin_id = '" + Id.Text + "'; ";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully.");
            Cancel.Text = "Back";
            con.Close();
        }
    }
}
