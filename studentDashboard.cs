namespace TA_LD_Management_System
{
    public partial class studentDashboard : Form
    {
        public studentDashboard()
        {
            InitializeComponent();
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // For Welcome waghera
            label_Welcome.Text = "";
            label_StudentName.Text = "";
            string studentName = "Zaim Abbasi";
            label_StudentName.Text = studentName;
            label_Welcome.Text += "Welcome, " + studentName;

            // For Profile section
            label21.Text = "";
            label22.Text = "";
            label_StudentName.Text = "";
            label21.Text = "22I-2462";
            label22.Text = "zaim.k.abbasi@gmail.com";

            // For Application Status
            label23.Text = "";
            label14.Text = "";
            label34.Text = "";
            label23.Text = "Pending";
            label14.Text = "Lab Demonstrator";
            label34.Text = "10-02-2024";


            // For Demo Scedule
            label26.Text = "";
            label27.Text = "";
            label28.Text = "";
            label33.Text = "";
            label26.Text = "10-02-24 10:00 AM";
            label27.Text = "Data Structures";
            label28.Text = "Dr. Ali Zaidi";
            label33.Text = "Zeeshan Ali";

            // feedback section
            label10.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            String courseName = "Data Structures";
            String assignmentID = "DS-01";
            label10.Text = courseName + " - " + assignmentID;
            String date = "10-02-2024";
            label15.Text = "Recieved on: " + date;
            label16.Text = "Assignment was good. Keep it up!";
            label17.Text = " -TA Zeeshan Ali";






        }



        private void label1_Click(object sender, EventArgs e)
        {
            // hide this form
            this.Hide();
            // edit profile button
            editProfile editProfile = new editProfile();
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
