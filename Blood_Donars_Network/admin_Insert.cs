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
    public partial class admin_Insert : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0KRJNN2;Initial Catalog=" + "blood donars network" + ";Integrated Security=True");
        public admin_Insert()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(distinct admin.admin_id) from admin where admin.admin_id='" + admin_id.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Error: Admin_ID already Exists.");
            }
            else
            {
                cmd.CommandText = "insert into admin values('" + admin_name.Text + "','" + admin_id.Text + "','" + admin_pass.Text + "');";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admin_ID is created successfully.");
                con.Close();
                this.DialogResult = DialogResult.OK;
            }
            con.Close();
        }
    }
}
