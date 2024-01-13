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
    public partial class Aksa_Makine_Bilgisi : Form
    {
        public Aksa_Makine_Bilgisi()
        {
            InitializeComponent();
            
        }

        /*private void employeeLabel_Click(object sender, EventArgs e)
        {

        }*/

        private void Aksa_Makine_Bilgisi_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            MachineControl[] machineControls = new MachineControl[5];

            for (int i = 0; i < machineControls.Length; i++)
            {
                machineControls[i] = new MachineControl();

                machineControls[i].MachineId = "machine id";
                machineControls[i].MachineName = "name";
                machineControls[i].Info1 = "info1";
                machineControls[i].Info2 = "info2";

                //if (allMachineDisplay.Controls.Count > 1)
                //{
                //    allMachineDisplay.Controls.Clear(); 
                //}
                //else
                //{
                    
                //}
                allMachineDisplay.Controls.Add(machineControls[i]); 
            }
        }
    }
}
