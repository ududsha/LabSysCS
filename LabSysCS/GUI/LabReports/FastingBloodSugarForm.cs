using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LabSysCS.DataAccess;

namespace LabSysCS.GUI.LabReports
{
    public partial class FastingBloodSugarForm : Form
    {
        public FastingBloodSugarForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PatientID = textBoxPatientID.Text;
            string ReferredDOc = textBoxReferredBy.Text;
            string FastBloodSugar = textBoxFastingBloodSugar.Text;
            string PrandialBloodSugar = textBoxPardialBloodSugar.Text;

            Report.InsertFastingBloodSugar(DateTime.Now, Convert.ToInt32(PatientID), ReferredDOc, Convert.ToDouble(FastBloodSugar), Convert.ToDouble(PrandialBloodSugar));
 
                
        }
    }
}
