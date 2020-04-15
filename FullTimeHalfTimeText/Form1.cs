using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullTimeHalfTimeText
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCredits.Text, out double credits))
            {
                if (credits >= 12)
                {
                    lblStatus.Text = "Full time";
                }
                else if (credits >= 6)
                {
                    lblStatus.Text = "Half time";
                }
                else
                {
                    MessageBox.Show("Enter a positive number", "Error");
                }
            }
            else
            {
                MessageBox.Show("Enter a number", "Error");
            }
        }
    }
}
