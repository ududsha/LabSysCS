namespace LabSysCS.GUI.LabReports
{
    partial class FastingBloodSugarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPatientID = new System.Windows.Forms.TextBox();
            this.labelPatientId = new System.Windows.Forms.Label();
            this.labelReferredBy = new System.Windows.Forms.Label();
            this.textBoxReferredBy = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelReportId = new System.Windows.Forms.Label();
            this.groupBoxPatientInfo = new System.Windows.Forms.GroupBox();
            this.textBoxFastingBloodSugar = new System.Windows.Forms.TextBox();
            this.labelFastingBloodSugar = new System.Windows.Forms.Label();
            this.labelPostPrandialBloodSugar = new System.Windows.Forms.Label();
            this.textBoxPardialBloodSugar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxPatientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.Location = new System.Drawing.Point(100, 59);
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(326, 20);
            this.textBoxPatientID.TabIndex = 33;
            // 
            // labelPatientId
            // 
            this.labelPatientId.AutoSize = true;
            this.labelPatientId.Location = new System.Drawing.Point(16, 66);
            this.labelPatientId.Name = "labelPatientId";
            this.labelPatientId.Size = new System.Drawing.Size(54, 13);
            this.labelPatientId.TabIndex = 32;
            this.labelPatientId.Text = "Patient ID";
            // 
            // labelReferredBy
            // 
            this.labelReferredBy.AutoSize = true;
            this.labelReferredBy.Location = new System.Drawing.Point(16, 101);
            this.labelReferredBy.Name = "labelReferredBy";
            this.labelReferredBy.Size = new System.Drawing.Size(82, 13);
            this.labelReferredBy.TabIndex = 38;
            this.labelReferredBy.Text = "Referred by Dr .";
            // 
            // textBoxReferredBy
            // 
            this.textBoxReferredBy.Location = new System.Drawing.Point(100, 98);
            this.textBoxReferredBy.Name = "textBoxReferredBy";
            this.textBoxReferredBy.Size = new System.Drawing.Size(326, 20);
            this.textBoxReferredBy.TabIndex = 39;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 20);
            this.textBox1.TabIndex = 41;
            // 
            // labelReportId
            // 
            this.labelReportId.AutoSize = true;
            this.labelReportId.Location = new System.Drawing.Point(16, 28);
            this.labelReportId.Name = "labelReportId";
            this.labelReportId.Size = new System.Drawing.Size(53, 13);
            this.labelReportId.TabIndex = 40;
            this.labelReportId.Text = "Report ID";
            // 
            // groupBoxPatientInfo
            // 
            this.groupBoxPatientInfo.Controls.Add(this.textBoxReferredBy);
            this.groupBoxPatientInfo.Controls.Add(this.textBox1);
            this.groupBoxPatientInfo.Controls.Add(this.labelReportId);
            this.groupBoxPatientInfo.Controls.Add(this.labelReferredBy);
            this.groupBoxPatientInfo.Controls.Add(this.labelPatientId);
            this.groupBoxPatientInfo.Controls.Add(this.textBoxPatientID);
            this.groupBoxPatientInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPatientInfo.Name = "groupBoxPatientInfo";
            this.groupBoxPatientInfo.Size = new System.Drawing.Size(447, 141);
            this.groupBoxPatientInfo.TabIndex = 42;
            this.groupBoxPatientInfo.TabStop = false;
            this.groupBoxPatientInfo.Text = "General Info";
            this.groupBoxPatientInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxFastingBloodSugar
            // 
            this.textBoxFastingBloodSugar.Location = new System.Drawing.Point(164, 182);
            this.textBoxFastingBloodSugar.Name = "textBoxFastingBloodSugar";
            this.textBoxFastingBloodSugar.Size = new System.Drawing.Size(171, 20);
            this.textBoxFastingBloodSugar.TabIndex = 46;
            // 
            // labelFastingBloodSugar
            // 
            this.labelFastingBloodSugar.AutoSize = true;
            this.labelFastingBloodSugar.Location = new System.Drawing.Point(28, 189);
            this.labelFastingBloodSugar.Name = "labelFastingBloodSugar";
            this.labelFastingBloodSugar.Size = new System.Drawing.Size(102, 13);
            this.labelFastingBloodSugar.TabIndex = 45;
            this.labelFastingBloodSugar.Text = "Fasting Blood Sugar";
            // 
            // labelPostPrandialBloodSugar
            // 
            this.labelPostPrandialBloodSugar.AutoSize = true;
            this.labelPostPrandialBloodSugar.Location = new System.Drawing.Point(28, 292);
            this.labelPostPrandialBloodSugar.Name = "labelPostPrandialBloodSugar";
            this.labelPostPrandialBloodSugar.Size = new System.Drawing.Size(130, 13);
            this.labelPostPrandialBloodSugar.TabIndex = 43;
            this.labelPostPrandialBloodSugar.Text = "Post Prandial Blood Sugar";
            // 
            // textBoxPardialBloodSugar
            // 
            this.textBoxPardialBloodSugar.Location = new System.Drawing.Point(164, 285);
            this.textBoxPardialBloodSugar.Name = "textBoxPardialBloodSugar";
            this.textBoxPardialBloodSugar.Size = new System.Drawing.Size(171, 20);
            this.textBoxPardialBloodSugar.TabIndex = 44;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 80);
            this.button3.TabIndex = 49;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 80);
            this.button1.TabIndex = 47;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "mg/dl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "mg/dl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 39);
            this.label3.TabIndex = 52;
            this.label3.Text = "Normal Range: children 60 -100mg/dl\r\nAdult 74 - 106 mg/dl\r\n60-90yrs. 82 - 115mg/d" +
    "l";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FastingBloodSugarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFastingBloodSugar);
            this.Controls.Add(this.labelFastingBloodSugar);
            this.Controls.Add(this.labelPostPrandialBloodSugar);
            this.Controls.Add(this.textBoxPardialBloodSugar);
            this.Controls.Add(this.groupBoxPatientInfo);
            this.Name = "FastingBloodSugarForm";
            this.Text = "Fasting Blood Sugar - Report";
            this.groupBoxPatientInfo.ResumeLayout(false);
            this.groupBoxPatientInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPatientID;
        private System.Windows.Forms.Label labelPatientId;
        private System.Windows.Forms.Label labelReferredBy;
        private System.Windows.Forms.TextBox textBoxReferredBy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelReportId;
        private System.Windows.Forms.GroupBox groupBoxPatientInfo;
        private System.Windows.Forms.TextBox textBoxFastingBloodSugar;
        private System.Windows.Forms.Label labelFastingBloodSugar;
        private System.Windows.Forms.Label labelPostPrandialBloodSugar;
        private System.Windows.Forms.TextBox textBoxPardialBloodSugar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}