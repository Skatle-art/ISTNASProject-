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
    public partial class DentalAssistant : Form
    {
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        private Size originalFormSize;
        MainMenu _mainMenu;
        public DentalAssistant(MainMenu mainMenu)
        {
            InitializeComponent();
            this.Load += DentalAssistant_Load;
            _mainMenu = mainMenu;
            
        }

        private void DentalAssistant_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                    originalControlBounds[c] = c.Bounds;

            }   
        }
        private void DentalAssistant_Shown(object sender, EventArgs e)
        {
           // label1.Text = TrackerClass.loggedInUser;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TrackerClass.PreviousForm = this;
            _mainMenu.ShowViewScheduleForm();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TrackerClass.PreviousForm = this;
            _mainMenu.ShowModifyScheduleForm();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TrackerClass.PreviousForm = this;
            _mainMenu.ShowBookAppointmentForm();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            TrackerClass.PreviousForm = this;
            _mainMenu.ShowGeneratePrescriptionForm();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            TrackerClass.PreviousForm = this;
            _mainMenu.ShowPatientDetailsForm();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TrackerClass.PreviousForm = this;
            _mainMenu.ShowMedicalRecordForm();
            this.Close();
        }
    }
}
