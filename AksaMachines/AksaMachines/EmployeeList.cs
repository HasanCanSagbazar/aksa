using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AksaMachines
{
    public partial class EmployeeList : UserControl
    {
        public EmployeeList()
        {
            InitializeComponent();
        }
        /*
        private void Surname_Click(object sender, EventArgs e)
        {

        }

        private void empRole_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        */
        #region Properties
        private string empId_ = "";
        private string empName_ = "";
        private string empSurname_ = "";
        private string empRole_ = "";
        private string empPhone_ = "";


        [Category("Custom Props")]
        public string EmpId
        {
            get { return empId_; }
            set { empId_ = value; empId.Text = value; }
        }

        [Category("Custom Props")]
        public string EmpName
        {
            get { return empName_; }
            set { empName_ = value; empName.Text = value; }
        }

        [Category("Custom Props")]
        public string EmpSurname
        {
            get { return empSurname_; }
            set { empSurname_ = value; empSurname.Text = value; }
        }

        [Category("Custom Props")]
        public string EmpRole
        {
            get { return empRole_; }
            set { empRole_ = value; empRole.Text = value; }
        }

        [Category("Custom Props")]
        public string EmpPhone
        {
            get { return empPhone_; }
            set { empPhone_ = value; empPhoneNoLabel.Text = value; }
        }
        #endregion

    }
}
