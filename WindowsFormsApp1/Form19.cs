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
    public partial class Form19 : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapt;
        public int gid;

        public Form19()
        {
            InitializeComponent();
            
        }
        public Form19(int ID)
        {
            InitializeComponent();
            gid = ID;
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
                conn.Open();
                DataTable dt = new DataTable();
                String abc = String.Format("SELECT * FROM [EVALUATION] WHERE Evaluation.Id NOT IN (SELECT GroupEvaluation.EvaluationId FROM GroupEvaluation WHERE GroupEvaluation.GroupId = {0})", gid);
                adapt = new SqlDataAdapter(abc, conn);
                adapt.Fill(dt);
                addevaluationgrid.DataSource = dt;

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

        private void addevaluationgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
