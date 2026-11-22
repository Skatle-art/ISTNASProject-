namespace ISTNASProject
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.cbPatientID = new System.Windows.Forms.ComboBox();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hlangaLDB = new ISTNASProject.HlangaLDB();
            this.label2 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MonthlyAppointmentRevenue1 = new ISTNASProject.MonthlyAppointmentRevenue();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGetFullReport = new System.Windows.Forms.Button();
            this.cbAppointmentReport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.crvAppReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.AppointmentSalesReport1 = new ISTNASProject.AppointmentSalesReport();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGenerateFullTR = new System.Windows.Forms.Button();
            this.btnGenerateTR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTreatmentType = new System.Windows.Forms.ComboBox();
            this.treatmentLookupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDS = new ISTNASProject.ColeIst3ckDataSet();
            this.crvSalesPerTreatment = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SalePerTreatmentReport1 = new ISTNASProject.SalePerTreatmentReport();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmnetLookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter1 = new ISTNASProject.ColeIst3ckDataSetTableAdapters.AppointmentTableAdapter();
            this.treatmentTableAdapter1 = new ISTNASProject.ColeIst3ckDataSetTableAdapters.TreatmentTableAdapter();
            this.patientTableAdapter1 = new ISTNASProject.ColeIst3ckDataSetTableAdapters.PatientTableAdapter();
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmnet_LookupTableAdapter = new ISTNASProject.ColeIst3ckDataSetTableAdapters.Treatmnet_LookupTableAdapter();
            this.treatmentLookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatment_LookupTableAdapter = new ISTNASProject.ColeIst3ckDataSetTableAdapters.Treatment_LookupTableAdapter();
            this.treatmnetLookupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new ISTNASProject.HlangaLDBTableAdapters.PatientTableAdapter();
            this.treatmentLookupBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.treatment_LookupTableAdapter1 = new ISTNASProject.HlangaLDBTableAdapters.Treatment_LookupTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlangaLDB)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentLookupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmnetLookupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentLookupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmnetLookupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentLookupBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1924, 1055);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnGetReport);
            this.tabPage1.Controls.Add(this.cbPatientID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.crystalReportViewer1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1916, 1020);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales Per Patient";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(1833, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(443, 18);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(225, 52);
            this.btnGetReport.TabIndex = 3;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // cbPatientID
            // 
            this.cbPatientID.DataSource = this.patientBindingSource1;
            this.cbPatientID.DisplayMember = "PatientID";
            this.cbPatientID.FormattingEnabled = true;
            this.cbPatientID.Location = new System.Drawing.Point(237, 40);
            this.cbPatientID.Name = "cbPatientID";
            this.cbPatientID.Size = new System.Drawing.Size(154, 30);
            this.cbPatientID.TabIndex = 2;
            this.cbPatientID.ValueMember = "PatientID";
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.hlangaLDB;
            // 
            // hlangaLDB
            // 
            this.hlangaLDB.DataSetName = "HlangaLDB";
            this.hlangaLDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chooose Patient ID:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 194);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.MonthlyAppointmentRevenue1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1910, 823);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGetFullReport);
            this.tabPage2.Controls.Add(this.cbAppointmentReport);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnGenerateReport);
            this.tabPage2.Controls.Add(this.crvAppReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1916, 1020);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sales Per Appointment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGetFullReport
            // 
            this.btnGetFullReport.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnGetFullReport.Location = new System.Drawing.Point(799, 19);
            this.btnGetFullReport.Name = "btnGetFullReport";
            this.btnGetFullReport.Size = new System.Drawing.Size(223, 48);
            this.btnGetFullReport.TabIndex = 4;
            this.btnGetFullReport.Text = "Get Full Report";
            this.btnGetFullReport.UseVisualStyleBackColor = true;
            this.btnGetFullReport.Click += new System.EventHandler(this.btnGetFullReport_Click);
            // 
            // cbAppointmentReport
            // 
            this.cbAppointmentReport.FormattingEnabled = true;
            this.cbAppointmentReport.Items.AddRange(new object[] {
            "Completed",
            "Scheduled",
            "Cancelled"});
            this.cbAppointmentReport.Location = new System.Drawing.Point(179, 27);
            this.cbAppointmentReport.Name = "cbAppointmentReport";
            this.cbAppointmentReport.Size = new System.Drawing.Size(221, 30);
            this.cbAppointmentReport.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Status:";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(423, 19);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(226, 48);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // crvAppReport
            // 
            this.crvAppReport.ActiveViewIndex = 0;
            this.crvAppReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvAppReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvAppReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvAppReport.Location = new System.Drawing.Point(3, 127);
            this.crvAppReport.Name = "crvAppReport";
            this.crvAppReport.ReportSource = this.AppointmentSalesReport1;
            this.crvAppReport.Size = new System.Drawing.Size(1910, 890);
            this.crvAppReport.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGenerateFullTR);
            this.tabPage3.Controls.Add(this.btnGenerateTR);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cbTreatmentType);
            this.tabPage3.Controls.Add(this.crvSalesPerTreatment);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1916, 1020);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sales Per Treatment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGenerateFullTR
            // 
            this.btnGenerateFullTR.Location = new System.Drawing.Point(801, 14);
            this.btnGenerateFullTR.Name = "btnGenerateFullTR";
            this.btnGenerateFullTR.Size = new System.Drawing.Size(256, 60);
            this.btnGenerateFullTR.TabIndex = 4;
            this.btnGenerateFullTR.Text = "Get Full Treatment Report";
            this.btnGenerateFullTR.UseVisualStyleBackColor = true;
            this.btnGenerateFullTR.Click += new System.EventHandler(this.btnGenerateFullTR_Click);
            // 
            // btnGenerateTR
            // 
            this.btnGenerateTR.Location = new System.Drawing.Point(478, 14);
            this.btnGenerateTR.Name = "btnGenerateTR";
            this.btnGenerateTR.Size = new System.Drawing.Size(256, 60);
            this.btnGenerateTR.TabIndex = 3;
            this.btnGenerateTR.Text = "Get Treatment Report";
            this.btnGenerateTR.UseVisualStyleBackColor = true;
            this.btnGenerateTR.Click += new System.EventHandler(this.btnGenerateTR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Treatment Type:";
            // 
            // cbTreatmentType
            // 
            this.cbTreatmentType.DataSource = this.treatmentLookupBindingSource2;
            this.cbTreatmentType.DisplayMember = "TreatmentID";
            this.cbTreatmentType.FormattingEnabled = true;
            this.cbTreatmentType.Location = new System.Drawing.Point(270, 20);
            this.cbTreatmentType.Name = "cbTreatmentType";
            this.cbTreatmentType.Size = new System.Drawing.Size(183, 30);
            this.cbTreatmentType.TabIndex = 1;
            this.cbTreatmentType.ValueMember = "TreatmentType";
            // 
            // treatmentLookupBindingSource1
            // 
            this.treatmentLookupBindingSource1.DataMember = "Treatment_Lookup";
            this.treatmentLookupBindingSource1.DataSource = this.ReportDS;
            // 
            // ReportDS
            // 
            this.ReportDS.DataSetName = "ColeIst3ckDataSet";
            this.ReportDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crvSalesPerTreatment
            // 
            this.crvSalesPerTreatment.ActiveViewIndex = 0;
            this.crvSalesPerTreatment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSalesPerTreatment.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSalesPerTreatment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvSalesPerTreatment.Location = new System.Drawing.Point(3, 126);
            this.crvSalesPerTreatment.Name = "crvSalesPerTreatment";
            this.crvSalesPerTreatment.ReportSource = this.SalePerTreatmentReport1;
            this.crvSalesPerTreatment.Size = new System.Drawing.Size(1910, 891);
            this.crvSalesPerTreatment.TabIndex = 0;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.ReportDS;
            // 
            // treatmnetLookupBindingSource
            // 
            this.treatmnetLookupBindingSource.DataMember = "Treatmnet_Lookup";
            this.treatmnetLookupBindingSource.DataSource = this.ReportDS;
            // 
            // appointmentTableAdapter1
            // 
            this.appointmentTableAdapter1.ClearBeforeFill = true;
            // 
            // treatmentTableAdapter1
            // 
            this.treatmentTableAdapter1.ClearBeforeFill = true;
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataMember = "Treatment";
            this.treatmentBindingSource.DataSource = this.ReportDS;
            // 
            // treatmnet_LookupTableAdapter
            // 
            this.treatmnet_LookupTableAdapter.ClearBeforeFill = true;
            // 
            // treatmentLookupBindingSource
            // 
            this.treatmentLookupBindingSource.DataMember = "Treatment_Lookup";
            this.treatmentLookupBindingSource.DataSource = this.ReportDS;
            // 
            // treatment_LookupTableAdapter
            // 
            this.treatment_LookupTableAdapter.ClearBeforeFill = true;
            // 
            // treatmnetLookupBindingSource1
            // 
            this.treatmnetLookupBindingSource1.DataMember = "Treatmnet_Lookup";
            this.treatmnetLookupBindingSource1.DataSource = this.ReportDS;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // treatmentLookupBindingSource2
            // 
            this.treatmentLookupBindingSource2.DataMember = "Treatment_Lookup";
            this.treatmentLookupBindingSource2.DataSource = this.hlangaLDB;
            // 
            // treatment_LookupTableAdapter1
            // 
            this.treatment_LookupTableAdapter1.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tabControl1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlangaLDB)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentLookupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmnetLookupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentLookupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmnetLookupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentLookupBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ColeIst3ckDataSet ReportDS;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MonthlyAppointmentRevenue MonthlyAppointmentRevenue1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvAppReport;
        private AppointmentSalesReport AppointmentSalesReport1;
        private System.Windows.Forms.ComboBox cbAppointmentReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ComboBox cbPatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetReport;
        private ColeIst3ckDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter1;
        private ColeIst3ckDataSetTableAdapters.TreatmentTableAdapter treatmentTableAdapter1;
        private ColeIst3ckDataSetTableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGetFullReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTreatmentType;
        private SalePerTreatmentReport SalePerTreatmentReport1;
        private System.Windows.Forms.Button btnGenerateFullTR;
        private System.Windows.Forms.Button btnGenerateTR;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private System.Windows.Forms.BindingSource treatmnetLookupBindingSource;
        private ColeIst3ckDataSetTableAdapters.Treatmnet_LookupTableAdapter treatmnet_LookupTableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalesPerTreatment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource treatmentLookupBindingSource;
        private ColeIst3ckDataSetTableAdapters.Treatment_LookupTableAdapter treatment_LookupTableAdapter;
        private System.Windows.Forms.BindingSource treatmnetLookupBindingSource1;
        private System.Windows.Forms.BindingSource treatmentLookupBindingSource1;
        private HlangaLDB hlangaLDB;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private HlangaLDBTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.BindingSource treatmentLookupBindingSource2;
        private HlangaLDBTableAdapters.Treatment_LookupTableAdapter treatment_LookupTableAdapter1;
    }
}