using System;
using System.Windows.Forms;
using System.IO;

namespace MunicipalityApp
{
    public partial class ReportIssueForm : Form
    {
        private string attachedFilePath = "";

        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private void AttachFile(object? sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Media Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.mov;*.mp4|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                attachedFilePath = dialog.FileName;
                lblStatus.Text = "File Attached: " + Path.GetFileName(attachedFilePath);
                lblStatus.ForeColor = System.Drawing.Color.SkyBlue;
            }
        }

        private void SubmitIssue(object? sender, EventArgs e)
        {
            // --- Input Validation ---
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                lblStatus.Text = "Location is a required field.";
                lblStatus.ForeColor = System.Drawing.Color.OrangeRed;
                MessageBox.Show(lblStatus.Text, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                lblStatus.Text = "Category is a required field.";
                lblStatus.ForeColor = System.Drawing.Color.OrangeRed;
                MessageBox.Show(lblStatus.Text, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                lblStatus.Text = "Description is a required field.";
                lblStatus.ForeColor = System.Drawing.Color.OrangeRed;
                MessageBox.Show(lblStatus.Text, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbDescription.Focus();
                return;
            }

            var reportNumber = IssueDataStorage.AddIssue(txtLocation.Text, cmbCategory.Text, rtbDescription.Text, attachedFilePath);
            string successMessage = $"Issue reported successfully! Report Number: {reportNumber}";
            lblStatus.Text = successMessage;
            lblStatus.ForeColor = System.Drawing.Color.LightGreen;
            MessageBox.Show(successMessage, "Submission Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Clear the form for the next report
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbCategory.Text = "";
            rtbDescription.Clear();
            attachedFilePath = "";
        }
    }
}
