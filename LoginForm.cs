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
    public partial class LoginForm : Form
    {
        private MainMenu _mainForm;
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        public LoginForm(MainMenu maiForm)
        {
            InitializeComponent();
            _mainForm = maiForm;
            this.Resize += LoginForm_Resize;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ResizeControls();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginPrompt loginPrompt = new LoginPrompt(_mainForm);
            loginPrompt.StartPosition = FormStartPosition.CenterScreen;
            loginPrompt.Show();
            loginButton.Enabled = false;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;

            foreach (Control c in this.Controls)
            {
                originalControlBounds[c] = c.Bounds;
            }  
        }
        private void LoginForm_Resize(object sender, EventArgs e)
        {
            ResizeControls();
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0)
                return;

            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            foreach (Control c in this.Controls)
            {
                Rectangle originalBounds = originalControlBounds[c];
                c.Left = (int)(originalBounds.Left * xRatio);
                c.Top = (int)(originalBounds.Top * yRatio);
                c.Width = (int)(originalBounds.Width * xRatio);
                c.Height = (int)(originalBounds.Height * yRatio);

                if (c is PictureBox picBox)
                {
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (c is Button btn)
                {
                    if (btn.Image != null)
                    {
                        btn.Image = new Bitmap(btn.Image, new Size(btn.Width, btn.Height));  
                    }
                }
            }
        }
        private void ResizeControls()
        {
            // Get the aspect ratio of the picture
            float aspectRatio = (float)pictureBox1.Image.Width / pictureBox1.Image.Height;

            // Calculate the new width and height for the PictureBox
            int newWidth = this.ClientSize.Width;
            int newHeight = (int)(newWidth / aspectRatio);

            // Ensure the height of the PictureBox doesn't exceed the form's height
            if (newHeight > this.ClientSize.Height)
            {
                newHeight = this.ClientSize.Height;
                newWidth = (int)(newHeight * aspectRatio);
            }

            // Set the PictureBox size
            pictureBox1.Size = new Size(newWidth, newHeight);

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // For example: 15% width, 8% height of the form
            loginButton.Width = (int)(formWidth * 0.22);
            loginButton.Height = (int)(formHeight * 0.40);

            // Ensure the button resizes horizontally while staying at the top
            loginButton.Location = new Point(1180, 300);
        }
    }
}
