using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TA_LD_Management_System
{
    public partial class loginPage : Form
    {
        private string connectionString = "Data Source=DESKTOP-591GTQC\\SQLEXPRESS;Initial Catalog=DB_Final_Project;Integrated Security=True;TrustServerCertificate=True";

        public loginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (IsValidEmail(email))
            {
                string query = "SELECT * FROM Student WHERE Email = @Email AND Password = @Password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login Successful");

                                // Hide the current loginPage
                                this.Hide();

                                // Create an instance of studentDashboard form and pass the email
                                studentDashboard studentDashboardForm = new studentDashboard(textBox1.Text); // Assuming textBox1 contains the email
                                studentDashboardForm.Show();
                            }


                            else
                            {
                                MessageBox.Show("Invalid email or password. Please try again.");
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
                        finally
                        {
                            if (connection.State == System.Data.ConnectionState.Open)
                                connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid email format");
            }
        }

        private bool IsValidEmail(string email)
        {
            return !string.IsNullOrEmpty(email) && email.Contains("@");
        }
    }
}
