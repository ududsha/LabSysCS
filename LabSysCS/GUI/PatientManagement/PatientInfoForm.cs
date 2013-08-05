using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LabSysCS.DataAccess;

namespace LabSysCS.GUI.PatientManagement
{
    public partial class PatientInfoForm : Form
    {
        public PatientInfoForm()
        {
            InitializeComponent();
        }

         private string pvalue;

        public string PassValue
        {
            get { return pvalue; }
            set { pvalue = value; }
        }

        private void PatientInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lABSYSDataSet.Patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.lABSYSDataSet.Patient);
            //this.bindingNavigator1.BindingSource.PositionChanged += new EventHandler(patientBindingSource1_PositionChanged);

            Form1 frm = new Form1();

            label9.Text = pvalue;
            string UserNameDb = null;

            DataSet dataSet1 = Patient.GetPatient(Convert.ToInt32(PassValue));

            

            foreach (DataRow row in dataSet1.Tables["PatientName"].Rows)
            {
                UserNameDb = string.Format("{0}", row["PatientID"]);
                textBoxPatientID.Text = UserNameDb;

                UserNameDb = string.Format("{0}", row["PatientName"]);
                textBoxpatientName.Text = UserNameDb;

                UserNameDb = string.Format("{0}", row["NIC"]);
                textBoxNIC.Text = UserNameDb;


                UserNameDb = string.Format("{0}", row["DOB"]);
                textBoxDOB.Text = UserNameDb;

                UserNameDb = string.Format("{0}", row["Sex"]);
                textBoxSex.Text = UserNameDb;


                //UserNameDb = string.Format("{0}", row["RegisteredDate"]);
                //textBoxRegisteredDate.Text = UserNameDb;

                UserNameDb = string.Format("{0}", row["Address"]);
                textBoxAddress.Text = UserNameDb;

                UserNameDb = string.Format("{0}", row["PNumber"]);
                textBoxPNumber.Text = UserNameDb;

                UserNameDb = string.Format("{0}", row["EMail"]);
                textBoxEMail.Text = UserNameDb;

            }

            

            

            
            

        }
    }
}
