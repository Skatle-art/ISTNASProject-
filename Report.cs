using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISTNASProject
{
    public partial class Report : Form
    {
        string SelectedSatus;
        string SelectedValue;
        string SelectedTreatment;

        MainMenu mainMenu;
        public Report(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hlangaLDB.Treatment_Lookup' table. You can move, or remove it, as needed.
            this.treatment_LookupTableAdapter1.Fill(this.hlangaLDB.Treatment_Lookup);
            // TODO: This line of code loads data into the 'hlangaLDB.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hlangaLDB.Patient);
            try
            {   // TODO: This line of code loads data into the 'ReportDS.Treatment_Lookup' table. You can move, or remove it, as needed.
                this.treatment_LookupTableAdapter.Fill(this.ReportDS.Treatment_Lookup);
                //label4.Text = TrackerClass.loggedInUser;
                // TODO: This line of code loads data into the 'ReportDS.Treatmnet_Lookup' table. You can move, or remove it, as needed.
                this.treatmnet_LookupTableAdapter.Fill(this.ReportDS.Treatmnet_Lookup);
            }
            catch (Exception ex)
            {
                
            }
            patientTableAdapter1.Fill(ReportDS.Patient);
            treatmentTableAdapter1.Fill(ReportDS.Treatment);
            appointmentTableAdapter1.Fill(ReportDS.Appointment);
            //------------------------------------------------------------------------------------------->
            MonthlyAppointmentRevenue1.SetDataSource(ReportDS);
            SelectedValue = cbPatientID.Text;
            MonthlyAppointmentRevenue1.SetParameterValue("PatID", SelectedValue);
            crystalReportViewer1.ReportSource = MonthlyAppointmentRevenue1;
            crystalReportViewer1.Refresh();
            //------------------------------------------------------------------------------------------->
            AppointmentSalesReport1.SetDataSource(ReportDS);
            SelectedSatus = cbAppointmentReport.Text;
            AppointmentSalesReport1.SetParameterValue("AppStatus", SelectedSatus);
            AppointmentSalesReport1.SetParameterValue("GetRevenue", false);

            //------------------------------------------------------------------------------------------->
            SalePerTreatmentReport1.SetDataSource(ReportDS);
            SelectedTreatment = cbTreatmentType.Text;
            SalePerTreatmentReport1.SetParameterValue("Service", SelectedTreatment);
            //------------------------------------------------------------------------------------------->
            crystalReportViewer1.ReportSource = MonthlyAppointmentRevenue1;        
            crystalReportViewer1.Refresh();
            crvAppReport.Refresh();
            crvSalesPerTreatment.Refresh();


        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            //set parameter values for AppointmentSalesReport1
            AppointmentSalesReport1.SetDataSource(ReportDS);
            AppointmentSalesReport1.SetParameterValue("GetRevenue", false);
            SelectedSatus = cbAppointmentReport.Text;
            AppointmentSalesReport1.SetParameterValue("AppStatus", SelectedSatus);
            crvAppReport.ReportSource = AppointmentSalesReport1;
            crvAppReport.Refresh();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            MonthlyAppointmentRevenue1.SetDataSource(ReportDS);
            SelectedValue = cbPatientID.Text;
            MonthlyAppointmentRevenue1.SetParameterValue("PatID", SelectedValue);
            crystalReportViewer1.ReportSource = MonthlyAppointmentRevenue1;
            crystalReportViewer1.Refresh();
        }

        private void btnGetFullReport_Click(object sender, EventArgs e)
        {
            //show only scheduled and completed appointments and removed cancelled appointments filter

            AppointmentSalesReport1.SetDataSource(ReportDS);
            AppointmentSalesReport1.SetParameterValue("GetRevenue", true);
            AppointmentSalesReport1.SetParameterValue("AppStatus", new string[] { "Scheduled", "Completed" });
            crvAppReport.ReportSource = AppointmentSalesReport1;
            crvAppReport.Refresh();
            
        }

        private void btnGenerateTR_Click(object sender, EventArgs e)
        {
            SalePerTreatmentReport1.SetDataSource(ReportDS);
            SelectedTreatment = cbTreatmentType.Text;
            SalePerTreatmentReport1.SetParameterValue("Service", SelectedTreatment);
            crvSalesPerTreatment.ReportSource = SalePerTreatmentReport1;
            crvSalesPerTreatment.Refresh();
        }

        private void btnGenerateFullTR_Click(object sender, EventArgs e)
        {
            SalePerTreatmentReport1.SetDataSource(ReportDS);
            SelectedTreatment = cbTreatmentType.Text;
            SalePerTreatmentReport1.SetParameterValue("Service", "All");
            crvSalesPerTreatment.ReportSource = SalePerTreatmentReport1;
            crvSalesPerTreatment.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu.ShowDentistForm();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    
}
