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
    public partial class Form22 : Form
    
    {
        public int gid;
        public Form22()
        {
            InitializeComponent();
        }
        public Form22(int ID)
        {
            InitializeComponent();
            gid = ID;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            String cmd = String.Format("SELECT * FROM [Evaluation] WHERE Evaluation.Id NOT IN (SELECT GroupEvaluation.EvaluationId FROM GroupEvaluation WHERE GroupEvaluation.GroupId = {0})", gid);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd, conn);
            adapt.Fill(dt);
            addevaluationgrid.DataSource = dt;
        }
        public int eid;

        DataTable dt = new DataTable();

        private void Form22_Load(object sender, EventArgs e)
        {

        }

        private void addevaluationgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void addevaluationgrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            eid = Convert.ToInt32(addevaluationgrid.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            String AddCMD = "INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES (@gid, @eid, @marks, @evalDate)";
            SqlCommand AddCommand = new SqlCommand(AddCMD, conn);

            AddCommand.Parameters.Add(new SqlParameter("status", 3));
            AddCommand.Parameters.Add(new SqlParameter("eid", eid));
            AddCommand.Parameters.Add(new SqlParameter("gid", gid));
            AddCommand.Parameters.Add(new SqlParameter("marks", Convert.ToInt32(marksbox.Text)));
            AddCommand.Parameters.Add(new SqlParameter("evalDate", DateTime.Today));

            int count = AddCommand.ExecuteNonQuery();

            Form22 form = new Form22(gid);
            form.Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form16 form = new Form16();
            form.Show();
            this.Hide();
        }
    }
}
