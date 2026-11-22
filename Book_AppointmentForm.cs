using Registering_a_patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace ISTNASProject
{
    public partial class Book_AppointmentForm : Form
    {
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        private Size originalFormSize;
        MainMenu _main;
        List<string> values = new List<string>();
        public Book_AppointmentForm(MainMenu main)
        {
            InitializeComponent();
            _main = main;
        }

        private void Book_AppointmentForm_Load(object sender, EventArgs e)
        {     
            try
            { 
                this.dataTable1TableAdapter1.Fill(this.hlangaLDB.DataTable1);
                dataGridView3.Columns[4].Visible = false;
                dataGridView3.Columns[5].Visible = false;
                dataGridView3.Columns[6].Visible = false;
                monthCalendar1.MinDate = DateTime.Today;

                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView3.DefaultCellStyle.ForeColor = Color.Black;

                comboBox1.Enabled = false;

                originalFormSize = this.Size;
                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox)
                        originalControlBounds[c] = c.Bounds;
                }

                // TODO: This line of code loads data into the 'hlangaLDB.DataTable2' table. You can move, or remove it, as needed.
                this.dataTable2TableAdapter.Fill(this.hlangaLDB.DataTable2);
                // TODO: This line of code loads data into the 'hlangaLDB.Availabilit_Slot' table. You can move, or remove it, as needed.
                this.availabilit_SlotTableAdapter.Fill(this.hlangaLDB.Availabilit_Slot);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            patientTableAdapter1.FillByEmail(hlangaLDB.Patient, textBox2.Text + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%');
        }
        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            try
            {
                if (e.Start < DateTime.Today)
                {
                    MessageBox.Show("You cannot select a past date for an appointment.");
                }
                else
                {
                    availabilit_SlotTableAdapter.DeleteAllRowsQuery();

                    //List with appointment times                               
                    List<string> timeSlots = new List<string>
                    {
                       "08:00 - 08:30", "09:00 - 09:45", "10:00 - 11:00", "11:30 - 12:00"
                    };

                    dataTable1TableAdapter1.FillBy(hlangaLDB.DataTable1, monthCalendar1.SelectionRange.Start.ToString());
                    for (int i = 0; i < 4; ++i)
                    {
                        availabilit_SlotTableAdapter.InsertQuery(timeSlots.ElementAt(i).Trim());
                    }
                    comboBox2.DataSource = null;

                    availabilit_SlotTableAdapter.Fill(hlangaLDB.Availabilit_Slot);
                    comboBox2.DataSource = hlangaLDB.Availabilit_Slot;
                    comboBox2.DisplayMember = "Time";
                    comboBox2.ValueMember = "Time";
                    comboBox2.Refresh();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Check if the cell contains a value first
                            if (row.Cells[2].Value != null)
                            {
                                string timeID = row.Cells[2].Value.ToString().Trim();
                                availabilit_SlotTableAdapter.DeleteQuery(timeID.Trim());
                                comboBox2.DataSource = null;
                                availabilit_SlotTableAdapter.Fill(hlangaLDB.Availabilit_Slot);
                                comboBox2.DataSource = hlangaLDB.Availabilit_Slot;
                                comboBox2.DisplayMember = "Time";
                                comboBox2.ValueMember = "Time";
                            }
                        }
                    }
                    comboBox2.Refresh();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while updating appointment slots.",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter1.Fill(this.hlangaLDB.DataTable1);
                //picking appointment time
                string selectedTime = comboBox2.Text.Trim(); 

                if (selectedTime == "08:00 - 08:30")
                {
                    MessageBox.Show("Appointment Successfully Booked");
                    appointmentTableAdapter1.InsertQuery(Convert.ToInt32(PatientIdlabel.Text), monthCalendar1.SelectionStart, selectedTime.ToString().Trim(), "Scheduled", comboBox3.Text, DateTime.Today);

                    this.dataTable1TableAdapter1.Fill(this.hlangaLDB.DataTable1);
                    dataTable2TableAdapter.Fill(hlangaLDB.DataTable2);
                }
                else if (selectedTime == "09:00 - 09:45")
                {

                    MessageBox.Show("Appointment Successfully Booked");
                    appointmentTableAdapter1.InsertQuery(Convert.ToInt32(PatientIdlabel.Text), monthCalendar1.SelectionStart, selectedTime.ToString().Trim(), "Scheduled", comboBox3.Text, DateTime.Today);
                    dataTable1TableAdapter1.FillBy(hlangaLDB.DataTable1, monthCalendar1.SelectionRange.Start.ToString());
                    dataTable2TableAdapter.Fill(hlangaLDB.DataTable2);
                }
                else if (selectedTime == "11:30 - 12:00")
                {
                    MessageBox.Show("Appointment Successfully Booked");
                    appointmentTableAdapter1.InsertQuery(Convert.ToInt32(PatientIdlabel.Text), monthCalendar1.SelectionStart, selectedTime.ToString().Trim(), "Scheduled", comboBox3.Text, DateTime.Today);
                    this.dataTable1TableAdapter1.Fill(this.hlangaLDB.DataTable1);
                    dataTable2TableAdapter.Fill(hlangaLDB.DataTable2);
                }
                else if (selectedTime == "10:00 - 11:00")
                {
                    MessageBox.Show("Appointment Successfully Booked");
                    appointmentTableAdapter1.InsertQuery(Convert.ToInt32(PatientIdlabel.Text), monthCalendar1.SelectionStart, selectedTime.ToString().Trim(), "Scheduled", comboBox3.Text, DateTime.Today); dataTable1TableAdapter.FillByDate(coleIst3ckDataSet2.DataTable1, monthCalendar1.SelectionRange.Start.ToString());
                    dataTable1TableAdapter1.FillBy(hlangaLDB.DataTable1, monthCalendar1.SelectionRange.Start.ToString());
                    dataTable2TableAdapter.Fill(hlangaLDB.DataTable2);
                }
                else
                {
                    MessageBox.Show("You cannot book appointment");
                }
                DataView dv = new DataView(hlangaLDB.DataTable1);
                dv.Sort = "AppointmentID"; // Sorts appointment by recently added

                dataGridView1.DataSource = dv;

                //picking treatment code
                if (comboBox1.SelectedItem.ToString() == "Braces Installation")
                {
                    HandleTreatmentSelection("Braces", 1, "Braces Installation", 12000, "120 mins");
                }
                else if (comboBox1.SelectedItem.ToString() == "Extraction")
                {
                    HandleTreatmentSelection("Extraction", 2, "Extracting tooth", 800, "60 mins");
                }
                else if (comboBox1.SelectedItem.ToString() == "Cavity Filling(Single)")
                {
                    HandleTreatmentSelection("Cavity Filling(Single)", 1, "Repair a tooth damaged by decay", 700, "45 mins");
                }
                else if (comboBox1.SelectedItem.ToString() == "Root Canal Treatment")
                {
                    HandleTreatmentSelection("Root Canal Treatment", 2, "Cleaning the inside of a teeth", 2000, "120 mins");
                }
                else if (comboBox1.SelectedItem.ToString() == "Root Canal")
                {
                    HandleTreatmentSelection("Root Canal Treatment", 2, "Cleaning the inside of a teeth", 2000, "120 mins");
                }
                else if (comboBox1.SelectedItem.ToString() == "Teeth Whitening")
                {
                    HandleTreatmentSelection("Teeth Whitening", 1, "Lightening teeth, removing stains", 1500, "90 mins");
                }
                else if (comboBox1.SelectedItem.ToString() == "Crown Placement")
                {
                    HandleTreatmentSelection("Crown Placement", 1, "A crown fits over your entire tooth", 3000, "90 mins");
                }
                else if (comboBox1.SelectedItem.ToString() == "Denture Fitting")
                {
                    HandleTreatmentSelection("Denture Fitting", 1, "Placing new dentures in the mouth and check if they fit.", 2500, "60 mins");
                }
                else
                {
                    MessageBox.Show("an error occured");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while scheduling the appointment.",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
          private void button2_Click(object sender, EventArgs e)
          {
              if (TrackerClass.PreviousForm.Name == "ReceptionistForm")
              {
                  _main.ShowReceptionistForm();
                  this.Close();
              }
              if (TrackerClass.PreviousForm.Name == "DentalAssistant")
              {
                  _main.ShowDentalAssistantForm();
                  this.Close();
              }
          }
         private void comboBox2_DropDown_1(object sender, EventArgs e)
         {
            try
            {
                LoadColumnValues();
                foreach (string val in values)
                {
                    availabilit_SlotTableAdapter.DeleteQuery(val);
                }
                comboBox2.DataSource = null;
                availabilit_SlotTableAdapter.Fill(hlangaLDB.Availabilit_Slot);
                comboBox2.DataSource = hlangaLDB.Availabilit_Slot;
                comboBox2.DisplayMember = "Time";
                comboBox2.ValueMember = "Time";
                comboBox2.Refresh();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // Check if the cell contains a value first
                        if (row.Cells[2].Value != null)
                        {
                            string timeID = row.Cells[2].Value.ToString().Trim();
                            availabilit_SlotTableAdapter.DeleteQuery(timeID.Trim());
                            comboBox2.DataSource = null;
                            availabilit_SlotTableAdapter.Fill(hlangaLDB.Availabilit_Slot);
                            comboBox2.DataSource = hlangaLDB.Availabilit_Slot;
                            comboBox2.DisplayMember = "Time";
                            comboBox2.ValueMember = "Time";
                        }
                    }
                }
                comboBox2.Refresh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while trying to pick timeslot.",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

         }
        private void HandleTreatmentSelection(string treatmentName, int dentistId, string description, decimal cost, string duration)
        {
            try
            {
                int rowIndex = dataGridView1.Rows.Count - 1;
                // Exclude the empty row if adding new rows is enabled
                if (dataGridView1.AllowUserToAddRows)
                {
                    rowIndex--;
                }
                if (rowIndex >= 0)
                {
                    int appNo = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);
                    treatmentTableAdapter1.InsertQuery(treatmentName, description, cost.ToString(), duration, dentistId, appNo);
                    treatmentTableAdapter1.Update(hlangaLDB.Treatment);
                    treatmentTableAdapter1.Fill(hlangaLDB.Treatment);
                    MessageBox.Show($"Treatment '{treatmentName}' successfully picked\nAppointment No: {appNo}");
                    dataTable2TableAdapter.Fill(hlangaLDB.DataTable2);
                }
                else
                {
                    MessageBox.Show("No appointment records found.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while picking treatment.",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        private void LoadColumnValues()
        {
            // Replace with your actual connection string
            string connectionString = " Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HlangalezweDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False";
            string query = "SELECT Time FROM Availabilite_TimeSlots";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        values.Add(reader.GetString(0));

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "Treatment")
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
            }
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Clicked");
            FirstNameLabel.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            PatientIdlabel.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            SurnameLabel8.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            PatientPhoneNo.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
