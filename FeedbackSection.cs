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
    public partial class FeedbackSection : Form
    {
        public FeedbackSection()
        {
            InitializeComponent();

            // it will hide feedback panels if no of feedbacks are low in database
            //panel2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FeedbackSection_Load(object sender, EventArgs e)
        {

        }
    }
}
