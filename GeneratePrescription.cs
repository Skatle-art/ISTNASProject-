using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISTNASProject
{
    public partial class GeneratePrescription : Form
    {
        MainMenu mainMenu;
        List<string> medications = new List<string>();
       
        string newItem = "";
        public GeneratePrescription(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void GeneratePrescription_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hlangaLDB.DataTable4' table. You can move, or remove it, as needed.
                this.dataTable4TableAdapter.Fill(this.hlangaLDB.DataTable4);
                StringCollection stored = Properties.Settings.Default.Medication;
                if (stored != null)
                {
                    medications = stored.Cast<string>().ToList();
                    comboBox1.Items.AddRange(medications.ToArray());
                }
                comboBox1.Items.AddRange(medications.ToArray());

                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {  
            dataTable4TableAdapter.FillByEmail(hlangaLDB.DataTable4, textBox1.Text + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%');
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(listBox1.SelectedItem.ToString(), out int quantity))
                {
                    MessageBox.Show("Quantity must be numeric.");
                    return;
                }
                string dateString = DateTime.Now.ToString("yyyy-MM-dd");
               
                prescription1TableAdapter1.InsertQuery(comboBox1.Text, DateTime.Now,textBox4.Text, textBox5.Text, Convert.ToInt32(listBox1.SelectedItem.ToString()), Convert.ToInt32(TreatmentId.Text));
                prescription1TableAdapter1.Update(this.hlangaLDB.Prescription1);
                prescription1TableAdapter1.Fill(this.hlangaLDB.Prescription1);
                dataTable5TableAdapter.FillByEmail(hlangaLDB.DataTable5, textBox1.Text + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%' + '%');
                PatientID.Text = "N/A";
                TreatmentId.Text = "N/A";
                PatientName.Text = "N/A";
                AppId.Text = "N/A";
                Description.Text = "N/A";
                comboBox1.Text = "";
                textBox2.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox1.Clear();
                MessageBox.Show("Prescription succefully generated")
;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while generating prescription",
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string search = textBox2.Text.ToLower();

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (comboBox1.Items[i].ToString().ToLower().StartsWith(search))
                {
                    comboBox1.SelectedIndex = i;
                    break;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string newItem = textBox3.Text?.Trim();
                if (string.IsNullOrWhiteSpace(newItem))
                {
                    MessageBox.Show("Enter a medication.");
                    return;
                }
                // Avoid duplicate in ComboBox
                if (!comboBox1.Items.Contains(newItem))
                    comboBox1.Items.Add(newItem);
                // Add to your in-memory list and save to user settings
                if (!medications.Contains(newItem))
                {
                    medications.Add(newItem);
                    if (Properties.Settings.Default.Medication == null)
                        Properties.Settings.Default.Medication = new StringCollection();

                    Properties.Settings.Default.Medication.Add(newItem);
                    Properties.Settings.Default.Save();

                    MessageBox.Show("medication added permanently!");
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("Medication already exists.");
                    textBox3.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            foreach (string med in medications)
            {
                if (!comboBox1.Items.Contains(med))
                {
                    comboBox1.Items.Add(med);
                }
            }
        }
        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Clicked");
            PatientID.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            TreatmentId.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            PatientName.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            AppId.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            Description.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString(); 
        }
    }
}
