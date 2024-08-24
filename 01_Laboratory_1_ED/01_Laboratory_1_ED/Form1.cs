using System;
using System.Collections;
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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
            ComboBoxFunc();
        }

        public void ComboBoxFunc()
        {
            ArrayList programs = new ArrayList();

            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");

            for (int i = 0; i < programs.Count; i++)
            {
                progCombox.Items.Add(programs[i]);
            }
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {

            StudentInfoClass.FirstName = fnTxt.Text.ToString();
            StudentInfoClass.LastName = lnTxt.Text.ToString();
            StudentInfoClass.MiddleName = mnTxt.Text.ToString();
            StudentInfoClass.Address = addTxt.Text.ToString();
            StudentInfoClass.Program = progCombox.SelectedItem.ToString();
            StudentInfoClass.StudentNo = long.Parse(stunoTxt.Text.Trim());
            StudentInfoClass.Age = long.Parse(ageTxt.Text.Trim());
            StudentInfoClass.ContactNo = long.Parse(contnoTxt.Text.Trim());

            FrmConfirm frmConfirm = new FrmConfirm();
            if (frmConfirm.ShowDialog() == DialogResult.OK)
            {
                fnTxt.Text = " ";
                lnTxt.Text = " ";
                mnTxt.Text = " ";
                addTxt.Text = " ";
                progCombox.Text = " ";
                ageTxt.Text = " ";
                contnoTxt.Text = " ";
                stunoTxt.Text = " ";
            }
        }
    }
}
