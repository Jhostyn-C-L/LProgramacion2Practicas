using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                label1.Text = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                label1.Text = radioButton3.Text;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
