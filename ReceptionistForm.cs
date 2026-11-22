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
    public partial class ReceptionistForm : Form
    {
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        private Size originalFormSize;
        MainMenu _mainMenu;
        public ReceptionistForm(MainMenu mainMenu)
        {
            InitializeComponent();
            this.Load += ReceptionistForm_Load;
            _mainMenu = mainMenu;
        }
        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                    originalControlBounds[c] = c.Bounds;
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                TrackerClass.PreviousForm = this;
                _mainMenu.ShowBookAppointmentForm();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ReceptionistForm_Shown(object sender, EventArgs e)
        {
            //label1.Text = TrackerClass.loggedInUser;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _mainMenu.ShowRegisterPatientForm();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TrackerClass.PreviousForm = this;
            _mainMenu.ShowBookAppointmentForm();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TrackerClass.PreviousForm = this;
                _mainMenu.ShowPatientDetailsForm();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrackerClass.PreviousForm = this;
            _mainMenu.ShowUpdatePatientDetailsForm();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _mainMenu.ShowViewScheduleForm();
            this.Close();
        }
    }
}
