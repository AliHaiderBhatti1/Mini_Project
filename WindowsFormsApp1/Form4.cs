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

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            String conURL = "Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String conURL = "Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String gendercmd = String.Format("SELECT Id FROM Lookup WHERE Value = '{0}'", comboBox2.Text);
            String Desigcmd = String.Format("SELECT Id FROM Lookup WHERE Value = '{0}'", comboBox1.Text);
           
            SqlCommand gcmd = new SqlCommand(gendercmd, conn);
            SqlCommand descmd = new SqlCommand(Desigcmd, conn);

            int g_id = (Int32)gcmd.ExecuteScalar();
            int des_id = (Int32)descmd.ExecuteScalar();

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
            String studentcmd = "INSERT INTO Advisor (Id, Salary, Designation) VALUES (@sid, @sal, @des)";
            SqlCommand studentcommand = new SqlCommand(studentcmd, conn);
            studentcommand.Parameters.Add(new SqlParameter("sid", pid));
            studentcommand.Parameters.Add(new SqlParameter("sal", textBox3.Text));
            studentcommand.Parameters.Add(new SqlParameter("des", des_id));
            count = studentcommand.ExecuteNonQuery();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Advisor form = new Advisor();
            this.Show();
            this.Hide();
        }
    }
}
