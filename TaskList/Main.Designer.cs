namespace TaskList
{
    partial class Main 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ReportButton = new System.Windows.Forms.Button();
            this.TaskManagementButton = new System.Windows.Forms.Button();
            this.NewPlanButton = new System.Windows.Forms.Button();
            this.AboutusButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportButton
            // 
            this.ReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportButton.BackColor = System.Drawing.Color.Black;
            this.ReportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReportButton.Location = new System.Drawing.Point(20, 87);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(94, 24);
            this.ReportButton.TabIndex = 3;
            this.ReportButton.Text = "گزارش";
            this.ReportButton.UseVisualStyleBackColor = false;
            // 
            // TaskManagementButton
            // 
            this.TaskManagementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskManagementButton.BackColor = System.Drawing.Color.Black;
            this.TaskManagementButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TaskManagementButton.Location = new System.Drawing.Point(20, 57);
            this.TaskManagementButton.Name = "TaskManagementButton";
            this.TaskManagementButton.Size = new System.Drawing.Size(94, 24);
            this.TaskManagementButton.TabIndex = 2;
            this.TaskManagementButton.Text = "مدیریت کارها";
            this.TaskManagementButton.UseVisualStyleBackColor = false;
            this.TaskManagementButton.Click += new System.EventHandler(this.TaskManagementButton_Click);
            // 
            // NewPlanButton
            // 
            this.NewPlanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPlanButton.BackColor = System.Drawing.Color.Black;
            this.NewPlanButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewPlanButton.Location = new System.Drawing.Point(20, 27);
            this.NewPlanButton.Name = "NewPlanButton";
            this.NewPlanButton.Size = new System.Drawing.Size(94, 24);
            this.NewPlanButton.TabIndex = 1;
            this.NewPlanButton.Text = "برنامه جدید";
            this.NewPlanButton.UseVisualStyleBackColor = false;
            this.NewPlanButton.Click += new System.EventHandler(this.NewPlanButton_Click);
            // 
            // AboutusButton
            // 
            this.AboutusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutusButton.BackColor = System.Drawing.Color.Black;
            this.AboutusButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutusButton.Location = new System.Drawing.Point(20, 222);
            this.AboutusButton.Name = "AboutusButton";
            this.AboutusButton.Size = new System.Drawing.Size(94, 24);
            this.AboutusButton.TabIndex = 6;
            this.AboutusButton.Text = "درباره ما";
            this.AboutusButton.UseVisualStyleBackColor = false;
            this.AboutusButton.Click += new System.EventHandler(this.AboutusButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ReportButton);
            this.panel1.Controls.Add(this.TaskManagementButton);
            this.panel1.Controls.Add(this.NewPlanButton);
            this.panel1.Controls.Add(this.AboutusButton);
            this.panel1.Location = new System.Drawing.Point(739, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 267);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(84, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(648, 267);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(20, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 327);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button TaskManagementButton;
        private System.Windows.Forms.Button NewPlanButton;
        private System.Windows.Forms.Button AboutusButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

