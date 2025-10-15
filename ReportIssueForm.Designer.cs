namespace MunicipalityApp
{
    partial class ReportIssueForm
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
            // --- Theme Colors and Fonts ---
            var primaryBlue = System.Drawing.Color.FromArgb(0, 30, 60); // Deep Navy Blue
            var accentGold = System.Drawing.Color.FromArgb(255, 215, 0); // Gold
            var lightTextColor = System.Drawing.Color.White;
            var controlBackColor = System.Drawing.Color.FromArgb(0, 50, 100); // Slightly Lighter Blue

            var labelFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            var inputFont = new System.Drawing.Font("Segoe UI", 9.5F);
            var buttonFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // --- Control Declarations ---
            System.Windows.Forms.Label lblLocation = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblCategory = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblDescription = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // --- Form Styling ---
            this.Text = "Report an Issue";
            this.Width = 550;
            this.Height = 600;
            this.BackColor = primaryBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "ReportIssueForm";

            // --- Control Initialization & Styling ---
            // lblLocation
            lblLocation.Text = "Location:";
            lblLocation.Top = 40;
            lblLocation.Left = 30;
            lblLocation.ForeColor = accentGold;
            lblLocation.Font = labelFont;
            lblLocation.AutoSize = true;

            // txtLocation
            this.txtLocation.Top = 40;
            this.txtLocation.Left = 150;
            this.txtLocation.Width = 350;
            this.txtLocation.BackColor = controlBackColor;
            this.txtLocation.ForeColor = lightTextColor;
            this.txtLocation.Font = inputFont;
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblCategory
            lblCategory.Text = "Category:";
            lblCategory.Top = 80;
            lblCategory.Left = 30;
            lblCategory.ForeColor = accentGold;
            lblCategory.Font = labelFont;
            lblCategory.AutoSize = true;

            // cmbCategory
            this.cmbCategory.Top = 80;
            this.cmbCategory.Left = 150;
            this.cmbCategory.Width = 350;
            this.cmbCategory.BackColor = controlBackColor;
            this.cmbCategory.ForeColor = lightTextColor;
            this.cmbCategory.Font = inputFont;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Items.AddRange(new string[] { "Water", "Electricity", "Roads", "Sanitation" });

            // lblDescription
            lblDescription.Text = "Description:";
            lblDescription.Top = 120;
            lblDescription.Left = 30;
            lblDescription.ForeColor = accentGold;
            lblDescription.Font = labelFont;
            lblDescription.AutoSize = true;

            // rtbDescription
            this.rtbDescription.Top = 150;
            this.rtbDescription.Left = 150;
            this.rtbDescription.Width = 350;
            this.rtbDescription.Height = 150;
            this.rtbDescription.BackColor = controlBackColor;
            this.rtbDescription.ForeColor = lightTextColor;
            this.rtbDescription.Font = inputFont;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnAttach
            this.btnAttach.Text = "Attach Media";
            this.btnAttach.Top = 320;
            this.btnAttach.Left = 150;
            this.btnAttach.Width = 165;
            this.btnAttach.Height = 40;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.BackColor = controlBackColor;
            this.btnAttach.ForeColor = lightTextColor;
            this.btnAttach.Font = buttonFont;
            this.btnAttach.FlatAppearance.BorderColor = accentGold;
            this.btnAttach.FlatAppearance.BorderSize = 1;
            this.btnAttach.Click += new System.EventHandler(this.AttachFile);

            // btnSubmit
            this.btnSubmit.Text = "Submit Issue";
            this.btnSubmit.Top = 380;
            this.btnSubmit.Left = 150;
            this.btnSubmit.Width = 165;
            this.btnSubmit.Height = 40;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.BackColor = accentGold;
            this.btnSubmit.ForeColor = primaryBlue;
            this.btnSubmit.Font = buttonFont;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Click += new System.EventHandler(this.SubmitIssue);

            // btnBack
            this.btnBack.Text = "Back";
            this.btnBack.Top = 380;
            this.btnBack.Left = 335;
            this.btnBack.Width = 165;
            this.btnBack.Height = 40;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.BackColor = controlBackColor;
            this.btnBack.ForeColor = lightTextColor;
            this.btnBack.Font = buttonFont;
            this.btnBack.FlatAppearance.BorderColor = accentGold;
            this.btnBack.FlatAppearance.BorderSize = 1;
            this.btnBack.Click += (s, e) => this.Close();

            // lblStatus
            this.lblStatus.Text = "";
            this.lblStatus.Top = 450;
            this.lblStatus.Left = 150;
            this.lblStatus.Width = 350;
            this.lblStatus.ForeColor = lightTextColor;
            this.lblStatus.Font = inputFont;

            // Add controls to form
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblLocation, this.txtLocation,
                lblCategory, this.cmbCategory,
                lblDescription, this.rtbDescription,
                this.btnAttach, this.btnSubmit, this.btnBack,
                this.lblStatus
            });
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStatus;
    }
}