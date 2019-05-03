using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            String conURL = "Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conURL);

            conn.Open();
            string cmd = "select * from Person where LastName = '{Lastname}'";
            SqlCommand command = new SqlCommand(cmd, conn);
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection Successful!!!");
            }
            else
            {
                MessageBox.Show("Connection failed!!");
            }
            Application.Run(new Form2());
           // Application.Run(new Student());
        }
    }
}
