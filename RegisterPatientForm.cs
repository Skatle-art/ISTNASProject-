
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISTNASProject;


namespace Registering_a_patient
{
     
    public partial class Form1 : Form
    {
        private ISTNASProject.MainMenu menu;
        public Form1(ISTNASProject.MainMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            dtpDOB.MinDate = DateTime.Today.AddYears(-110);
            dtpDOB.MaxDate = DateTime.Today.AddYears(-7);   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dob = dtpDOB.Value;
            try
            {
                if ((txtNumber.Text.StartsWith("06") || txtNumber.Text.StartsWith("07") || txtNumber.Text.StartsWith("08")) && (!string.IsNullOrWhiteSpace(txtNumber.Text)) &&
                   (txtNumber.Text.Length == 10))
                {   
                    if ((txtEmail.Text.Contains("@") && (!string.IsNullOrWhiteSpace(txtNumber.Text)) && (txtEmail.Text.EndsWith(".com"))))
                    {
                        
                            patientTableAdapter.InsertQuery(txtFirstName.Text, txtSurname.Text, txtNumber.Text, txtEmail.Text, "Active", dob);
                            this.patientTableAdapter.Fill(this.hlangaLDB.Patient);
                            MessageBox.Show("Patient " + txtFirstName.Text + " " + txtSurname.Text + " Has Been Added.");
                            txtFirstName.Clear();
                            txtSurname.Clear();
                            txtNumber.Clear();
                            txtEmail.Clear();  
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid email address!");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Enter a valid phone number!");
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while registering the patient.",
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.patientTableAdapter.FillByEmail(this.hlangaLDB.Patient,textBox1.Text+'%'+'%' + '%' + '%' + '%' + '%');
        }

        private void txtNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name Is Required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Surname Is Required");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email Adress Is Required");
                return;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (menu != null)
                {
                    menu.ShowReceptionistForm();
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
 
    

