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
    public partial class SubjectControl : Form
    {
        int userID;
        public SubjectControl(int userID)
        {
            InitializeComponent();
            LoadSubjects();
            this.userID = userID;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAB109PC16\SQLEXPRESS; Initial Catalog=MajorProjectEES; Integrated Security=True;";
            string query = @"
        INSERT INTO Classes (SubjectID, TeacherID, ClassTime, RoomNumber)
        VALUES (@SubjectID, @TeacherID, @ClassTime, @RoomNumber)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@SubjectID", Convert.ToInt32(subjectscombo.SelectedValue));
                    sqlCommand.Parameters.AddWithValue("@TeacherID", userID); 
                    sqlCommand.Parameters.AddWithValue("@ClassTime", classtime.Text);
                    sqlCommand.Parameters.AddWithValue("@RoomNumber", roomnumber.Text);

                    sqlConnection.Open();
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Class added successfully!");
                    else
                        MessageBox.Show("Failed to add class.");
                }
            }
        }

        private void LoadSubjects()
        {
            string connectionString = @"Data Source=LAB109PC16\SQLEXPRESS; Initial Catalog=MajorProjectEES; Integrated Security=True;";
            string query = "SELECT SubjectID, SubjectName FROM Subjects";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                subjectscombo.DisplayMember = "SubjectName";
                subjectscombo.ValueMember = "SubjectID";
                subjectscombo.DataSource = dataTable;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            TeacherView teacherWindow = new TeacherView(userID);

            teacherWindow.Show();
            this.Hide();
        }
    }
}
