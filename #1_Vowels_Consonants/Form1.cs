using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vowels_Consonants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string sentence = txtInput.Text;
            int vowels = 0;
            int consonants = 0;

            for (int ctr = 0; ctr < sentence.Length; ctr++)
            {
                char oneChar = sentence[ctr];
                switch (oneChar)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowels++;
                        break;
                    default:
                        consonants++;
                        break;
                }
            }

            lblOutput.Text = "Vowels: " + vowels + "\nConsonants: " + consonants;
        }
    }
}
