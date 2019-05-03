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
    public partial class Form14 : Form
        
    {
        int ID;
        public Form14()
        {
            InitializeComponent();
        }

        private void titlabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fetchlabel_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * from Evaluation", conn);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void updatelabel_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            String cmd1 = "UPDATE Evaluation SET Name = @name , TotalMarks = @mar, TotalWeightage = @wei WHERE Id = @id";
            SqlCommand command = new SqlCommand(cmd1, conn);
            command.Parameters.Add(new SqlParameter("name", namelabel.Text));
            command.Parameters.Add(new SqlParameter("mar", markslabel.Text));
            command.Parameters.Add(new SqlParameter("wei", weightagelabel.Text));
            command.Parameters.Add(new SqlParameter("id", ID));
            int count = command.ExecuteNonQuery();
            this.Hide();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            namelabel.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            markslabel.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            weightagelabel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
