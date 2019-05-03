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
    public partial class Form3 : Form
    {
        int ID;
        public Form3()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            fnameBox.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            lnameBox.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            contactBox.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
            genderComboBox.Text = dataGridView2.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * from (Person join Student on Person.Id = Student.Id) join Lookup on Gender = Lookup.Id", conn);
                adapt.Fill(dt);
                dataGridView2.DataSource = dt;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            



            String gendercmd = String.Format("SELECT Id FROM Lookup WHERE Value = '{0}'", genderComboBox.Text);


            SqlCommand gcmd = new SqlCommand(gendercmd, conn);
            int g_id = (Int32)gcmd.ExecuteScalar();


            String cmd1 = "UPDATE Person SET FirstName = @fname, LastName = @lname, Contact= @contact, Email = @email, DateOfBirth = @dob , Gender = @gender WHERE Id = @id";
            SqlCommand command = new SqlCommand(cmd1, conn);
            command.Parameters.Add(new SqlParameter("fname", fnameBox.Text));
            command.Parameters.Add(new SqlParameter("lname", lnameBox.Text));
            command.Parameters.Add(new SqlParameter("contact", contactBox.Text));
            command.Parameters.Add(new SqlParameter("email", textBox5.Text));
            command.Parameters.Add(new SqlParameter("gender", g_id));

            command.Parameters.Add(new SqlParameter("dob", dateTimePicker1.Value));
            command.Parameters.Add(new SqlParameter("id", ID));

            int count = command.ExecuteNonQuery();
            String idcmd = "SELECT MAX(Id) from Person";
            SqlCommand idcommand = new SqlCommand(idcmd, conn);
            int pid = (Int32)idcommand.ExecuteScalar();
            String studentcmd = "UPDATE Student SET [RegistrationNo] = @regno where Id = @iid";
            SqlCommand studentcommand = new SqlCommand(studentcmd, conn);
        
            studentcommand.Parameters.Add(new SqlParameter("regno", textBox3.Text));
            studentcommand.Parameters.Add(new SqlParameter ("iid", ID));
            count = studentcommand.ExecuteNonQuery();
            this.Hide();

        }
    }
}

