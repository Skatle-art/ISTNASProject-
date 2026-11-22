using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registering_a_patient;

namespace ISTNASProject
{
    public partial class MainMenu : Form
    {
        public PictureBox mypictureBox => pictureBox1;
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        public MainMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
          
        }
        public void LoginSetup(Form myForm)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            LoginForm login = new LoginForm(this);
            login.MdiParent = this;
            login.WindowState = FormWindowState.Maximized;
           
            
            pictureBox1.Visible = false;
            login.Show();
            login.PerformLayout();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(this);
            LoginSetup(login);

            Form frm = (Form)Application.OpenForms["MainMenu"];
            if (frm != null)
            {
                MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
                if (ms != null)
                {
                    ToolStripItem loginItem = ms.Items["loginToolStripMenuItem"];
                    if (loginItem != null)
                    {
                        loginItem.Enabled = false;
                    }
                }
            }
        }

      
        public void Form1Setup(Form myForm)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
                pictureBox1.Visible = true;
            }
            

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult answer = MessageBox.Show("Are you sure you want to return to the main menu? Unsaved progress will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Form menu = new Form();
                toolStripTextBox1.Text = "";
                toolStripTextBox1.Visible = false;
                Form1Setup(menu);

                Form frm = (Form)Application.OpenForms["MainMenu"];
                if (frm != null)
                {
                    MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
                    if (ms != null)
                    {
                        ToolStripItem loginItem = ms.Items["loginToolStripMenuItem"];
                        if (loginItem != null)
                        {
                            loginItem.Enabled = true;
                        }
                    }
                }

            }
            else
            {
                // Do nothing if the user selects "No"
            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(this);
            LoginSetup(login);
            toolStripTextBox1.Text = "";
            toolStripTextBox1.Visible = false;
        }
        public void ShowReceptionistForm()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();

            ReceptionistForm receptionistInterface = new ReceptionistForm(this);
            receptionistInterface.MdiParent = this;
            receptionistInterface.StartPosition = FormStartPosition.Manual;
            receptionistInterface.FormBorderStyle = FormBorderStyle.None;
            receptionistInterface.WindowState = FormWindowState.Maximized;
            receptionistInterface.PerformLayout();
            receptionistInterface.Show();
        }

        public void ShowDentalAssistantForm()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();

            DentalAssistant dentalAssistantInterface = new DentalAssistant(this);
            dentalAssistantInterface.MdiParent = this;
            dentalAssistantInterface.StartPosition = FormStartPosition.Manual;
            dentalAssistantInterface.FormBorderStyle = FormBorderStyle.None;
            dentalAssistantInterface.WindowState = FormWindowState.Maximized;
            dentalAssistantInterface.PerformLayout();
            dentalAssistantInterface.Show();

        }
       
        public void ShowBookAppointmentForm()
        {
             foreach (Form child in this.MdiChildren)
               child.Close();

            Book_AppointmentForm book_AppointmentInterface = new Book_AppointmentForm(this);
            book_AppointmentInterface.MdiParent = this;
            book_AppointmentInterface.StartPosition = FormStartPosition.Manual;
            book_AppointmentInterface.FormBorderStyle = FormBorderStyle.None;
            book_AppointmentInterface.WindowState = FormWindowState.Maximized;
            book_AppointmentInterface.PerformLayout();
            book_AppointmentInterface.Show();

        }
        public void ShowRegisterPatientForm()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();

            Form1 RegisterPatientInterface = new Form1(this);
            RegisterPatientInterface.MdiParent = this;
            RegisterPatientInterface.StartPosition = FormStartPosition.Manual;
            RegisterPatientInterface.FormBorderStyle = FormBorderStyle.None;
            RegisterPatientInterface.WindowState = FormWindowState.Maximized;
            RegisterPatientInterface.PerformLayout();
            RegisterPatientInterface.Show();
        }
        public void ShowDentistForm()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();

            DentistForm DentistInterface = new DentistForm(this);
            DentistInterface.MdiParent = this;
            DentistInterface.StartPosition = FormStartPosition.Manual;
            DentistInterface.FormBorderStyle = FormBorderStyle.None;
            DentistInterface.WindowState = FormWindowState.Maximized;
            DentistInterface.PerformLayout();
            DentistInterface.Show();

        }
        public void ShowModifyScheduleForm()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();

            ModifyScheduleForm modifyScheduleInterface = new ModifyScheduleForm(this);
            modifyScheduleInterface.MdiParent = this;
            modifyScheduleInterface.StartPosition = FormStartPosition.Manual;
            modifyScheduleInterface.FormBorderStyle = FormBorderStyle.None;
            modifyScheduleInterface.WindowState = FormWindowState.Maximized;
            modifyScheduleInterface.PerformLayout();
            modifyScheduleInterface.Show();

        }
        public void ShowViewScheduleForm()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();

            View_ScheduleForm ViewScheduleInterface = new View_ScheduleForm(this);
            ViewScheduleInterface.MdiParent = this;
            ViewScheduleInterface.StartPosition = FormStartPosition.Manual;
            ViewScheduleInterface.FormBorderStyle = FormBorderStyle.None;
            ViewScheduleInterface.WindowState = FormWindowState.Maximized;
            ViewScheduleInterface.PerformLayout();
            ViewScheduleInterface.Show();

        }
        public void ShowPatientDetailsForm()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();

            PatientPersonalDetailsForm patientPersonalDetailsInterface = new PatientPersonalDetailsForm(this);
            patientPersonalDetailsInterface.MdiParent = this;
            patientPersonalDetailsInterface.StartPosition = FormStartPosition.Manual;
            patientPersonalDetailsInterface.FormBorderStyle = FormBorderStyle.None;
            patientPersonalDetailsInterface.WindowState = FormWindowState.Maximized;
            patientPersonalDetailsInterface.PerformLayout();
            patientPersonalDetailsInterface.Show();

        }
        public void ShowUpdatePatientDetailsForm()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();

            UpdatePatientDetails updatePatientPersonalDetailsInterface = new UpdatePatientDetails(this);
            updatePatientPersonalDetailsInterface.MdiParent = this;
            updatePatientPersonalDetailsInterface.StartPosition = FormStartPosition.Manual;
            updatePatientPersonalDetailsInterface.FormBorderStyle = FormBorderStyle.None;
            updatePatientPersonalDetailsInterface.WindowState = FormWindowState.Maximized;
            updatePatientPersonalDetailsInterface.PerformLayout();
            updatePatientPersonalDetailsInterface.Show();

        }
        public void ShowReport()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();

            Report report = new Report(this);
            report.MdiParent = this;
            report.StartPosition = FormStartPosition.Manual;
            report.FormBorderStyle = FormBorderStyle.None;
            report.WindowState = FormWindowState.Maximized;
            report.PerformLayout();
            report.Show();

        }
        public void ShowGeneratePrescriptionForm()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();

            GeneratePrescription generatePrescriptionInterface = new GeneratePrescription(this);
            generatePrescriptionInterface.MdiParent = this;
            generatePrescriptionInterface.StartPosition = FormStartPosition.Manual;
            generatePrescriptionInterface.FormBorderStyle = FormBorderStyle.None;
            generatePrescriptionInterface.WindowState = FormWindowState.Maximized;
            generatePrescriptionInterface.PerformLayout();
            generatePrescriptionInterface.Show();

        }
        public void ShowMedicalRecordForm()
        {
            foreach (Form child in this.MdiChildren)
                child.Close();

            Medical_RecordForm MedicalRecordInterface = new Medical_RecordForm(this);
            MedicalRecordInterface.MdiParent = this;
            MedicalRecordInterface.StartPosition = FormStartPosition.Manual;
            MedicalRecordInterface.FormBorderStyle = FormBorderStyle.None;
            MedicalRecordInterface.WindowState = FormWindowState.Maximized;
            MedicalRecordInterface.PerformLayout();
            MedicalRecordInterface.Show();

        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;

            foreach (Control c in this.Controls)
            {
                originalControlBounds[c] = c.Bounds;
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0)
                return;

            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            foreach (Control c in this.Controls)
            {
                Rectangle originalBounds = originalControlBounds[c];
                c.Left = (int)(originalBounds.Left * xRatio);
                c.Top = (int)(originalBounds.Top * yRatio);
                c.Width = (int)(originalBounds.Width * xRatio);
                c.Height = (int)(originalBounds.Height * yRatio);

                if (c is PictureBox picBox)
                {
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
