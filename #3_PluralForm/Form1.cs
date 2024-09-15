using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluralForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string word = txtInput.Text;

            if (word.Equals("Box") || word.Equals("box"))
            {
                lblOutput.Text = "The Plural Form is: 'Boxes'";
            } else if(word.Equals("Paper") || word.Equals("paper"))
            {
                lblOutput.Text = "The Plural Form is: 'Papers'";
            } else if (word.Equals("City") || word.Equals("city"))
            {
                lblOutput.Text = "The Plural Form is: 'Cities'";
            } else if(word.Equals("Math") || word.Equals("math"))
            {
                lblOutput.Text = "The Plural Form is: 'Maths'";
            } else
            {
                MessageBox.Show("Invalid Word!", "Warning");
            }
        }
    }
}
