using ISTNASProject.ColeIst3ckDataSetTableAdapters;
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
    public partial class Medical_RecordForm : Form
    {
        int patientID;
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        MainMenu _menu;
        string newItem = "";
       
        public Medical_RecordForm(MainMenu mainMenu)
        {
            InitializeComponent();
            _menu = mainMenu;
        }

        private void Medical_RecordForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hlangaLDB1.MedicalRecord' table. You can move, or remove it, as needed.
            this.medicalRecordTableAdapter.Fill(this.hlangaLDB1.MedicalRecord);
           
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            textBox4.ReadOnly = true;
           
            originalFormSize = this.Size;
            foreach (Control c in this.Controls)
            {
                originalControlBounds[c] = c.Bounds;
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Clicked");
            DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];
            int patientID = Convert.ToInt32(clickedRow.Cells[5].Value);
            textBox4.Text = patientID.ToString();
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Clicked");
            DataGridViewRow clickedRow = dataGridView2.Rows[e.RowIndex]; 
            patientID = Convert.ToInt32(clickedRow.Cells[0].Value);
            textBox4.Text = patientID.ToString();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            patientTableAdapter.FillByEmail(hlangaLDB.Patient, textBox5.Text + '%' + '%' + '%' + '%' + '%' + '%' + '%');
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentDate = DateTime.Now;
                medicalRecordTableAdapter.InsertQuery(Convert.ToInt32(textBox4.Text), textBox1.Text, textBox2.Text,currentDate);
                medicalRecordTableAdapter.Update(hlangaLDB.MedicalRecord);
                medicalRecordTableAdapter.Fill(hlangaLDB1.MedicalRecord);
                dataTable6TableAdapter.FillByEmail(hlangaLDB.DataTable6, textBox5.Text + '%' + '%' + '%' + '%' + '%' + '%' + '%');
                MessageBox.Show("Medical record generated successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while generating medical record.",
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
            if (TrackerClass.PreviousForm.Name == "DentalAssistant")
            {
                _menu.ShowDentalAssistantForm();
                this.Close();
            }
        }
    }
}
