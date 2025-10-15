
namespace MunicipalityApp
{
    partial class MainForm : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // 🎨 Modern Blue-Green Theme Colors
            var primaryBlue = System.Drawing.Color.FromArgb(26, 77, 122);      // Deep blue
            var accentGreen = System.Drawing.Color.FromArgb(0, 196, 154);      // Main green
            var buttonBlue = System.Drawing.Color.FromArgb(46, 139, 192);      // Soft sky blue
            var hoverGreen = System.Drawing.Color.FromArgb(0, 230, 180);       // Light mint hover
            var hoverBlue = System.Drawing.Color.FromArgb(72, 160, 210);       // Light blue hover
            var lightTextColor = System.Drawing.Color.White;
            var titleFont = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            var buttonFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            // Controls
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReportIssue = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();

            // 🌆 Form Styling
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#3e8ede");
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Text = "Municipality Services Portal";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "MainForm";

            // 🏙️ Title Label
            this.lblTitle.Text = "Services Portal";
            this.lblTitle.Font = titleFont;
            this.lblTitle.ForeColor = accentGreen;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Location = new System.Drawing.Point(175, 75);

            // 🧾 Report Issue Button (Green)
            this.btnReportIssue.Text = "Report ";
            this.btnReportIssue.Font = buttonFont;
            this.btnReportIssue.Size = new System.Drawing.Size(250, 60);
            this.btnReportIssue.Location = new System.Drawing.Point(175, 130);
            this.btnReportIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssue.BackColor = accentGreen;
            this.btnReportIssue.ForeColor = primaryBlue;
            this.btnReportIssue.FlatAppearance.BorderSize = 0;
            this.btnReportIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportIssue.Name = "btnReportIssue";
            this.btnReportIssue.Click += new System.EventHandler(this.btnReportIssue_Click);

            // 🎉 Local Events Button (Blue)
            this.btnLocalEvents.Text = " Events";
            this.btnLocalEvents.Font = buttonFont;
            this.btnLocalEvents.Size = new System.Drawing.Size(250, 60);
            this.btnLocalEvents.Location = new System.Drawing.Point(175, 200);
            this.btnLocalEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEvents.BackColor = accentGreen;
            this.btnLocalEvents.ForeColor = primaryBlue;
            //this.btnLocalEvents.FlatAppearance.BorderColor = accentGreen;
            this.btnLocalEvents.FlatAppearance.BorderSize = 0;
            this.btnLocalEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click);

            // 📊 Service Status Button (Blue)
            this.btnServiceStatus.Text = " Request Update";
            this.btnServiceStatus.Font = buttonFont;
            this.btnServiceStatus.Size = new System.Drawing.Size(250, 60);
            this.btnServiceStatus.Location = new System.Drawing.Point(175, 270);
            this.btnServiceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceStatus.BackColor = accentGreen;
            this.btnServiceStatus.ForeColor = primaryBlue;
            this.btnServiceStatus.FlatAppearance.BorderColor = accentGreen;
            this.btnServiceStatus.FlatAppearance.BorderSize = 0;
            this.btnServiceStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Click += new System.EventHandler(this.btnServiceStatus_Click);

            // 🚪 Exit Button (Blue)
            this.btnExit.Text = "Exit";
            this.btnExit.Font = buttonFont;
            this.btnExit.Size = new System.Drawing.Size(250, 60);
            this.btnExit.Location = new System.Drawing.Point(175, 340);
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.BackColor = accentGreen;
            this.btnExit.ForeColor = primaryBlue;
            this.btnExit.FlatAppearance.BorderColor = accentGreen;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 🖼️ Logo PictureBox
            this.pbLogo.Location = new System.Drawing.Point(225, 10);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 75);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // ✨ Hover Effects with Cursor
            this.btnReportIssue.MouseEnter += (s, e) => this.btnReportIssue.BackColor = hoverGreen;
            this.btnReportIssue.MouseLeave += (s, e) => this.btnReportIssue.BackColor = accentGreen;

            this.btnLocalEvents.MouseEnter += (s, e) => this.btnLocalEvents.BackColor = hoverGreen;
            this.btnLocalEvents.MouseLeave += (s, e) => this.btnLocalEvents.BackColor = accentGreen;

            this.btnServiceStatus.MouseEnter += (s, e) => this.btnServiceStatus.BackColor = hoverGreen;
            this.btnServiceStatus.MouseLeave += (s, e) => this.btnServiceStatus.BackColor = accentGreen;

            this.btnExit.MouseEnter += (s, e) => this.btnExit.BackColor = hoverGreen;
            this.btnExit.MouseLeave += (s, e) => this.btnExit.BackColor = accentGreen;

            // Add Controls to Form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReportIssue);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnServiceStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbLogo);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReportIssue;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

