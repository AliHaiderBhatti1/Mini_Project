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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            String conURL = "Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678";
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String cmd = "INSERT INTO Evaluation(Name , TotalMarks , TotalWeightage) VALUES (@name , @mar , @wei)";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.Add(new SqlParameter("name", namelabel.Text));
            command.Parameters.Add(new SqlParameter("mar", markslabel.Text));
            command.Parameters.Add(new SqlParameter("wei", weightagelabel.Text));
            int count = command.ExecuteNonQuery();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
            this.Hide();
        }
    }
}
