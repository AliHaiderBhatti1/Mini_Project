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
    public partial class Form9 : Form
    {
        public SqlConnection conn;
        public SqlDataAdapter adapt;
        int ID;

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
                conn.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT * from Project", conn);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            if (ID != 0)
            {
                SqlCommand cmd;
                SqlCommand cmd1;
                SqlCommand cmd0;

                cmd0 = new SqlCommand("Delete from ProjectAdvisor where ProjectAdvisor.ProjectId =@id", conn);
                cmd0.Parameters.AddWithValue("@id", ID);
                cmd0.ExecuteNonQuery();

                cmd = new SqlCommand("delete from GroupProject where ProjectId=@id", conn);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();

                cmd1 = new SqlCommand("delete from Project where Id=@id", conn);
                cmd1.Parameters.AddWithValue("@id", ID);
                cmd1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void Editlabel_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addprobtn_Click(object sender, EventArgs e)
        {
            Form23 form = new Form23(ID);
            form.Show();
            this.Hide();
        }

        private void viewprobtn_Click(object sender, EventArgs e)
        {
            Form23 form = new Form23(ID);
            form.Show();
            this.Hide();
        }
    }
}

