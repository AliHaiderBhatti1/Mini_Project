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
    public partial class Form18 : Form
    {
        public SqlConnection conn;
        public SqlDataAdapter adapt;
        public int gid;
        public int count;
        public int pid;

        public Form18()
        {
            InitializeComponent();
        }
        public Form18(int ID)
        {
            InitializeComponent();
            gid = ID;
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
                conn.Open();
                DataTable dt = new DataTable();
                String abc = String.Format("SELECT * FROM [PROJECT] WHERE Project.Id NOT IN (SELECT GroupProject.ProjectId FROM GroupProject WHERE GroupProject.GroupId = {0})", gid);
                adapt = new SqlDataAdapter(abc, conn);
                adapt.Fill(dt);
                addprojectgrid.DataSource = dt;

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

        private void addbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();


            String cmd = "INSERT INTO GroupProject (ProjectId, GroupId, AssignmentDate) VALUES (@prid, @gid, @asgnDate)";
            SqlCommand AddCommand = new SqlCommand(cmd, conn);
            AddCommand.Parameters.Add(new SqlParameter("prid", pid));
            AddCommand.Parameters.Add(new SqlParameter("gid", gid));
            AddCommand.Parameters.Add(new SqlParameter("asgnDate", DateTime.Today));


            count = AddCommand.ExecuteNonQuery();
            Form18 form = new Form18(gid);
            form.Show();
            this.Hide();
        }

        private void addprojectgrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pid = Convert.ToInt32(addprojectgrid.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
