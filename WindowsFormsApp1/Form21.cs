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
    public partial class Form21 : Form
    {
        public SqlConnection conn;
        public SqlDataAdapter adapt;

        public Form21(int iD)
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
                conn.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT * from [GroupProject]", conn);
                adapt.Fill(dt);
                viewstudentgrid.DataSource = dt;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form16 form = new Form16();
            form.Show();
            this.Hide();
        }
    }
}
