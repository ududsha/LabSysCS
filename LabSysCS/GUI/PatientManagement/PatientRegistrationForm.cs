using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LabSysCS.DataAccess;

namespace LabSysCS
{
    public partial class PatientRegistrationForm : Form
    {
        public PatientRegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            Patient.InsertApplicant(textBoxpatientName.Text, textBoxNIC.Text, Convert.ToDateTime(textBoxDOB.Text), comboBoxSex.Text, DateTime.Now, textBoxAddress.Text, textBoxPNumber.Text, textBoxEMail.Text);
        }
    }
}
