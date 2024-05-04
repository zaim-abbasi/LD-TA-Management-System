using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace TA_LD_Management_System
{
    public partial class applyTA_LD : Form
    {
        private string connectionString = "Data Source=DESKTOP-591GTQC\\SQLEXPRESS;Initial Catalog=DB_Final_Project;Integrated Security=True;TrustServerCertificate=True";
        private string loggedInEmail;
        public applyTA_LD(string email)
        {
            InitializeComponent();
            loggedInEmail = email;

            // textBox1 -> Name
            // textBox2 -> ID
            // textBox3 -> Department
            // textBox4 -> Semester
            // textBox5 -> Course ID
            // textBox6 -> GPA
            // textBox7 -> Position (TA/LD)
            // textBox8 -> Course Grade
            // textBox10 -> Lab Grade
            // ricTextBox1 -> Past Experience



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void applyTA_LD_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Submit application button    

                // First make sure no required field is empty
                if (IsFormValid())
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit the application?", "Submit Application", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (SubmitApplication())
                        {
                            MessageBox.Show("Application submitted successfully.", "Success");
                            this.Hide();
                            studentDashboard studentDashboard = new studentDashboard(loggedInEmail);
                            studentDashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit application. Please try again later.", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error");
                return false;
            }

            if (textBox7.Text != "TA" && textBox7.Text != "LD")
            {
                MessageBox.Show("Position must be either 'TA' or 'LD'.", "Error");
                return false;
            }

            return true;
        }

        private bool SubmitApplication()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO ApplicationForm (student_id, Name, Department, CGPA, course_id, position, Lab_grade, course_grade, pastExperience)
                             VALUES (@StudentID, @Name, @Department, @CGPA, @CourseID, @Position, @LabGrade, @CourseGrade, @PastExperience)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Validate and add parameters
                        if (int.TryParse(textBox2.Text, out int studentId))
                            command.Parameters.AddWithValue("@StudentID", studentId);
                        else
                            throw new ArgumentException("Invalid student ID.");

                        command.Parameters.AddWithValue("@Name", textBox1.Text);
                        command.Parameters.AddWithValue("@Department", textBox3.Text);

                        if (decimal.TryParse(textBox6.Text, out decimal cgpa))
                            command.Parameters.AddWithValue("@CGPA", cgpa);
                        else
                            throw new ArgumentException("Invalid CGPA.");

                        if (int.TryParse(textBox5.Text, out int courseId))
                            command.Parameters.AddWithValue("@CourseID", courseId);
                        else
                            throw new ArgumentException("Invalid course ID.");

                        command.Parameters.AddWithValue("@Position", textBox7.Text);

                        if (decimal.TryParse(textBox8.Text, out decimal courseGrade))
                            command.Parameters.AddWithValue("@CourseGrade", courseGrade);
                        else
                            throw new ArgumentException("Invalid course grade.");

                        // Check if Lab Grade is provided, otherwise set it to NULL
                        if (string.IsNullOrWhiteSpace(textBox10.Text))
                            command.Parameters.AddWithValue("@LabGrade", DBNull.Value);
                        else if (decimal.TryParse(textBox10.Text, out decimal labGrade))
                            command.Parameters.AddWithValue("@LabGrade", labGrade);
                        else
                            throw new ArgumentException("Invalid lab grade.");

                        // Check if Past Experience is provided, otherwise set it to NULL
                        if (string.IsNullOrWhiteSpace(richTextBox1.Text))
                            command.Parameters.AddWithValue("@PastExperience", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@PastExperience", richTextBox1.Text);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Insertion successful.", "Success");   
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. Please verify the data and try again.", "Error");
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error occurred: " + ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }

            return false; // Return false if insertion fails
        }





        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Welcome_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // submit button code

            // first check if any field is empty except for checkboxes
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.");
            }
            else
            {
                // if not empty, then show a prompt that are you sure to save the application
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Submit the application?", "Submit Application", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // if yes, close this form and show the student dashboard form
                    this.Hide();
                    studentDashboard studentDashboard = new studentDashboard(loggedInEmail);
                    studentDashboard.Show();

                }
                else if (dialogResult == DialogResult.No)
                {
                    // if no, then do nothing
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // discad button code

            // provide a prompt that are you sure to discard  the application
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to discard the application?", "Discard Application Form", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // if yes, close this form and show the student dashboard form
                this.Hide();
                studentDashboard studentDashboard = new studentDashboard(loggedInEmail);
                studentDashboard.Show();

            }
            else if (dialogResult == DialogResult.No)
            {
                // if no, then do nothing
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
