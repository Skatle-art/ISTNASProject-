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
    public partial class LoginPrompt : Form
    {
        private MainMenu _mainForm;
        public LoginPrompt(MainMenu mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox1.Text.Trim();
            string enteredPassword = textBox2.Text.Trim();

            var loginAdapter = new HlangaLDBTableAdapters.UsersTableAdapter();
            var receptionistTable = loginAdapter.GetDataByReceptionist();
            var assistantTable = loginAdapter.GetDataByDentalAssistant();
            var dentistTable = loginAdapter.GetDataByDentist();

            // Merge all users (ensure: using System.Linq;)
            var allUsers = receptionistTable.Cast<HlangaLDB.UsersRow>()
                .Concat(assistantTable.Cast<HlangaLDB.UsersRow>())
                .Concat(dentistTable.Cast<HlangaLDB.UsersRow>())
                .ToList();

            bool usernameExists = allUsers.Any(u =>
                string.Equals(u.UserName?.Trim(), enteredUsername, StringComparison.OrdinalIgnoreCase));

            bool passwordExists = allUsers.Any(u =>
                string.Equals(u.Password?.Trim(), enteredPassword, StringComparison.Ordinal));

            // Exact match for this username + password
            var matchedUser = allUsers.FirstOrDefault(u =>
                string.Equals(u.UserName?.Trim(), enteredUsername, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(u.Password?.Trim(), enteredPassword, StringComparison.Ordinal));

            if (matchedUser == null)
            {
                // Show precise reason
                if (!usernameExists && !passwordExists)
                    MessageBox.Show("Invalid username and password.");
                else if (!usernameExists && passwordExists)
                    MessageBox.Show("Invalid username.");
                else if (usernameExists && !passwordExists)
                    MessageBox.Show("Invalid password.");
                else
                    MessageBox.Show("Username and password do not match."); // <-- both exist but not as a pair

                return;
            }

            // Successful login -> route by role (check with both just to be safe)
            if (receptionistTable.Any(r =>
                string.Equals(r.UserName?.Trim(), enteredUsername, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(r.Password?.Trim(), enteredPassword, StringComparison.Ordinal)))
            {
                _mainForm.ShowReceptionistForm();
                TrackerClass.loggedInUser = "Receptionist: Lethokuhle";
                _mainForm.toolStripTextBox1.Visible = true;
                _mainForm.toolStripTextBox1.ForeColor = Color.Green;
                _mainForm.toolStripTextBox1.Text = TrackerClass.loggedInUser;
                MessageBox.Show("Login was successful");
                this.Close();
                return;
            }

            if (assistantTable.Any(r =>
                string.Equals(r.UserName?.Trim(), enteredUsername, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(r.Password?.Trim(), enteredPassword, StringComparison.Ordinal)))
            {
                _mainForm.ShowDentalAssistantForm();
                TrackerClass.loggedInUser = "Dental Assistant: Asithandile";
                _mainForm.toolStripTextBox1.Visible = true;
                _mainForm.toolStripTextBox1.ForeColor = Color.Green;
                _mainForm.toolStripTextBox1.Text = TrackerClass.loggedInUser;
                MessageBox.Show("Login was successful");
                this.Close();
                return;
            }

            if (dentistTable.Any(r =>
                string.Equals(r.UserName?.Trim(), enteredUsername, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(r.Password?.Trim(), enteredPassword, StringComparison.Ordinal)))
            {
                _mainForm.ShowDentistForm();
                TrackerClass.loggedInUser = "Dentist: Prince ";
                _mainForm.toolStripTextBox1.Visible = true;
                _mainForm.toolStripTextBox1.ForeColor = Color.Green;
                _mainForm.toolStripTextBox1.Text = TrackerClass.loggedInUser;
                MessageBox.Show("Login was successful");
                this.Close();
                return;
            }

            // Fallback (shouldn't hit if data is consistent)
            MessageBox.Show("Login matched, but role could not be determined.");


        }
        private void LoginPrompt_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            btnHide.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
           textBox2.UseSystemPasswordChar=false; 
            btnShow.Visible = false;
            btnHide.Visible = true;
   
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            btnShow.Visible = true;
            btnHide.Visible = false;

        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }
    }
}
