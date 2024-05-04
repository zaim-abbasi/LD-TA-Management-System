
namespace TA_LD_Management_System
{
    partial class studentDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Welcome = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label22 = new Label();
            label21 = new Label();
            label_StudentName = new Label();
            btn_editProfile = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label34 = new Label();
            label35 = new Label();
            label14 = new Label();
            label31 = new Label();
            label23 = new Label();
            button3 = new Button();
            label8 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label33 = new Label();
            label32 = new Label();
            label9 = new Label();
            label28 = new Label();
            label24 = new Label();
            label25 = new Label();
            label27 = new Label();
            label26 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label10 = new Label();
            button4 = new Button();
            label12 = new Label();
            label11 = new Label();
            label13 = new Label();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label_Welcome
            // 
            label_Welcome.AutoSize = true;
            label_Welcome.BackColor = Color.Transparent;
            label_Welcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Welcome.Location = new Point(27, 27);
            label_Welcome.Name = "label_Welcome";
            label_Welcome.Size = new Size(304, 74);
            label_Welcome.TabIndex = 0;
            label_Welcome.Text = "Welcome, ";
            label_Welcome.Click += labelWelcome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 140);
            label1.Name = "label1";
            label1.Size = new Size(1312, 32);
            label1.TabIndex = 1;
            label1.Text = "Your dashboard provides a personalized view of your TA/LD assignments, demo schedules, feedback, and communication.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label_StudentName);
            panel1.Controls.Add(btn_editProfile);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(50, 223);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 293);
            panel1.TabIndex = 0;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(111, 180);
            label22.Name = "label22";
            label22.Size = new Size(163, 32);
            label22.TabIndex = 7;
            label22.Text = "email_address";
            label22.Click += label22_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(111, 137);
            label21.Name = "label21";
            label21.Size = new Size(125, 32);
            label21.TabIndex = 6;
            label21.Text = "student_id";
            label21.Click += label21_Click;
            // 
            // label_StudentName
            // 
            label_StudentName.AutoSize = true;
            label_StudentName.Location = new Point(111, 91);
            label_StudentName.Name = "label_StudentName";
            label_StudentName.Size = new Size(165, 32);
            label_StudentName.TabIndex = 5;
            label_StudentName.Text = "student_name";
            label_StudentName.Click += label_StudentName_Click;
            // 
            // btn_editProfile
            // 
            btn_editProfile.BackColor = Color.Gray;
            btn_editProfile.ForeColor = Color.Black;
            btn_editProfile.Location = new Point(38, 231);
            btn_editProfile.Name = "btn_editProfile";
            btn_editProfile.Size = new Size(307, 41);
            btn_editProfile.TabIndex = 4;
            btn_editProfile.Text = "Edit Profile";
            btn_editProfile.UseVisualStyleBackColor = false;
            btn_editProfile.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold);
            label7.Location = new Point(22, 180);
            label7.Name = "label7";
            label7.Size = new Size(90, 32);
            label7.TabIndex = 3;
            label7.Text = "Email: ";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold);
            label6.Location = new Point(22, 137);
            label6.Name = "label6";
            label6.Size = new Size(54, 32);
            label6.TabIndex = 2;
            label6.Text = "ID: ";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold);
            label5.Location = new Point(25, 91);
            label5.Name = "label5";
            label5.Size = new Size(95, 32);
            label5.TabIndex = 1;
            label5.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 27);
            label2.Name = "label2";
            label2.Size = new Size(235, 32);
            label2.TabIndex = 0;
            label2.Text = "Profile Information";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(label34);
            panel2.Controls.Add(label35);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label31);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(523, 223);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 293);
            panel2.TabIndex = 1;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(128, 182);
            label34.Name = "label34";
            label34.Size = new Size(61, 32);
            label34.TabIndex = 12;
            label34.Text = "date";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.Location = new Point(18, 180);
            label35.Name = "label35";
            label35.Size = new Size(74, 32);
            label35.TabIndex = 11;
            label35.Text = "Date:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(128, 139);
            label14.Name = "label14";
            label14.Size = new Size(167, 32);
            label14.TabIndex = 10;
            label14.Text = "position name";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(18, 137);
            label31.Name = "label31";
            label31.Size = new Size(121, 32);
            label31.TabIndex = 9;
            label31.Text = "Position: ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(128, 93);
            label23.Name = "label23";
            label23.Size = new Size(143, 32);
            label23.TabIndex = 8;
            label23.Text = "status name";
            label23.Click += label23_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Location = new Point(51, 231);
            button3.Name = "button3";
            button3.Size = new Size(282, 41);
            button3.TabIndex = 6;
            button3.Text = "Apply to be a TA/LD";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 91);
            label8.Name = "label8";
            label8.Size = new Size(97, 32);
            label8.TabIndex = 5;
            label8.Text = "Status: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 27);
            label3.Name = "label3";
            label3.Size = new Size(222, 32);
            label3.TabIndex = 1;
            label3.Text = "Application Status";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(label33);
            panel3.Controls.Add(label32);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label28);
            panel3.Controls.Add(label24);
            panel3.Controls.Add(label25);
            panel3.Controls.Add(label27);
            panel3.Controls.Add(label26);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(1015, 223);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 293);
            panel3.TabIndex = 2;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(159, 230);
            label33.Name = "label33";
            label33.Size = new Size(104, 32);
            label33.TabIndex = 17;
            label33.Text = "ta_name";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(20, 231);
            label32.Name = "label32";
            label32.Size = new Size(50, 32);
            label32.TabIndex = 16;
            label32.Text = "TA:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 182);
            label9.Name = "label9";
            label9.Size = new Size(143, 32);
            label9.TabIndex = 15;
            label9.Text = "Instructor: ";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(159, 182);
            label28.Name = "label28";
            label28.Size = new Size(185, 32);
            label28.TabIndex = 11;
            label28.Text = "instructor_name";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(20, 139);
            label24.Name = "label24";
            label24.Size = new Size(107, 32);
            label24.TabIndex = 14;
            label24.Text = "Course: ";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(20, 93);
            label25.Name = "label25";
            label25.Size = new Size(81, 32);
            label25.TabIndex = 13;
            label25.Text = "Date: ";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(159, 136);
            label27.Name = "label27";
            label27.Size = new Size(154, 32);
            label27.TabIndex = 10;
            label27.Text = "course_name";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(159, 93);
            label26.Name = "label26";
            label26.Size = new Size(61, 32);
            label26.TabIndex = 8;
            label26.Text = "date";
            label26.Click += label26_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 27);
            label4.Name = "label4";
            label4.Size = new Size(313, 32);
            label4.TabIndex = 2;
            label4.Text = "Upcoming Demo Scedules";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(50, 607);
            panel4.Name = "panel4";
            panel4.Size = new Size(1354, 225);
            panel4.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Light", 7F);
            label17.Location = new Point(22, 180);
            label17.Name = "label17";
            label17.Size = new Size(128, 23);
            label17.TabIndex = 11;
            label17.Text = "- TA Zeeshan Ali";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(22, 140);
            label16.Name = "label16";
            label16.Size = new Size(777, 30);
            label16.TabIndex = 10;
            label16.Text = "Great job on your assignment. Make sure to add comments in your code next time";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Light", 7F);
            label15.Location = new Point(25, 110);
            label15.Name = "label15";
            label15.Size = new Size(152, 23);
            label15.TabIndex = 9;
            label15.Text = "Recieved on 5/3/24";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(22, 70);
            label10.Name = "label10";
            label10.Size = new Size(358, 30);
            label10.TabIndex = 8;
            label10.Text = "Assignment # 1 - Database Systems";
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Location = new Point(1030, 167);
            button4.Name = "button4";
            button4.Size = new Size(295, 41);
            button4.TabIndex = 5;
            button4.Text = "View all Feedbacks";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(38, 213);
            label12.Name = "label12";
            label12.Size = new Size(0, 32);
            label12.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 140);
            label11.Name = "label11";
            label11.Size = new Size(0, 32);
            label11.TabIndex = 2;
            label11.Click += label11_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(22, 27);
            label13.Name = "label13";
            label13.Size = new Size(211, 32);
            label13.TabIndex = 0;
            label13.Text = "Feedback Section";
            label13.Click += label13_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(label_Welcome);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1450, 118);
            panel5.TabIndex = 6;
            // 
            // studentDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1449, 884);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "studentDashboard";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            applyTA_LD applyTA_LD = new applyTA_LD();
            applyTA_LD.Show();

            // hide the current form
            this.Hide();
        }

        #endregion

        private Label label_Welcome;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_editProfile;
        private Button button3;
        private Label label8;
        private Panel panel4;
        private Label label13;
        private Button button4;
        private Label label12;
        private Label label11;
        private Label label22;
        private Label label21;
        private Label label_StudentName;
        private Label label23;
        private Label label26;
        private Label label28;
        private Label label27;
        private Label label14;
        private Label label31;
        private Label label34;
        private Label label35;
        private Label label9;
        private Label label24;
        private Label label25;
        private Label label33;
        private Label label32;
        private Label label10;
        private Label label16;
        private Label label15;
        private Label label17;
        private Panel panel5;
    }
}
