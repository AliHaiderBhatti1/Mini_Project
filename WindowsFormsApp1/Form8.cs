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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            String conURL = "Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String conURL = "Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String cmd = "INSERT INTO Project(Description , Title) VALUES (@des , @tit)";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("des", Deslabel.Text));
            command.Parameters.Add(new SqlParameter("tit", titlabel.Text));
            int count = command.ExecuteNonQuery();
            this.Hide();
        }

        private void backlabel_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }
    }

}
