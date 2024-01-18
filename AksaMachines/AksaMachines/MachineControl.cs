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
    public partial class MachineControl : UserControl
    {
        //public event EventHandler<EventArgs> MachineControlClicked;
        public MachineControl()
        {
            InitializeComponent();
            //this.Click += machineControls_Clicked;
        }

        #region Properties
        private string machineId_ = "";
        private string machineName_ = "";
        public string holdingMachineId = "";
        //public int machineControlClickCount = 0;

        /*private void machineControls_Clicked(object sender, EventArgs e)
        {
            MachineControlClicked?.Invoke(this, EventArgs.Empty);
        }*/

        [Category("Custom Props")]
        public string MachineId
        {
            get { return machineId_; }
            set { machineId_ = value; machineId_in.Text = value; }
        }

        [Category("Custom Props")]
        public string MachineName
        {
            get { return machineName_; }
            set { machineName_ = value; machineName_in.Text = value; }
        }



        #endregion

        /*private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }*/
    }
}
