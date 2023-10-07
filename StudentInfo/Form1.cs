using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//written by Doreen Chirwa - 10.06.2023


namespace StudentInfo
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
            txtUsername.ForeColor = Color.LightGray;
            txtPassword.ForeColor = Color.LightGray;
        }

    //Placeholder for Username and password textboxes...
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

    //Login Button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentInfo;Integrated Security=True");
            con.Open();
            SqlCommand sqcmd = new SqlCommand("SELECT * FROM Login WHERE Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(sqcmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {          
                this.Hide();
                StudentInfoDetails stu = new StudentInfoDetails();
                stu.Show();

                stu.pnlLogin.Visible = false;

            }
            else
            {
                MessageBox.Show("Invalid Username and/or Password. Please try again.");
            }

            con.Close();
        }
    }
}
