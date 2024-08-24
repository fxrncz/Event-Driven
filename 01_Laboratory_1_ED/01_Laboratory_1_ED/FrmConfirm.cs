using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Laboratory_1_ED
{
    
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram;
        private DelegateText DelLastName;
        private DelegateText DelFirstName;
        private DelegateText DelMiddleName;
        private DelegateText DelAddress;
        private DelegateNumber DelNumAge;
        private DelegateNumber DelNumContactNo;
        private DelegateNumber DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {

            lblprogram.Text = DelProgram(StudentInfoClass.Program);
            lblFirstname.Text = DelFirstName(StudentInfoClass.FirstName);
            lblLastname.Text = DelLastName(StudentInfoClass.LastName);
            lblMiddlename.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAddress.Text = DelAddress(StudentInfoClass.Address);
            lblstuno.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lblAge.Text = DelStudNo(StudentInfoClass.Age).ToString();
            lblContact.Text = DelStudNo(StudentInfoClass.ContactNo).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_Closing(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
