using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FeedbackApplicatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tijdsregistatiepage nextForm = new Tijdsregistatiepage();  
            nextForm.Show();              
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Feedbackpage nextForm = new Feedbackpage();
            nextForm.Show();              
            this.Hide();                 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loginpage nextForm = new Loginpage();
            nextForm.Show();
            this.Hide();
        }
       
    }
}
