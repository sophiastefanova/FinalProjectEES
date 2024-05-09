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

namespace MajorProjectEES
{
    public partial class TeacherView : Form
    {
        private int userID;
        private string fName = string.Empty;
        private string lName = string.Empty;

        public TeacherView(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            
        }

        private void teacherid_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAB109PC16\SQLEXPRESS; Initial Catalog=MajorProjectEES; Integrated Security=True;";
            string query = @"
            SELECT t.FirstName, t.LastName, s.SubjectName, c.ClassTime, c.RoomNumber 
            FROM Teachers t
            LEFT JOIN Classes c ON t.TeacherID = c.TeacherID
            LEFT JOIN Subjects s ON c.SubjectID = s.SubjectID
            WHERE t.TeacherID = @TeacherID";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TeacherID", userID);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    fName = dataTable.Rows[0]["FirstName"].ToString();
                    lName = dataTable.Rows[0]["LastName"].ToString();
                    welcomeLabel.Text = $"Welcome {fName} {lName}";
                }
                else
                {
                    welcomeLabel.Text = "Teacher not found";
                }

                dataGridView1.DataSource = dataTable;
            }
        }


        private void add_class_button_Click(object sender, EventArgs e)
        {
           SubjectControl subjectWindow = new SubjectControl(userID);

            subjectWindow.Show();
            this.Hide();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            LogIn loginWindow = new LogIn();

            loginWindow.Show();
            this.Hide();
        }
        
    }
}
