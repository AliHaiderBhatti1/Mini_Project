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
    public partial class Form16 : Form
    {
        public SqlConnection conn;
        public SqlDataAdapter adapt;
        public int ID;

        public Form16()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * from [Group]", conn);
            adapt.Fill(dt);
            groupgridview.DataSource = dt;
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            if (ID != 0)
            {
                SqlCommand cmd;
                cmd = new SqlCommand("DELETE FROM GroupStudent WHERE GroupStudent.GroupId = @id", conn);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                conn.Close();

                SqlCommand cmd1;
                cmd1 = new SqlCommand("DELETE FROM GroupEvaluation WHERE GroupEvaluation.GroupId = @id", conn);
                conn.Open();
                cmd1.Parameters.AddWithValue("@id", ID);
                cmd1.ExecuteNonQuery();
                conn.Close();

                SqlCommand cmd2;
                cmd2 = new SqlCommand("DELETE FROM GroupProject WHERE GroupProject.GroupId = @id", conn);
                conn.Open();
                cmd2.Parameters.AddWithValue("@id", ID);
                cmd2.ExecuteNonQuery();
                conn.Close();

                SqlCommand cmd3;
                cmd3 = new SqlCommand("DELETE FROM [Group] WHERE [Group].Id = @id", conn);
                conn.Open();
                cmd3.Parameters.AddWithValue("@id", ID);
                cmd3.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");
                groupgridview.Rows.RemoveAt(groupgridview.SelectedRows[0].Index);

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void groupgridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(groupgridview.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void addstbtn_Click(object sender, EventArgs e)
        {
            
            Form17 form = new Form17(ID);
            form.Show();
            this.Hide();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void addprobtn_Click(object sender, EventArgs e)
        {
            Form18 form = new Form18(ID);
            form.Show();
            this.Hide();
        }

        private void addevabtn_Click(object sender, EventArgs e)
        {
            Form22 form = new Form22(ID);
            form.Show();
            this.Hide();
        }

        private void viewstbtn_Click(object sender, EventArgs e)
        {
            Form20 form = new Form20(ID);
            form.Show();
            this.Hide();
        }

        private void viewprobtn_Click(object sender, EventArgs e)
        {
            Form21 form = new Form21(ID);
            form.Show();
            this.Hide();
        }

        private void viewevabtn_Click(object sender, EventArgs e)
        {
            Form22 form = new Form22(ID);
            form.Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            form.Show();
            this.Hide();
        }
    }
}
