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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace MajorProjectEES
{
    public partial class StudentView : Form
    {
        private int userID;
        private string filters = "";
        private DataTable resultTable;
        private string connectionString = @"Data Source=LAB109PC16\SQLEXPRESS; Initial Catalog=MajorProjectEES; Integrated Security=True;";

        public StudentView(int userID)
        {
            InitializeComponent();
            this.userID = userID;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ORDINAL_POSITION,COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = Users", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable townsTable = new DataTable();

                
            }

            this.userID = userID;
        }
        private void columnsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filters += columnsComboBox.GetItemText(columnsComboBox.SelectedItem).Trim();
            columnsComboBox.Enabled = false;
            textBox1.Enabled = true;
        }
        private void StudentView_Load(object sender, EventArgs e)
        {
            LoadClasses();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from Users", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                resultTable = new DataTable();
                adapter.Fill(resultTable);
                dataGridView1.DataSource = resultTable;
            }

            

            string query = @"
                SELECT st.FirstName, st.LastName, s.SubjectName, t.FirstName + ' ' + t.LastName as TeacherName, c.ClassTime, c.RoomNumber
                FROM Students st
                LEFT JOIN Enrollments e ON st.StudentID = e.StudentID
                LEFT JOIN Classes c ON e.ClassID = c.ClassID
                LEFT JOIN Subjects s ON c.SubjectID = s.SubjectID
                LEFT JOIN Teachers t ON c.TeacherID = t.TeacherID
                WHERE st.StudentID = @StudentID";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StudentID", userID);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    string firstName = dataTable.Rows[0]["FirstName"].ToString();
                    string lastName = dataTable.Rows[0]["LastName"].ToString();
                    welcomeLabel.Text = $"Welcome {firstName} {lastName}";
                }
                else
                {
                    welcomeLabel.Text = "Student not found";
                }

                dataGridView1.DataSource = dataTable;
            }
        }


        private void refresh_button_Click(object sender, EventArgs e)
        {

            string query = @"
                SELECT st.FirstName, st.LastName, s.SubjectName, t.FirstName + ' ' + t.LastName as TeacherName, c.ClassTime, c.RoomNumber
                FROM Students st
                LEFT JOIN Enrollments e ON st.StudentID = e.StudentID
                LEFT JOIN Classes c ON e.ClassID = c.ClassID
                LEFT JOIN Subjects s ON c.SubjectID = s.SubjectID
                LEFT JOIN Teachers t ON c.TeacherID = t.TeacherID
                WHERE st.StudentID = @StudentID";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StudentID", userID);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    string firstName = dataTable.Rows[0]["FirstName"].ToString();
                    string lastName = dataTable.Rows[0]["LastName"].ToString();
                    welcomeLabel.Text = $"Welcome {firstName} {lastName}";
                }
                else
                {
                    welcomeLabel.Text = "Student not found";
                }

                dataGridView1.DataSource = dataTable;
            }
        }
        private void enroll_button_Click(object sender, EventArgs e)
        {

            int classID;
            
            if (classesComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a class.");
                return;
            }
            classID = Convert.ToInt32(classesComboBox.SelectedValue);

            string connectionString = @"Data Source=LAB109PC16\SQLEXPRESS; Initial Catalog=MajorProjectEES; Integrated Security=True;";
            string query = "INSERT INTO Enrollments (StudentID, ClassID) VALUES (@StudentID, @ClassID)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@StudentID", userID);
                    sqlCommand.Parameters.AddWithValue("@ClassID", classID);

                    sqlConnection.Open();
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Enrollment successful!");
                    else
                        MessageBox.Show("Enrollment failed.");
                }
            }

        }
        private void LoadClasses()
        {
            string connectionString = @"Data Source=LAB109PC16\SQLEXPRESS; Initial Catalog=MajorProjectEES; Integrated Security=True;";
            string query = "SELECT ClassID, SubjectName + ' - ' + ClassTime as ClassName FROM Classes JOIN Subjects ON Classes.SubjectID = Subjects.SubjectID";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                classesComboBox.DisplayMember = "ClassName";
                classesComboBox.ValueMember = "ClassID";
                classesComboBox.DataSource = dataTable;
            }
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            LogIn loginWindow = new LogIn();

            loginWindow.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            
            string text = String.Empty;
            string selectedItem = columnsComboBox.SelectedItem.ToString();
            string query = String.Empty;
            string inputText = textBox1.Text;

            
            if (selectedItem == "SubjectName")
            {
                query = @"
                SELECT st.FirstName, st.LastName, s.SubjectName, t.FirstName + ' ' + t.LastName as TeacherName, c.ClassTime, c.RoomNumber
                FROM Students st
                LEFT JOIN Enrollments e ON st.StudentID = e.StudentID
                LEFT JOIN Classes c ON e.ClassID = c.ClassID
                LEFT JOIN Subjects s ON c.SubjectID = s.SubjectID
                LEFT JOIN Teachers t ON c.TeacherID = t.TeacherID
                WHERE s.SubjectName = @Textt and st.StudentID = @StudentID";
            }
            else if (selectedItem == "TeacherName")
            {
                query = @"
                SELECT st.FirstName, st.LastName, s.SubjectName, t.FirstName + ' ' + t.LastName as TeacherName, c.ClassTime, c.RoomNumber
                FROM Students st
                LEFT JOIN Enrollments e ON st.StudentID = e.StudentID
                LEFT JOIN Classes c ON e.ClassID = c.ClassID
                LEFT JOIN Subjects s ON c.SubjectID = s.SubjectID
                LEFT JOIN Teachers t ON c.TeacherID = t.TeacherID
                WHERE t.FirstName + ' ' + t.LastName = @Textt and st.StudentID = @StudentID";
            }
            else if (selectedItem == "ClassTime")
            {
                query = @"
                SELECT st.FirstName, st.LastName, s.SubjectName, t.FirstName + ' ' + t.LastName as TeacherName, c.ClassTime, c.RoomNumber
                FROM Students st
                LEFT JOIN Enrollments e ON st.StudentID = e.StudentID
                LEFT JOIN Classes c ON e.ClassID = c.ClassID
                LEFT JOIN Subjects s ON c.SubjectID = s.SubjectID
                LEFT JOIN Teachers t ON c.TeacherID = t.TeacherID
                WHERE c.ClassTime = @Textt and st.StudentID = @StudentID";
            }
            else if (selectedItem == "RoomNumber")
            {
                query = @"
                SELECT st.FirstName, st.LastName, s.SubjectName, t.FirstName + ' ' + t.LastName as TeacherName, c.ClassTime, c.RoomNumber
                FROM Students st
                LEFT JOIN Enrollments e ON st.StudentID = e.StudentID
                LEFT JOIN Classes c ON e.ClassID = c.ClassID
                LEFT JOIN Subjects s ON c.SubjectID = s.SubjectID
                LEFT JOIN Teachers t ON c.TeacherID = t.TeacherID
                WHERE c.RoomNumber = @Textt and st.StudentID = @StudentID";
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }



            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Textt", inputText);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StudentID", userID);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    string firstName = dataTable.Rows[0]["FirstName"].ToString();
                    string lastName = dataTable.Rows[0]["LastName"].ToString();
                    welcomeLabel.Text = $"Welcome {firstName} {lastName}";
                }
                else
                {
                    welcomeLabel.Text = "Student not found";
                }

                dataGridView1.DataSource = dataTable;
            }

        }

        private void studentid_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            string query = @"
                SELECT st.FirstName, st.LastName, s.SubjectName, t.FirstName + ' ' + t.LastName as TeacherName, c.ClassTime, c.RoomNumber
                FROM Students st
                LEFT JOIN Enrollments e ON st.StudentID = e.StudentID
                LEFT JOIN Classes c ON e.ClassID = c.ClassID
                LEFT JOIN Subjects s ON c.SubjectID = s.SubjectID
                LEFT JOIN Teachers t ON c.TeacherID = t.TeacherID
                WHERE st.StudentID = @StudentID";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StudentID", userID);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    string firstName = dataTable.Rows[0]["FirstName"].ToString();
                    string lastName = dataTable.Rows[0]["LastName"].ToString();
                    welcomeLabel.Text = $"Welcome {firstName} {lastName}";
                }
                else
                {
                    welcomeLabel.Text = "Student not found";
                }

                dataGridView1.DataSource = dataTable;
            }
        }
    }
}