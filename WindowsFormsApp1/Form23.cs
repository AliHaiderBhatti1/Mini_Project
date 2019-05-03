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
    public partial class Form23 : Form
    {
        public int pid;
        public SqlConnection conn;
        public SqlDataAdapter adapt;
        public int adid;

        public Form23()
        {
            InitializeComponent();
        }
        public Form23(int ID)
        {
            pid = ID;
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            DataTable dt = new DataTable();
            String abc = String.Format("SELECT * FROM [Advisor] WHERE Advisor.Id NOT IN (SELECT AdvisorId FROM ProjectAdvisor WHERE ProjectAdvisor.ProjectId = {0})", pid);
            adapt = new SqlDataAdapter(abc, conn);
            adapt.Fill(dt);
            addadvisorgrid.DataSource = dt;

        }

        private void Form23_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            String cmd = "INSERT INTO ProjectAdvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES (@adid, @prid, @arole, @asgnDate)";
            SqlCommand AddCommand = new SqlCommand(cmd, conn);
            AddCommand.Parameters.Add(new SqlParameter("adid", adid));
            AddCommand.Parameters.Add(new SqlParameter("prid", pid));

            String cmd1 = String.Format("SELECT Id FROM Lookup WHERE Value = '{0}'", advrolecombobox.Text);
            SqlCommand getAdvisorRoleIdCommand = new SqlCommand(cmd1, conn);
            int AdvisorRoleId = (Int32)getAdvisorRoleIdCommand.ExecuteScalar();
            AddCommand.Parameters.Add(new SqlParameter("arole", AdvisorRoleId));

            AddCommand.Parameters.Add(new SqlParameter("asgnDate", DateTime.Today));

            int count = AddCommand.ExecuteNonQuery();

            Form23 form = new Form23(pid);
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addadvisorgrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            adid = Convert.ToInt32(addadvisorgrid.Rows[e.RowIndex].Cells[0].Value.ToString());

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
            this.Hide();
        }
    }
}
