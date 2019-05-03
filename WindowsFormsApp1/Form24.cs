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
    public partial class Form24 : Form
    {
        public SqlConnection conn;
        public SqlDataAdapter adapt;
        public int pid;
        public Form24(int ID)
        {
            InitializeComponent();
            pid = ID;
            conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            DataTable dt = new DataTable();
            String cmd = String.Format("SELECT * from [ProjectAdvisor] WHERE ProjectAdvisor.ProjectID = {0}", pid);
            adapt = new SqlDataAdapter(cmd, conn);
            adapt.Fill(dt);
            viewadvisorgrid.DataSource = dt;

        }

        private void Form24_Load(object sender, EventArgs e)
        {

        }
    }
}
