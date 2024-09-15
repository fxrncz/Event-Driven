using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myNum = Convert.ToInt32(textBox1.Text);
            int firstN = 0;
            int secondN = 1;
            string op = " ";

            for (int ctr = 0; ctr < myNum; ctr++)
            {
                op += firstN + " ";
                int output = firstN + secondN; // 1
                firstN = secondN; // 1
                secondN = output; // 1
            }

            label1.Text = op;
        }
    }
}
