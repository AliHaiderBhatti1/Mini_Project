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

namespace WindowsFormsApp1
{
    public partial class Student : Form
    {
        

        public Student()
        {
            InitializeComponent();
            String conURL = "Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
           
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String conURL = "Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String gendercmd = String.Format("SELECT Id FROM Lookup WHERE Value = '{0}'", genderComboBox.Text);

          
            SqlCommand gcmd = new SqlCommand(gendercmd, conn);
            int g_id = (Int32)gcmd.ExecuteScalar();
            

            String cmd = "INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES (@fname, @lname, @contact, @email, @dob, @gender)";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("fname", fnameBox.Text));
            command.Parameters.Add(new SqlParameter("lname", lnameBox.Text));
            command.Parameters.Add(new SqlParameter("contact", contactBox.Text));
            command.Parameters.Add(new SqlParameter("email", textBox5.Text));
            command.Parameters.Add(new SqlParameter("gender", g_id));
            command.Parameters.Add(new SqlParameter("dob", dateTimePicker1.Value));

            int count = command.ExecuteNonQuery();
            String idcmd = "SELECT MAX(Id) from Person";
            SqlCommand idcommand = new SqlCommand(idcmd, conn);
            int pid = (Int32)idcommand.ExecuteScalar();
            String studentcmd = "INSERT INTO Student (Id, RegistrationNo) VALUES (@sid, @regno)";
            SqlCommand studentcommand = new SqlCommand(studentcmd, conn);
            studentcommand.Parameters.Add(new SqlParameter("sid", pid));
            studentcommand.Parameters.Add(new SqlParameter("regno", textBox3.Text));
            count = studentcommand.ExecuteNonQuery();
            this.Hide();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void contactBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void fnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
