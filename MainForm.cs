using System;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeLogo();
        }

        private void InitializeLogo()
        {
            try
            {
                var logoPath = System.IO.Path.Combine(Application.StartupPath, "assets", "muncipality app.png");
                if (System.IO.File.Exists(logoPath))
                {
                    var logoImage = System.Drawing.Image.FromFile(logoPath);
                    this.Icon = System.Drawing.Icon.FromHandle(((System.Drawing.Bitmap)logoImage).GetHicon());
                }
            }
            catch (Exception)
            {
                // Log or handle error if needed
            }
        }

        private void btnReportIssue_Click(object? sender, EventArgs e)
        {
            this.Hide();
            using (var reportForm = new ReportIssueForm())
            {
                reportForm.ShowDialog();
            }
            this.Show();
        }

        private void btnLocalEvents_Click(object? sender, EventArgs e)
        {
            this.Hide();
            using (var eventsForm = new LocalEventsForm())
            {
                eventsForm.ShowDialog();
            }
            this.Show();
        }

        private void btnServiceStatus_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("This feature will come in the next update.");
        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
