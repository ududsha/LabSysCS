using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LabSysCS.GUI.PatientManagement;
using LabSysCS.GUI;
using LabSysCS.GUI.LabPlus;
using LabSysCS.GUI.Billing;
using LabSysCS.GUI.LabReports;



namespace LabSysCS
{
    public partial class Form1 : Form
    {
        private PatientRegistrationForm RegistrationForm;
        private PatientInfoForm InfoForm;
        private AlertSendingForm AlertForm;
        private TestResultArchiveForm ResultArchiveForm;
        private InvoiceForm PatientInvoiceForm;
        private ViewInvoices ViewInvoicesForm;
        private FastingBloodSugarForm FastingBloodSugarFrm;
        private FastingBloodSugarForm FSBF;

        private string pvalue;

        public string PassValue
        {
            get { return pvalue; }
            set { pvalue = value; }
        }
                
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            RegistrationForm = new PatientRegistrationForm();
            RegistrationForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PatientInfoForm InfoForm = new PatientInfoForm();
			string textValue = textBox1.Text;
            InfoForm.PassValue = textValue;
            //int textInt = Convert.ToInt32(textValue);
            
            InfoForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlertForm = new AlertSendingForm();
            AlertForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ResultArchiveForm = new TestResultArchiveForm();
            ResultArchiveForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PatientInvoiceForm = new InvoiceForm();
            PatientInvoiceForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewInvoicesForm = new ViewInvoices();
            ViewInvoicesForm.Show();

        }
     	
		private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lABSYSDataSet.Patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.lABSYSDataSet.Patient);
            //LoginForm lfrm = new LoginForm();
            labelOperatorName.Text = PassValue;

        }

        private void buttonNewReports_Click(object sender, EventArgs e)
        {
             if (listBoxTestItems.SelectedItem.ToString() == "Fasting Blood Sugar")
            {
                   FastingBloodSugarFrm = new FastingBloodSugarForm();
            

                 FastingBloodSugarFrm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(groupBoxReportItems.)
           
                
            
        }

       

        
    }
}
