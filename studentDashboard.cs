using Microsoft.Data.SqlClient;

namespace TA_LD_Management_System
{
    public partial class studentDashboard : Form
    {
        private string connectionString = "Data Source=DESKTOP-591GTQC\\SQLEXPRESS;Initial Catalog=DB_Final_Project;Integrated Security=True;TrustServerCertificate=True";
        private string loggedInEmail; // Variable to store the logged-in student's email

        public studentDashboard(string email)
        {
            InitializeComponent();
            loggedInEmail = email; // Set the loggedInEmail variable to the provided email
        }
        public studentDashboard()
        {
            InitializeComponent();
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize variables
            string studentName = "";
            string studentID = "";
            string studentEmail = "";
            string courseName = "";
            string assignmentID = "";
            string date = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Email, Student_id FROM Student WHERE Email = @Email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", loggedInEmail);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            studentName = reader["Name"].ToString();
                            studentID = reader["Student_id"].ToString();
                            studentEmail = reader["Email"].ToString();
                        }

                        reader.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An SQL error occurred: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            // For Welcome section
            label_Welcome.Text = "Welcome " + studentName;
            label_StudentName.Text = studentName;

            // For Profile section
            label21.Text = studentID;
            label22.Text = studentEmail;

            // For Application Status
            label23.Text = "Pending";
            label14.Text = "Lab Demonstrator";
            label34.Text = "10-02-2024";

            // For Demo Schedule
            label26.Text = "10-02-24 10:00 AM";
            label27.Text = "Data Structures";
            label28.Text = "Dr. Ali Zaidi";
            label33.Text = "Zeeshan Ali";

            // Feedback section
            label10.Text = courseName + " - " + assignmentID;
            label15.Text = "Received on: " + date;
            label16.Text = "Assignment was good. Keep it up!";
            label17.Text = " -TA Zeeshan Ali";
        }




        private void label1_Click(object sender, EventArgs e)
        {
            // hide this form
            this.Hide();
            // edit profile button
            editProfile editProfile = new editProfile(loggedInEmail);
            editProfile.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {


        }

        private void label_StudentName_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // navigate to feedback section
            this.Hide();
            FeedbackSection feedbackSection = new FeedbackSection();
            feedbackSection.Show();

        }
    }
}
