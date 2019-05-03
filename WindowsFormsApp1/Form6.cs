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
    public partial class Form6 : Form
    
    {

        int ID;

        public Form6()
        
        {
            InitializeComponent();
            String conURL = "Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * from (Person join Advisor on Person.Id = Advisor.Id) join Lookup on Gender = Lookup.Id", conn);
                adapt.Fill(dt);
                dataGridView2.DataSource = dt;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
            String Desigcmd = String.Format("SELECT Id FROM Lookup WHERE Value = '{0}'", comboBox1.Text);
            SqlCommand descmd = new SqlCommand(Desigcmd, conn);
            int des_id = (Int32)descmd.ExecuteScalar();

            String idcmd = "SELECT MAX(Id) from Person";
            SqlCommand idcommand = new SqlCommand(idcmd, conn);
            int pid = (Int32)idcommand.ExecuteScalar();
            String studentcmd = "UPDATE Advisor SET Salary =  @sal, Designation = @des where Id = @iid";
            SqlCommand studentcommand = new SqlCommand(studentcmd, conn);

            studentcommand.Parameters.Add(new SqlParameter("sal", textBox3.Text));
            studentcommand.Parameters.Add(new SqlParameter("des", des_id));
            studentcommand.Parameters.Add(new SqlParameter("iid",ID));
            count = studentcommand.ExecuteNonQuery();
            this.Hide();
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
            genderComboBox.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();

            comboBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
