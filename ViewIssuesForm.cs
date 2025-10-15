using System;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ViewIssuesForm : Form
    {
        public ViewIssuesForm()
        {
            InitializeComponent();
            LoadIssues();
        }

        private void LoadIssues()
        {
            var issues = IssueDataStorage.GetIssues().ToList();
            dgvIssues.DataSource = issues;

            // Improve column appearance
            if (dgvIssues.Columns["FilePath"] != null)
            {
                dgvIssues.Columns["FilePath"].HeaderText = "Attached File";
            }
            if (dgvIssues.Columns["Status"] != null)
            {
                dgvIssues.Columns["Status"].HeaderText = "Request Status";
            }
            if (dgvIssues.Columns["SubmittedAt"] != null)
            {
                dgvIssues.Columns["SubmittedAt"].HeaderText = "Submitted Date";
            }
            dgvIssues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}