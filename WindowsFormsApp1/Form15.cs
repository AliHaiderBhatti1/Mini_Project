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
    public partial class Form15 : Form
    {
        public string conURL;

        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678");
            conn.Open();
            String AddGroupCMD = "INSERT INTO [Group] (Created_On) VALUES (@cdate)";
            SqlCommand AddGroupCommand = new SqlCommand(AddGroupCMD, conn);
            AddGroupCommand.Parameters.Add(new SqlParameter("cdate", DateTime.Today));
            int count = AddGroupCommand.ExecuteNonQuery();

            Form15 form = new Form15();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 form =new Form16();
            form.Show();
            this.Hide();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Show();
            this.Hide();
        }
    }
}
