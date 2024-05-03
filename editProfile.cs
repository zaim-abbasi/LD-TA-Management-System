using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_LD_Management_System
{
    public partial class editProfile : Form
    {
        public editProfile()
        {
            InitializeComponent();

            // personal info
            textBox1.Text = "Zaim Abbasi";
            textBox2.Text = "zaim.k.abbasi@gmail.com";
            textBox4.Text = "0311-1981621";
            richTextBox1.Text = "House 123, Street 456, Sector 7, Islamabad";

            // prev ta experience
            textBox3.Text = "Data Structures";
            textBox5.Text = "TA";
            textBox6.Text = "01/01/2021";
            textBox7.Text = "01/01/2022";

            //other relevant experience
            richTextBox2.Text = "I have been a TA for Data Structures for 1 year. I have also worked as a tutor for 2 years.";

            // certifications
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
                if(textBox3.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "")
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
            // check if the following fields are empty  textBox1.Text, textBox2.Text,textBox4.Text,richTextBox1.Text
            if (textBox3.Text == "" || textBox2.Text == "" || textBox4.Text == "" || richTextBox1.Text == "")
            {
                // if any of the fields are empty, show an error message
                MessageBox.Show("Please fill all the fields.");
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

        private void editProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
