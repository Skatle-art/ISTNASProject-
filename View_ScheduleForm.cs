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
    public partial class View_ScheduleForm : Form
    {
        MainMenu _menu;
        public View_ScheduleForm(MainMenu menu)
        {
            InitializeComponent();
            _menu = menu;
        }
        private void View_ScheduleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hlangaLDB.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.hlangaLDB.Appointment);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            appointmentTableAdapter.FillBy(hlangaLDB.Appointment, monthCalendar2.SelectionRange.Start.ToString());    
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TrackerClass.PreviousForm.Name == "DentistForm")
                {
                    _menu.ShowDentistForm();
                    this.Close();
                }
                if(TrackerClass.PreviousForm.Name == "DentalAssistant")
                {
                    _menu.ShowDentalAssistantForm();
                    this.Close();
                }
                if (TrackerClass.PreviousForm.Name == "ReceptionistForm")
                {
                    _menu.ShowReceptionistForm();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }
    }
}
