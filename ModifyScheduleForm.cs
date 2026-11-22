using ISTNASProject.ColeIst3ckDataSetTableAdapters;
using Registering_a_patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISTNASProject
{
    public partial class ModifyScheduleForm : Form
    {
        int previousRowIndex = 1;
        List<string> values = new List<string>();
        private DataGridViewRow lastClickedRow;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        private Size originalFormSize;
        MainMenu mainMenu;
        public ModifyScheduleForm(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }
        private void ModifyScheduleForm_Load(object sender, EventArgs e)
        {
            try
            {
                
                this.dataTable3TableAdapter.Fill(this.hlangaLDB.DataTable3);
                this.appointmentTableAdapter.Fill(this.hlangaLDB.Appointment);
                this.dataTable1TableAdapter.Fill(this.hlangaLDB.DataTable1);
                this.availabilite_TimeSlotsTableAdapter.Fill(this.hlangaLDB.Availabilite_TimeSlots);
                monthCalendar1.MinDate = DateTime.Today;
                monthCalendar2.MinDate = DateTime.Today;
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView3.ShowRowErrors = false;
                dataGridView3.ShowCellErrors = false;
                comboBox3.Enabled = false;
                originalFormSize = this.Size;
                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox)
                        originalControlBounds[c] = c.Bounds;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {     
            try
            {
                List<object> uncheckedItems = new List<object>();
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (!checkedListBox1.GetItemChecked(i)) 
                    {
                        uncheckedItems.Add(checkedListBox1.Items[i]);
                    }
                }
                foreach (var uncheckedItem in uncheckedItems)
                {  
                    string selectedName = uncheckedItem.ToString().Trim();
                    availabilite_TimeSlotsTableAdapter.DeleteQuery(selectedName);     
                }  
                this.availabilite_TimeSlotsTableAdapter.Fill(this.hlangaLDB.Availabilite_TimeSlots);
                dataGridView1.Refresh();
                MessageBox.Show("Selected times successfully Removed from schedule.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while removing time slots.","Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to Reset all availability times?",
                    "Confirm Reset",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (confirm != DialogResult.Yes)
                    return;
                
                availabilite_TimeSlotsTableAdapter.DeleteAllRowsQuery();
                foreach (var item in checkedListBox1.Items) 
                {
                    string valueToInsert = item.ToString().Trim();
                    availabilite_TimeSlotsTableAdapter.InsertQuery(valueToInsert);
                }
                this.availabilite_TimeSlotsTableAdapter.Fill(this.hlangaLDB.Availabilite_TimeSlots);
                values.Clear();
                MessageBox.Show("All availability times Reset");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }  
        }
        private void button2_Click(object sender, EventArgs e)
        { 
            try
            {
                if (TrackerClass.PreviousForm.Name == "DentistForm")
                {
                    mainMenu.ShowDentistForm();
                    this.Close();
                }
                if (TrackerClass.PreviousForm.Name == "DentalAssistant")
                {  
                    mainMenu.ShowDentalAssistantForm();
                    this.Close();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (e.Start < DateTime.Today)
            {
                MessageBox.Show("You cannot select a past date for an appointment.");
            }
            // dataTable6TableAdapter1.FillByDate(coleIst3ckDataSet1.DataTable6, monthCalendar1.SelectionRange.Start.ToString());
            appointmentTableAdapter.FillBy(hlangaLDB.Appointment, monthCalendar1.SelectionRange.Start.ToString());
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*lastClickedRow = dataGridView2.Rows[e.RowIndex];
            MessageBox.Show("Clicked");*/
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to Cancel Appointment?",
                    "Confirm Cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (confirm == DialogResult.Yes)
                {
                    DataRowView dataRowView = (DataRowView)lastClickedRow.DataBoundItem;
                    int appId = Convert.ToInt32(dataRowView[0]); // use the real PK column name
                    appointmentTableAdapter.Fill(hlangaLDB.Appointment);
                    appointmentTableAdapter.Fill(hlangaLDB.Appointment);
                    DataRow[] rows = hlangaLDB.Appointment.Select("AppointmentID = " + appId);
                    if (rows.Length > 0)
                    {
                        DataRow appointmentRow = rows[0];
                        appointmentRow["AppointmentStatus"] = "Cancelled";
                        appointmentTableAdapter.Update(hlangaLDB.Appointment);
                        this.appointmentTableAdapter.Fill(this.hlangaLDB.Appointment);
                        MessageBox.Show("Appointment successfully cancelled!");
                    }
                    else
                    {
                        MessageBox.Show("Could not find appointment record.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (e.Start < DateTime.Today)
            {
                MessageBox.Show("You cannot select a past date for an appointment.");
            }
            appointmentTableAdapter.FillBy(hlangaLDB.Appointment, monthCalendar2.SelectionRange.Start.ToString());
            availabilit_SlotTableAdapter1.DeleteAllRowsQuery();
            List<string> timeSlots = new List<string>
            {
                "08:00 - 08:30", "09:00 - 09:45", "10:00 - 11:00", "11:30 - 12:00"
            };
            try
            {   
                for (int i = 0; i < 4; ++i)
                {
                    availabilit_SlotTableAdapter1.InsertQuery(timeSlots.ElementAt(i).Trim());
                }
                comboBox2.DataSource = null;
                availabilit_SlotTableAdapter1.Fill(hlangaLDB.Availabilit_Slot);
                comboBox2.DataSource = hlangaLDB.Availabilit_Slot;
                comboBox2.DisplayMember = "Time";
                comboBox2.ValueMember = "Time";
                comboBox2.Refresh();

                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // Check if the cell contains a value first
                        if (row.Cells[3].Value != null)
                        {
                            string timeID = row.Cells[3].Value.ToString().Trim();
                            availabilit_SlotTableAdapter1.DeleteQuery(timeID.Trim());

                            comboBox2.DataSource = null;
                            availabilit_SlotTableAdapter1.Fill(hlangaLDB.Availabilit_Slot);
                            comboBox2.DataSource = hlangaLDB.Availabilit_Slot;
                            comboBox2.DisplayMember = "Time";
                            comboBox2.ValueMember = "Time";
                        }
                    }
                }
                comboBox2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                previousRowIndex = e.RowIndex;    
            }
        }
        private void dataGridView4_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                previousRowIndex = e.RowIndex;  
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int appointmentId = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
                string connectionString = " Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HlangalezweDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            //Update Appointment details
                            string queryAppointment = @"UPDATE Appointment 
                                                SET AppointmentDate=@date, AppointmentTime=@time, VisitReason=@reason
                                                WHERE AppointmentID=@id";
                            using (SqlCommand cmd1 = new SqlCommand(queryAppointment, conn, transaction))
                            {
                                cmd1.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                                cmd1.Parameters.AddWithValue("@time", comboBox2.Text);
                                cmd1.Parameters.AddWithValue("@reason", comboBox1.Text);
                                cmd1.Parameters.AddWithValue("@id", appointmentId);  
                                cmd1.ExecuteNonQuery();
                            }
                            //Check if Treatment exists for this appointment
                            string checkTreatment = "SELECT TreatmentID FROM Treatment WHERE AppointmentID=@appId";
                            SqlCommand checkCmd = new SqlCommand(checkTreatment, conn, transaction);
                            checkCmd.Parameters.AddWithValue("@appId", appointmentId);

                            object result = checkCmd.ExecuteScalar();

                            //If "No Treatment" or empty , delete if exists
                            if (string.IsNullOrWhiteSpace(comboBox3.Text) || comboBox3.Text == "No Treatment")
                            {
                                if (result != null && result != DBNull.Value)
                                {
                                    int treatmentId = Convert.ToInt32(result);

                                    string deleteTreatment = "DELETE FROM Treatment WHERE TreatmentID=@tid";
                                    SqlCommand delCmd = new SqlCommand(deleteTreatment, conn, transaction);
                                    delCmd.Parameters.AddWithValue("@tid", treatmentId);
                                    delCmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // If treatment given, update if exists, else insert
                                if (result != null && result != DBNull.Value)
                                {
                                    int treatmentId = Convert.ToInt32(result);
                                    string updateTreatment = @"UPDATE Treatment 
                                                       SET treatmentType=@treatment 
                                                       WHERE TreatmentID=@tid";
                                    SqlCommand cmd2 = new SqlCommand(updateTreatment, conn, transaction);
                                    cmd2.Parameters.AddWithValue("@treatment", comboBox3.Text);
                                    cmd2.Parameters.AddWithValue("@tid", treatmentId);
                                    cmd2.ExecuteNonQuery();
                                }
                                else
                                {
                                    string insertTreatment = @"INSERT INTO Treatment (AppointmentID, treatmentType) 
                                                               VALUES (@appId, @treatment)";
                                    SqlCommand cmd2 = new SqlCommand(insertTreatment, conn, transaction);
                                    cmd2.Parameters.AddWithValue("@appId", appointmentId);
                                    cmd2.Parameters.AddWithValue("@treatment", comboBox3.Text);
                                    cmd2.ExecuteNonQuery();
                                }
                            }
                            transaction.Commit();
                            MessageBox.Show("Update successful!");
                        }
                        catch (Exception ex2)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error updating appointment: " + ex2.Message);
                        }
                        appointmentTableAdapter.Fill(hlangaLDB.Appointment);
                        treatmentTableAdapter1.Fill(hlangaLDB.Treatment);
                       dataTable3TableAdapter.Fill(hlangaLDB.DataTable3);
                        comboBox2.Text = "";
                        comboBox1.Text = "";
                        comboBox3.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
        }
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            try
            {
                LoadColumnValues();
                foreach (string val in values)
                {
                    availabilit_SlotTableAdapter1.DeleteQuery(val);
                }
                comboBox2.DataSource = null;
                availabilit_SlotTableAdapter1.Fill(hlangaLDB.Availabilit_Slot);
                comboBox2.DataSource = hlangaLDB.Availabilit_Slot;
                comboBox2.DisplayMember = "Time";
                comboBox2.ValueMember = "Time";
                comboBox2.Refresh();

                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[3].Value != null)
                        {
                            string timeID = row.Cells[3].Value.ToString().Trim();
                            availabilit_SlotTableAdapter1.DeleteQuery(timeID.Trim());
                            comboBox2.DataSource = null;
                            availabilit_SlotTableAdapter1.Fill(hlangaLDB.Availabilit_Slot);
                            comboBox2.DataSource = hlangaLDB.Availabilit_Slot;
                            comboBox2.DisplayMember = "Time";
                            comboBox2.ValueMember = "Time";
                        }
                    }
                }
                comboBox2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadColumnValues()
        {
            string connectionString = "Data Source=146.230.177.46;Initial Catalog=WstGrp18;Persist Security Info=True;User ID=WstGrp18;Password=ftfss;Encrypt=True;TrustServerCertificate=True";
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
        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView3.Columns[e.ColumnIndex].Name == "treatmentType")
            {
                if (e.Value == DBNull.Value || e.Value == null)
                {
                    e.Value = "No Treatment";
                    e.FormattingApplied = true;
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Treatment")
            {
                comboBox3.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (TrackerClass.PreviousForm.Name == "DentistForm")
                {
                    mainMenu.ShowDentistForm();
                    this.Close();
                }
                if (TrackerClass.PreviousForm.Name == "DentalAssistant")
                {
                    mainMenu.ShowDentalAssistantForm();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (TrackerClass.PreviousForm.Name == "DentistForm")
                {
                    mainMenu.ShowDentistForm();
                    this.Close();
                }
                if (TrackerClass.PreviousForm.Name == "DentalAssistant")
                {
                    mainMenu.ShowDentalAssistantForm();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* lastClickedRow = dataGridView4.Rows[e.RowIndex];
            MessageBox.Show("Clicked");*/
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            lastClickedRow = dataGridView2.Rows[e.RowIndex];
            MessageBox.Show("Clicked");
        }
    }
}
