using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gender_and_hobbies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rdbmale.Checked == true)
            {
                gender = "male";
            }
            else
            {
                gender = "female ";
            }

            string hobbies = "";
            
            if (chx1.Checked == true)
            {
                hobbies = chx1.Text + " ";
            }
           
            if (chx2.Checked == true)
            {
                hobbies = chx2.Text + " ";
            }
            
            if (chx3.Checked == true)
            {
                hobbies = chx3.Text + " ";
            }
            MessageBox.Show("Youe Gender is :" + gender +"Your Hobbies is :" + hobbies);
        }
    }
}


