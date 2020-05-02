
﻿namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.smileNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.GroupBoxSettings = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SaveLocation_Button = new System.Windows.Forms.Button();
            this.ResetSettings_Button = new System.Windows.Forms.Button();
            this.SaveSize_Button = new System.Windows.Forms.Button();
            this.AddName_Button = new System.Windows.Forms.Button();
            this.NameListView = new System.Windows.Forms.ListView();
            this.textBoxErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // smileNotify
            // 
            this.smileNotify.BalloonTipText = "Click to view Assign2!";
            this.smileNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("smileNotify.Icon")));
            this.smileNotify.Text = "smileIcon";
            this.smileNotify.Visible = true;
            this.smileNotify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SmileNotify_MouseClick);
            this.smileNotify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SmileNotify_MouseClick);
            // 
            // GroupBoxSettings
            // 
            this.GroupBoxSettings.BackColor = System.Drawing.Color.SteelBlue;
            this.GroupBoxSettings.Controls.Add(this.NameTextBox);
            this.GroupBoxSettings.Controls.Add(this.SaveLocation_Button);
            this.GroupBoxSettings.Controls.Add(this.ResetSettings_Button);
            this.GroupBoxSettings.Controls.Add(this.SaveSize_Button);
            this.GroupBoxSettings.Controls.Add(this.AddName_Button);
            this.GroupBoxSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxSettings.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBoxSettings.Name = "GroupBoxSettings";
            this.GroupBoxSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBoxSettings.Size = new System.Drawing.Size(627, 144);
            this.GroupBoxSettings.TabIndex = 0;
            this.GroupBoxSettings.TabStop = false;
            this.GroupBoxSettings.Text = "GroupBox Settings";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTextBox.Location = new System.Drawing.Point(227, 33);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(361, 22);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
            // 
            // SaveLocation_Button
            // 
            this.SaveLocation_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveLocation_Button.Location = new System.Drawing.Point(465, 82);
            this.SaveLocation_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveLocation_Button.Name = "SaveLocation_Button";
            this.SaveLocation_Button.Size = new System.Drawing.Size(124, 30);
            this.SaveLocation_Button.TabIndex = 3;
            this.SaveLocation_Button.Text = "Save Location";
            this.SaveLocation_Button.UseVisualStyleBackColor = true;
            this.SaveLocation_Button.Click += new System.EventHandler(this.SaveLocation_Button_Click);
            // 
            // ResetSettings_Button
            // 
            this.ResetSettings_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResetSettings_Button.Location = new System.Drawing.Point(227, 82);
            this.ResetSettings_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetSettings_Button.Name = "ResetSettings_Button";
            this.ResetSettings_Button.Size = new System.Drawing.Size(91, 30);
            this.ResetSettings_Button.TabIndex = 2;
            this.ResetSettings_Button.Text = "Reset Settings";
            this.ResetSettings_Button.UseVisualStyleBackColor = true;
            this.ResetSettings_Button.Click += new System.EventHandler(this.ResetSettings_Button_Click);
            // 
            // SaveSize_Button
            // 
            this.SaveSize_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveSize_Button.Location = new System.Drawing.Point(12, 82);
            this.SaveSize_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveSize_Button.Name = "SaveSize_Button";
            this.SaveSize_Button.Size = new System.Drawing.Size(91, 30);
            this.SaveSize_Button.TabIndex = 1;
            this.SaveSize_Button.Text = "Save Size";
            this.SaveSize_Button.UseVisualStyleBackColor = true;
            this.SaveSize_Button.Click += new System.EventHandler(this.SaveSize_Button_Click);
            // 
            // AddName_Button
            // 
            this.AddName_Button.Location = new System.Drawing.Point(12, 33);
            this.AddName_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddName_Button.Name = "AddName_Button";
            this.AddName_Button.Size = new System.Drawing.Size(91, 30);
            this.AddName_Button.TabIndex = 0;
            this.AddName_Button.Text = "Add Name";
            this.AddName_Button.UseVisualStyleBackColor = true;
            this.AddName_Button.Click += new System.EventHandler(this.AddName_Button_Click);
            // 
            // NameListView
            // 
            this.NameListView.BackColor = System.Drawing.Color.PeachPuff;
            this.NameListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameListView.HideSelection = false;
            this.NameListView.Location = new System.Drawing.Point(0, 144);
            this.NameListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameListView.Name = "NameListView";
            this.NameListView.Size = new System.Drawing.Size(627, 223);
            this.NameListView.TabIndex = 1;
            this.NameListView.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxErrorProvider
            // 
            this.textBoxErrorProvider.ContainerControl = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(627, 367);
            this.Controls.Add(this.NameListView);
            this.Controls.Add(this.GroupBoxSettings);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "COP Form";
            this.Deactivate += new System.EventHandler(this.FormMain_Deactivate);

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing); 

            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GroupBoxSettings.ResumeLayout(false);
            this.GroupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon smileNotify;
        private System.Windows.Forms.GroupBox GroupBoxSettings;
        private System.Windows.Forms.Button SaveLocation_Button;
        private System.Windows.Forms.Button ResetSettings_Button;
        private System.Windows.Forms.Button SaveSize_Button;
        private System.Windows.Forms.Button AddName_Button;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListView NameListView;
        private System.Windows.Forms.ErrorProvider textBoxErrorProvider;
    }
}





