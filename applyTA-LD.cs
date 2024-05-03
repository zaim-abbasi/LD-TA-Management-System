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
    public partial class applyTA_LD : Form
    {
        public applyTA_LD()
        {
            InitializeComponent();
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
            // submit application button    

            // first make sure no field is empty except for checkbox
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.");
            }
            else
            {
                // give a prompt that are you sure to submit the application
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit the application?", "Submit Application", MessageBoxButtons.YesNo);
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
            // provide a prompt that are you sure to discard  the application
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to discard the application?", "Discard Application Form", MessageBoxButtons.YesNo);
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
