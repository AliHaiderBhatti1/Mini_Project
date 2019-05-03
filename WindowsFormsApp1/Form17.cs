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
    public partial class Form17 : Form
    {
        public SqlConnection conn;
        public SqlDataAdapter adapt;
        public int gid;
        public int sid;
        public int count;
        public Form17()
        {
            InitializeComponent();
        }
        public Form17(int ID)
        {
            InitializeComponent();
            gid = ID;
            conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            DataTable dt = new DataTable();
            String abc = String.Format("SELECT * FROM [Student] WHERE Student.Id NOT IN (SELECT GroupStudent.StudentId FROM GroupStudent WHERE GroupStudent.GroupId = {0})", gid);
            adapt = new SqlDataAdapter(abc, conn);
            adapt.Fill(dt);
            addstudentgrid.DataSource = dt;
        }
        

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form16 form = new Form16();
            form.Show();
            this.Hide();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addstudentgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            String cmd1 = "UPDATE GroupStudent SET Status = @status WHERE GroupStudent.StudentId = @sid";
            SqlCommand UpdateCommand = new SqlCommand(cmd1, conn);
            UpdateCommand.Parameters.Add(new SqlParameter("status", 4));
            UpdateCommand.Parameters.Add(new SqlParameter("sid", sid));
            count = UpdateCommand.ExecuteNonQuery();

            String AddCMD = "INSERT INTO GroupStudent (GroupId, StudentId, Status, AssignmentDate) VALUES (@gid, @sid, @status, @asgnDate)";
            SqlCommand AddCommand = new SqlCommand(AddCMD, conn);

            AddCommand.Parameters.Add(new SqlParameter("status", 3));
            AddCommand.Parameters.Add(new SqlParameter("sid", sid));
            AddCommand.Parameters.Add(new SqlParameter("gid", gid));
            AddCommand.Parameters.Add(new SqlParameter("asgnDate", DateTime.Today));

            count = AddCommand.ExecuteNonQuery();
            Form17 form = new Form17(gid);
            form.Show();
            this.Hide();
        }

        private void addlabel_Click(object sender, EventArgs e)
        {

        }

        private void addstudentgrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sid = Convert.ToInt32(addstudentgrid.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
