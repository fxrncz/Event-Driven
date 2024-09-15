using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Laboratory_1_ED
{
    public partial class QueueingForm : Form
    {
        private CashierClass cashier;
       
        public QueueingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

            CashierWindowQueue cashierWindow = new CashierWindowQueue();
            cashierWindow.Show();

        }
    }
}
