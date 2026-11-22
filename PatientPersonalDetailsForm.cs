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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ISTNASProject
{
    public partial class PatientPersonalDetailsForm : Form
    {
        int previousRowIndex = -1;
        string Gender = "";
        MainMenu mainMenu;
        public PatientPersonalDetailsForm(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }
        private void PatientPersonalDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hlangaLDB.Patient2' table. You can move, or remove it, as needed.
            this.patient2TableAdapter.Fill(this.hlangaLDB.Patient2);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black; 
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            patient2TableAdapter.FillByEmail(hlangaLDB.Patient2 , textBox1.Text+'%' + '%' + '%' + '%' + '%' + '%' + '%' + '%');
        }
        private void button1_Click(object sender, EventArgs e)
        {    
            try
            {
                DataRowView drv = (DataRowView)dataGridView1.Rows[previousRowIndex].DataBoundItem;
                DataRow row = drv.Row;

                if (radioButton1.Checked)
                {
                    Gender = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    Gender = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    Gender = radioButton3.Text;
                }
                row[7] = textBox2.Text.Trim();
                row[8] = textBox3.Text.Trim();
                row[6] = textBox4.Text.Trim();
                row[10] = Gender;
                
                patient2TableAdapter.Update(hlangaLDB.Patient2);
                this.patient2TableAdapter.Fill(this.hlangaLDB.Patient2);
                MessageBox.Show("Successfully updated");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while updating patient record.",
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
                mainMenu.ShowReceptionistForm();
                this.Close();
            }
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
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MessageBox.Show("Clicked");
                previousRowIndex = e.RowIndex;
            }
        }
    }
}
