using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Stmanage_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void admanage_Click(object sender, EventArgs e)
        {
            Advisor form = new Advisor();
            form.Show();
        }

        private void promanage_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }

        private void evmanage_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
        }

        private void ManageGroupButton_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            form.Show();
            this.Hide();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Stmanage_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

        }

        private void admanage_Click_1(object sender, EventArgs e)
        {
            Advisor from = new Advisor();
            from.Show();
        }

        private void promanage_Click_1(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }

        private void evmanage_Click_1(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
        }

        private void ManageGroupButton_Click_1(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            form.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("C:/Users/ALI HAIDER BHATTI/source/repos/WindowsFormsApp1/c.pdf", FileMode.Create));
            document.Open();
            PdfPTable table = new PdfPTable(2);

            //actual width of table in points

            table.TotalWidth = 216f;

            //fix the absolute width of the table

            table.LockedWidth = true;



            //relative col widths in proportions - 1/3 and 2/3

            float[] widths = new float[] { 54f, 54f, 54f, 54f };

            //table.SetWidths(widths);

            table.HorizontalAlignment = 0;

            //leave a gap before and after the table

            table.SpacingBefore = 20f;

            table.SpacingAfter = 30f;



            PdfPCell cell = new PdfPCell(new Phrase("List of Projects"));

            cell.Colspan = 4;

            cell.Border = 0;

            cell.HorizontalAlignment = 1;

            table.AddCell(cell);

            string connect = "Data Source=DESKTOP-OLL88JR\\SQLEXPRESS;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=12345678";

            using (SqlConnection conn = new SqlConnection(connect))

            {

                string query = "SELECT Project.Id AS [Project Id], Project.Title, Student.RegistrationNo, ProjectAdvisor.AdvisorId  FROM ((((Project JOIN ProjectAdvisor ON Project.Id = ProjectAdvisor.ProjectId) JOIN GroupProject ON Project.Id = GroupProject.ProjectId) JOIN [Group] ON [Group].Id = GroupProject.GroupId) JOIN GroupStudent ON [Group].Id = GroupStudent.GroupId) JOIN Student ON Student.Id = GroupStudent.StudentId ORDER BY Project.Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                try

                {

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())

                    {

                        while (rdr.Read())

                        {

                            table.AddCell(rdr[0].ToString());

                            table.AddCell(rdr[1].ToString());

                        }

                    }

                }

                catch (Exception ex)

                {

                    //Response.Write(ex.Message);

                }

                document.Add(table);

            }
            
            document.Close();
        }
    }
}
