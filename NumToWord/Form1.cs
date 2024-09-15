using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumToWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(txtValue.Text);
            string ones = "";
            string tens = "";
            string hundreds = "";
            string thousands = "";

            int th = value / 1000;
            int h = (value - (th * 1000)) / 100;
            int t = (value - (th * 1000) - (h * 100)) / 10;
            int o = value - (th * 1000) - (h * 100) - (t * 10);
            
            if(value >= 11 && value <= 19)
            {
                switch (value)
                {
                    case 11:
                        ones = "Eleven";
                        break;
                    case 12:
                        ones = "Twelve";
                        break;
                    case 13:
                        ones = "Thirteen";
                        break;
                    case 14:
                        ones = "Fourteen";
                        break;
                    case 15:
                        ones = "Fifthteen";
                        break;
                    case 16:
                        ones = "Sixthteen";
                        break;
                    case 17:
                        ones = "Seventhteen";
                        break;
                    case 18:
                        ones = "Eighteen";
                        break;
                    case 19:
                        ones = "Ninthteen";
                        break;
                }
            } 
            else 
            {
                switch (th)
                {
                    case 1:
                        thousands = "One Thounsand";
                        break;
                    case 2:
                        thousands = "Two Thounsand";
                        break;
                    case 3:
                        thousands = "Three Thounsand";
                        break;
                    case 4:
                        thousands = "Four Thounsand";
                        break;
                    case 5:
                        thousands = "Five Thounsand";
                        break;
                    case 6:
                        thousands = "Six Thounsand";
                        break;
                    case 7:
                        thousands = "Seven Thounsand";
                        break;
                    case 8:
                        thousands = "Eigth Thounsand";
                        break;
                    case 9:
                        thousands = "Nine Thounsand";
                        break;
                }

                switch (h)
                {
                    case 1:
                        hundreds = "One Hundred";
                        break;
                    case 2:
                        hundreds = "Two Hundred";
                        break;
                    case 3:
                        hundreds = "Three Hundred";
                        break;
                    case 4:
                        hundreds = "Four Hundred";
                        break;
                    case 5:
                        hundreds = "Five Hundred";
                        break;
                    case 6:
                        hundreds = "Six Hundred";
                        break;
                    case 7:
                        hundreds = "Seven Hundred";
                        break;
                    case 8:
                        hundreds = "Eigth Hundred";
                        break;
                    case 9:
                        hundreds = "Nine Hundred";
                        break;
                }

                switch (t)
                {
                    case 1:
                        tens = "Ten";
                        break;
                    case 2:
                        tens = "Twenty";
                        break;
                    case 3:
                        tens = "Thirty";
                        break;
                    case 4:
                        tens = "Forty";
                        break;
                    case 5:
                        tens = "Fifty";
                        break;
                    case 6:
                        tens = "Sixty";
                        break;
                    case 7:
                        tens = "Seventy";
                        break;
                    case 8:
                        tens = "Eighty";
                        break;
                    case 9:
                        tens = "Ninety";
                        break;
                }

                switch (o)
                {
                    case 1:
                        ones = "One";
                        break;
                    case 2:
                        ones = "Two ";
                        break;
                    case 3:
                        ones = "Three";
                        break;
                    case 4:
                        ones = "Four";
                        break;
                    case 5:
                        ones = "Five";
                        break;
                    case 6:
                        ones = "Six";
                        break;
                    case 7:
                        ones = "Seven";
                        break;
                    case 8:
                        ones = "Eigth";
                        break;
                    case 9:
                        ones = "Nine";
                        break;
                }
            }

            lblOutput.Text = thousands + " " + hundreds + " " + tens + " " + ones;
        }
    }
}
