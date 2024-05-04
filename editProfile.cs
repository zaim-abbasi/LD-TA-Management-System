using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TA_LD_Management_System
{
    public partial class editProfile : Form
    {
        private string connectionString = "Data Source=DESKTOP-591GTQC\\SQLEXPRESS;Initial Catalog=DB_Final_Project;Integrated Security=True;TrustServerCertificate=True";
        private string studentEmail; // Variable to store the student's email
        public editProfile(String email)
        {
            InitializeComponent();

            studentEmail = email; // Set the studentEmail variable to the provided email
            LoadProfileData();

            // Load additional data
            LoadPrevTAExperience();
            LoadOtherExperience();
            LoadCertifications();
        }

        private void LoadProfileData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Password, Phone, Address FROM Student WHERE Email = @Email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", studentEmail);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            textBox1.Text = reader["Name"].ToString();
                            textBox2.Text = reader["Password"].ToString();
                            textBox4.Text = reader["Phone"].ToString();
                            richTextBox1.Text = reader["Address"].ToString();
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
        }

        private void LoadPrevTAExperience()
        {
            // Query database or use hardcoded data to fetch previous TA experience
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void LoadOtherExperience()
        {
            // Query database or use hardcoded data to fetch other relevant experience
            richTextBox2.Text = "I have been a TA for Data Structures for 1 year. I have also worked as a tutor for 2 years.";
        }

        private void LoadCertifications()
        {
            // Query database or use hardcoded data to fetch certifications
            richTextBox3.Text = "I have completed a course on Data Structures from Coursera.";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // give a prompt that are you sure to cancel the changes
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the changes?", "Cancel Changes", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // if yes, close this form and show the student dashboard form
                this.Hide();
                studentDashboard studentDashboard = new studentDashboard();
                studentDashboard.Show();

            }
            else if (dialogResult == DialogResult.No)
            {
                // if no, do nothing
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save button
            // give a prompt that are you sure to save the changes
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save the changes?", "Save Changes", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // if yes, close this form and show the student dashboard form
                this.Hide();
                studentDashboard studentDashboard = new studentDashboard();
                studentDashboard.Show();

            }
            else if (dialogResult == DialogResult.No)
            {
                // if no, then do nothing
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // if all the fields are filled, show a success message, if any of the field is empty in textBox3.Text, textBox5.Text,textBox6.Text or textBox7.Text show an error message to fill all the fields
            if (textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                // if all fields are empty, dont show any message
                if (textBox3.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "")
                {
                    MessageBox.Show("Nothing to Save");
                }
                else
                {
                    // if any of the fields are empty, show an error message
                    MessageBox.Show("Please fill all the fields.");
                }
            }
            else
            {
                // if all the fields are filled, show a success message
                // give a prompt that are you sure to save the changes
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save the changes?", "Save Changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // if yes, close this form and show the student dashboard form
                    this.Hide();
                    studentDashboard studentDashboard = new studentDashboard();
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
            if (!AllFieldsFilled())
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save the changes?", "Save Changes", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (SaveChangesToDatabase())
                {
                    MessageBox.Show("Changes saved successfully.");
                    Hide();
                    studentDashboard studentDashboardForm = new studentDashboard(studentEmail);
                    studentDashboardForm.Show();
                }
                else
                {
                    MessageBox.Show("Failed to save changes.");
                }
            }
        }

        private bool AllFieldsFilled()
        {
            return !string.IsNullOrEmpty(textBox1.Text) &&
                   !string.IsNullOrEmpty(textBox2.Text) &&
                   !string.IsNullOrEmpty(textBox4.Text) &&
                   !string.IsNullOrEmpty(richTextBox1.Text);
        }
        private bool SaveChangesToDatabase()
        {
            try
            {
                if (!AllFieldsFilled())
                {
                    MessageBox.Show("Please fill all the fields.");
                    return false;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Student SET Name = @Name, Password = @Password, Phone = @Phone, Address = @Address WHERE Email = @Email";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", textBox1.Text);
                        command.Parameters.AddWithValue("@Password", textBox2.Text);
                        command.Parameters.AddWithValue("@Phone", textBox4.Text);
                        command.Parameters.AddWithValue("@Address", richTextBox1.Text);
                        command.Parameters.AddWithValue("@Email", studentEmail);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                    }
                }

                MessageBox.Show("No rows updated. Verify student Email.");
                return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }



        private void editProfile_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
