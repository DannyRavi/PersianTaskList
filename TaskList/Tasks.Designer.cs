namespace TaskList
{
    partial class Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ImportanceLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.ImportanceComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ResetButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TitleLabel.Location = new System.Drawing.Point(274, 33);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(34, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "عنوان";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DateLabel.Location = new System.Drawing.Point(276, 72);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(32, 13);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "تاریخ";
            // 
            // ImportanceLabel
            // 
            this.ImportanceLabel.AutoSize = true;
            this.ImportanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.ImportanceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImportanceLabel.Location = new System.Drawing.Point(265, 119);
            this.ImportanceLabel.Name = "ImportanceLabel";
            this.ImportanceLabel.Size = new System.Drawing.Size(59, 13);
            this.ImportanceLabel.TabIndex = 2;
            this.ImportanceLabel.Text = "درجه اهمیت";
           
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(24, 30);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(228, 21);
            this.TitleTextBox.TabIndex = 3;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(24, 143);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(228, 67);
            this.DescriptionTextBox.TabIndex = 4;
            this.DescriptionTextBox.Text = "...";
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.RegistrationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistrationButton.Location = new System.Drawing.Point(36, 226);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(87, 23);
            this.RegistrationButton.TabIndex = 9;
            this.RegistrationButton.Text = "ثبت";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // ImportanceComboBox
            // 
            this.ImportanceComboBox.FormattingEnabled = true;
            this.ImportanceComboBox.Items.AddRange(new object[] {
            "ضروری",
            "خیلی مهم",
            "مهم",
            "عادی",
            "بی اهمیت"});
            this.ImportanceComboBox.Location = new System.Drawing.Point(24, 116);
            this.ImportanceComboBox.Name = "ImportanceComboBox";
            this.ImportanceComboBox.Size = new System.Drawing.Size(228, 21);
            this.ImportanceComboBox.TabIndex = 11;
            this.ImportanceComboBox.Text = "عادی";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DescriptionLabel.Location = new System.Drawing.Point(265, 146);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(48, 13);
            this.DescriptionLabel.TabIndex = 12;
            this.DescriptionLabel.Text = "شرح کار";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 21);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // ResetButton1
            // 
            this.ResetButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.ResetButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResetButton1.Location = new System.Drawing.Point(155, 226);
            this.ResetButton1.Name = "ResetButton1";
            this.ResetButton1.Size = new System.Drawing.Size(87, 23);
            this.ResetButton1.TabIndex = 15;
            this.ResetButton1.Text = "ریست";
            this.ResetButton1.UseVisualStyleBackColor = false;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.ResetButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ImportanceComboBox);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.ImportanceLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tasks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Tasks";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label ImportanceLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.ComboBox ImportanceComboBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ResetButton1;
    }
}