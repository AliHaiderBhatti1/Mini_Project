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
    public partial class Form10 : Form
    {
        int ID;
        public Form10()
        {
            InitializeComponent();
        }

        private void fetchlabel_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * from Project", conn);
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
            String cmd1 = "UPDATE Project SET Description = @des , Title = @tit WHERE Id = @id";
            SqlCommand command = new SqlCommand(cmd1, conn);
            command.Parameters.Add(new SqlParameter("des", Deslabel.Text));
            command.Parameters.Add(new SqlParameter("tit", titlabel.Text));
            command.Parameters.Add(new SqlParameter("id", ID));
            int count = command.ExecuteNonQuery();
            this.Hide();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Deslabel.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            titlabel.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
