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
using System.Windows.Forms.VisualStyles;
//written by Doreen Chirwa - 10.06.2023


namespace StudentInfo
{
    public partial class StudentInfoDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentInfo;Integrated Security=True");

        public StudentInfoDetails()
        {
            InitializeComponent();
        }

        private void StudentInfoDetails_Load(object sender, EventArgs e)
        {
            btnLogin_One.Visible = false;
            btnLogout.Visible = true;
        }

        private void btnLogin_One_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();        
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            StudentInfoDetails stu = new StudentInfoDetails();
            stu.Show();

            stu.pnlLogin.Visible = true;

            this.Hide();
        }

        public void display_data()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [StudentInfo]";
            cmd.ExecuteNonQuery();

            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGrid_DispRec.DataSource = dta;
            dataGrid_Display2.DataSource = dta;

            con.Close();
        }

    //CRUD Buttons to modify student records.
        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [StudentInfo] WHERE StudentID='" + txtStudentID.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                con.Close();
                MessageBox.Show("Student ID already exists");
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [StudentInfo] (StudentID, FirstName, LastName, Major, GPA) VALUES ('" + txtStudentID.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtMajor.Text + "','" + txtGpa.Text + "')";

                cmd.ExecuteNonQuery();
                con.Close();

                txtStudentID.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtMajor.Text = "";
                txtGpa.Text = "";

                display_data();

                MessageBox.Show("Data inserted successfully!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " UPDATE [StudentInfo] SET FirstName='" + txtFirstName.Text + "', LastName='" + txtLastName.Text + "', Major='"
                                + txtMajor.Text + "', GPA= '" + txtGpa.Text + "' WHERE StudentID='" + txtStudentID.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();
            display_data();

            txtStudentID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMajor.Text = "";
            txtGpa.Text = "";

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = true;

            txtStudentID.Enabled = true;

            MessageBox.Show("Data updated successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String msgConfirm = "Are you sure want to delete this record?";
            String cap = "Warning";

            MessageBoxButtons msgBtn = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            DialogResult rslt = MessageBox.Show(msgConfirm, cap, msgBtn, icon);

            if (rslt == DialogResult.Yes)
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " DELETE FROM [StudentInfo] WHERE StudentID='" + txtStudentID.Text + "'";

                cmd.ExecuteNonQuery();
                con.Close();
                display_data();

                txtStudentID.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtMajor.Text = "";
                txtGpa.Text = "";

                btnInsert.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                txtStudentID.Enabled = true;

                MessageBox.Show("Data deleted successfully!");
            }
            else if(rslt == DialogResult.No)
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();

            String search = txtSearch.Text;
            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [StudentInfo] WHERE FirstName Like '%" + search + "%' OR LastName Like '%" + search + "%' OR Major Like '%" + search + "%'", con);

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGrid_DispRec.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("No record found. Please try again.");
                con.Close();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display_data();
        }

    //Data Grid to Display Records.
        private void dataGrid_DispRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myindex = e.RowIndex;
            DataGridViewRow row = dataGrid_DispRec.Rows[myindex];

            String reg = row.Cells[0].Value.ToString();
            String value1 = row.Cells[0].Value.ToString();
            String value2 = row.Cells[0].Value.ToString();
            String value3 = row.Cells[0].Value.ToString();
            String value4 = row.Cells[0].Value.ToString();

            txtStudentID.Text = reg;
            txtStudentID.Enabled = false;

            txtFirstName.Text = value1;
            txtLastName.Text = value2;
            txtMajor.Text = value3;
            txtGpa.Text = value4;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

    //Panel 1 Details
    //This panel is to house the login button and allows anyone to view student records. However, you
    //cannot modify any of the student records until you have signed in.

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }

        private void btnDisplay2_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void dataGrid_Display2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int myindex = e.RowIndex;
            DataGridViewRow row = dataGrid_Display2.Rows[myindex];

            String reg = row.Cells[0].Value.ToString();
            String value1 = row.Cells[0].Value.ToString();
            String value2 = row.Cells[0].Value.ToString();
            String value3 = row.Cells[0].Value.ToString();
            String value4 = row.Cells[0].Value.ToString();

            txtStudentID.Text = reg;
            txtStudentID.Enabled = false;

            txtFirstName.Text = value1;
            txtLastName.Text = value2;
            txtMajor.Text = value3;
            txtGpa.Text = value4;
        }

        private void btnSearch2_Click_1(object sender, EventArgs e)
        {
            con.Open();

            String search = txtSearch2.Text;
            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [StudentInfo] WHERE FirstName Like '%" + search + "%' OR LastName Like '%" + search + "%' OR Major Like '%" + search + "%'", con);

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGrid_Display2.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("No record found. Please try again.");
                con.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
