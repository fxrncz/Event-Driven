using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumToRomNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
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

            if (value >= 11 && value <= 19)
            {
                switch (value)
                {
                    case 11:
                        ones = "XI";
                        break;
                    case 12:
                        ones = "XII";
                        break;
                    case 13:
                        ones = "XIII";
                        break;
                    case 14:
                        ones = "XIV";
                        break;
                    case 15:
                        ones = "XV";
                        break;
                    case 16:
                        ones = "XVI";
                        break;
                    case 17:
                        ones = "XVII";
                        break;
                    case 18:
                        ones = "XVIII";
                        break;
                    case 19:
                        ones = "XIX";
                        break;
                }
            }
            else
            {
                switch (th)
                {
                    case 1:
                        thousands = "M";
                        break;
                    case 2:
                        thousands = "MM";
                        break;
                    case 3:
                        thousands = "MMM";
                        break;
                    case 4:
                        thousands = "MMMM";
                        break;
                    case 5:
                        thousands = "MMMMM";
                        break;
                    case 6:
                        thousands = "MMMMMM";
                        break;
                    case 7:
                        thousands = "MMMMMMM";
                        break;
                    case 8:
                        thousands = "MMMMMMMM";
                        break;
                    case 9:
                        thousands = "MMMMMMMMM";
                        break;
                }

                switch (h)
                {
                    case 1:
                        hundreds = "C";
                        break;
                    case 2:
                        hundreds = "CC";
                        break;
                    case 3:
                        hundreds = "CCC";
                        break;
                    case 4:
                        hundreds = "CD";
                        break;
                    case 5:
                        hundreds = "D";
                        break;
                    case 6:
                        hundreds = "DC";
                        break;
                    case 7:
                        hundreds = "DCC";
                        break;
                    case 8:
                        hundreds = "DCCC";
                        break;
                    case 9:
                        hundreds = "CM";
                        break;
                }

                switch (t)
                {
                    case 1:
                        tens = "X";
                        break;
                    case 2:
                        tens = "XX";
                        break;
                    case 3:
                        tens = "XXX";
                        break;
                    case 4:
                        tens = "XL";
                        break;
                    case 5:
                        tens = "L";
                        break;
                    case 6:
                        tens = "LX";
                        break;
                    case 7:
                        tens = "LXX";
                        break;
                    case 8:
                        tens = "LXXX";
                        break;
                    case 9:
                        tens = "XC";
                        break;
                }

                switch (o)
                {
                    case 1:
                        ones = "I";
                        break;
                    case 2:
                        ones = "II ";
                        break;
                    case 3:
                        ones = "III";
                        break;
                    case 4:
                        ones = "IV";
                        break;
                    case 5:
                        ones = "V";
                        break;
                    case 6:
                        ones = "VI";
                        break;
                    case 7:
                        ones = "VII";
                        break;
                    case 8:
                        ones = "VIII";
                        break;
                    case 9:
                        ones = "IX";
                        break;
                }
            }

            lblOutput.Text = thousands + hundreds + tens + ones;
        }
    }
}
