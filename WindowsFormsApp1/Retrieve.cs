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
    
    public partial class Retrieve : Form
    {
      
        public string  v = "select * from Person join Student on Person.Id = Student.Id";
        public SqlConnection conn;
        public SqlDataAdapter adapt;
        public object fname;
        public int selectedRow;
        public int SelectedRows;
        public object fnameBox;
        int ID;



        // public object Retrieve { get; private set; }

        public Retrieve()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Retrieve_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
                conn.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT * from Person join Student on Person.Id = Student.Id", conn);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            if (ID != 0)
            {
                SqlCommand cmd;

                cmd = new SqlCommand("delete from GroupStudent where GroupStudent.StudentId=@id", conn);

                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("delete from Student where Id=@id", conn);
             
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("delete from Person where Id=@id", conn);

                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Successfully!");
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }

        private void Editlabel_Click(object sender, EventArgs e)

        {
            Form3 f = new Form3();
            f.Show();



        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
    }

