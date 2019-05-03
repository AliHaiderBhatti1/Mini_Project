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
    public partial class Form20 : Form
    {
        public SqlConnection conn;
        public SqlDataAdapter adapt;
        public int gid;
        public Form20(int iD)
        {
            InitializeComponent();
            gid = iD;
            conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            DataTable dt = new DataTable();
            String cmd = String.Format("SELECT * from [GroupStudent] WHERE GroupStudent.GroupId = {0}", gid);
            adapt = new SqlDataAdapter(cmd, conn);
            adapt.Fill(dt);
            viewstudentgrid.DataSource = dt;
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form16 form = new Form16();
            form.Show();
            this.Hide();
        }

        private void viewstudentgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
