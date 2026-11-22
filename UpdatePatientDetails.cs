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

namespace ISTNASProject
{
    public partial class UpdatePatientDetails : Form
    {
        private DataGridViewRow lastDoubleClickedRow,lastDoubleClickedRow2;
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        MainMenu _menu;
        public UpdatePatientDetails(MainMenu menu)
        {
            InitializeComponent();
            _menu = menu;
        }
        private void UpdatePatientDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hlangaLDB.Patient1' table. You can move, or remove it, as needed.
            this.patient1TableAdapter.Fill(this.hlangaLDB.Patient1);
            // TODO: This line of code loads data into the 'hlangaLDB.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hlangaLDB.Patient);
           
            originalFormSize = this.Size;
               
            foreach (Control c in this.Controls)
            {
                originalControlBounds[c] = c.Bounds;
            }
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            patient1TableAdapter.FillBy(hlangaLDB.Patient1, textBox1.Text+'%' + '%' + '%' + '%' + '%' + '%');
            patientTableAdapter.FillByEmail(hlangaLDB.Patient, textBox1.Text + '%' + '%' + '%' + '%' + '%' + '%');
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Cliked");
            if (e.RowIndex >= 0)
            {
                lastDoubleClickedRow = dataGridView1.Rows[e.RowIndex];
                PatientName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Surname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                PhoneNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Email.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                DOB.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {  
                if (lastDoubleClickedRow != null)
                {
                    DataRowView dataRowView = (DataRowView)lastDoubleClickedRow.DataBoundItem;
                    DataRow dataRow = dataRowView.Row;
                    dataRow[1] = PatientName.Text;
                    dataRow[2] = Surname.Text.Trim();
                    dataRow[3] = PhoneNo.Text;
                    dataRow[4] = Email.Text;
                    dataRow[5] = DOB.Text; 
                    this.patientTableAdapter.Update(this.hlangaLDB.Patient);
                    this.patientTableAdapter.Fill(this.hlangaLDB.Patient);
                    MessageBox.Show("Successfully updated");
                }     
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while updating patient details.",
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
            _menu.ShowReceptionistForm();
            this.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            patientTableAdapter.FillByEmail(hlangaLDB.Patient,textBox2.Text+'%'+'%' + '%' + '%' + '%' + '%' + '%' + '%');
        }
        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lastDoubleClickedRow2 = dataGridView2.Rows[e.RowIndex];
            MessageBox.Show("Row double cliked");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            _menu.ShowReceptionistForm();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            _menu.ShowReceptionistForm();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (lastDoubleClickedRow2 != null)
                {
                    DataRowView dataRowView = (DataRowView)lastDoubleClickedRow2.DataBoundItem;
                    DataRow dataRow = dataRowView.Row;
                    dataRow[9] = comboBox1.Text;
                    patientTableAdapter.Update(hlangaLDB.Patient);
                    patientTableAdapter.Fill(hlangaLDB.Patient);
                    textBox2.Clear();
                    MessageBox.Show("Patient status successfully updated");
                }
                else
                {
                    MessageBox.Show("Patient status update was unsuccessful");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while updating patient details.",
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

    }
}
