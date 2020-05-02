using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{ 


    public partial class FormMain : Form
    {
        SettingProperties properties = new SettingProperties();

        public FormMain()
        {            
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Size = properties.FormSize;
            this.Location = properties.FormLocation;

        }

        private void ResetSettings_Button_Click(object sender, EventArgs e)
        {
            properties.Reset();
        }

        private void SaveSize_Button_Click(object sender, EventArgs e)
        {
            properties.FormSize = this.Size;
            properties.Save();
        }

        private void SaveLocation_Button_Click(object sender, EventArgs e)
        {
            properties.FormLocation = this.DesktopLocation;
            properties.Save();
        }

        private void FormMain_Deactivate(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void SmileNotify_MouseClick(object sender, MouseEventArgs e)
        {
            this.smileNotify.ShowBalloonTip(1);
            this.Show();
            this.Visible = true;
            this.Activate();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.NameListView.Items.Count > 1)
            {
                const string message =
               "Names were added. " +
               "Are you sure that you want to close the form?";
                const string caption = "COP Form Closing";

                //show messageBox with message
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the no button is pressed, cancel the closure of the form
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    this.Visible = true;
                    this.Activate();
                }

            }

        }

        private void AddName_Button_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                NameListView.Items.Add(NameTextBox.Text);
                NameTextBox.Text = "";
            }


        }

        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage;
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || NameTextBox.Text.Contains(" "))
            {
                errorMessage = "The textbox cannot be empty or contain non-space characters, write your name correctly!";
                e.Cancel = true;
                textBoxErrorProvider.SetError(NameTextBox, errorMessage);
            }
            else
            {
                e.Cancel = false;
                textBoxErrorProvider.SetError(NameTextBox, null);
            }
            if (NameTextBox.Text.Length > 15)
            {
                errorMessage = "Your name cannot be greather than 15 characters!";
                e.Cancel = true;
                textBoxErrorProvider.SetError(NameTextBox, errorMessage);
            }

        }
    }

    public class SettingProperties : Form
    {

        public Size FormSize
        {
            get { return Properties.Settings.Default.Size; }
            set { Properties.Settings.Default.Size = value; }
        }

        public Point FormLocation
        {
            get { return Properties.Settings.Default.DesktopLocation; }
            set { Properties.Settings.Default.DesktopLocation = value; }
        }   

        public void Save()
        {
            Properties.Settings.Default.Save();
        }

        public void Reset()
        {
            Properties.Settings.Default.Reset();
        }
    }
}

