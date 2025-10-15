namespace MunicipalityApp
{
    partial class ViewIssuesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvIssues;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // --- Theme Colors and Fonts ---
            var primaryBlue = System.Drawing.Color.FromArgb(0, 30, 60);
            var accentGold = System.Drawing.Color.FromArgb(255, 215, 0);
            var lightTextColor = System.Drawing.Color.WhiteSmoke;
            var controlBackColor = System.Drawing.Color.FromArgb(0, 50, 100);
            var buttonFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            var gridFont = new System.Drawing.Font("Segoe UI", 9.5F);

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.dgvIssues = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).BeginInit();
            this.SuspendLayout();

            // --- Form Styling ---
            this.Text = "Submitted Issues";
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.BackColor = primaryBlue;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "ViewIssuesForm";

            // --- DataGridView (dgvIssues) Styling ---
            this.dgvIssues.AllowUserToAddRows = false;
            this.dgvIssues.AllowUserToDeleteRows = false;
            this.dgvIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIssues.BackgroundColor = controlBackColor;
            this.dgvIssues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIssues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = primaryBlue;
            dataGridViewCellStyle1.Font = buttonFont;
            dataGridViewCellStyle1.ForeColor = accentGold;
            dataGridViewCellStyle1.SelectionBackColor = primaryBlue;
            dataGridViewCellStyle1.SelectionForeColor = accentGold;
            this.dgvIssues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssues.EnableHeadersVisualStyles = false;
            this.dgvIssues.GridColor = primaryBlue;
            this.dgvIssues.Location = new System.Drawing.Point(20, 20);
            this.dgvIssues.Name = "dgvIssues";
            this.dgvIssues.ReadOnly = true;
            this.dgvIssues.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = controlBackColor;
            dataGridViewCellStyle2.Font = gridFont;
            dataGridViewCellStyle2.ForeColor = lightTextColor;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(0, 70, 140);
            dataGridViewCellStyle2.SelectionForeColor = lightTextColor;
            this.dgvIssues.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssues.RowTemplate.Height = 28;
            this.dgvIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssues.Size = new System.Drawing.Size(760, 400);

            // --- Close Button (btnClose) Styling ---
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Text = "Close";
            this.btnClose.Font = buttonFont;
            this.btnClose.Size = new System.Drawing.Size(150, 40);
            this.btnClose.Location = new System.Drawing.Point(630, 440);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.BackColor = controlBackColor;
            this.btnClose.ForeColor = lightTextColor;
            this.btnClose.FlatAppearance.BorderColor = accentGold;
            this.btnClose.FlatAppearance.BorderSize = 1;
            this.btnClose.Name = "btnClose";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // --- Add Controls to Form ---
            this.Controls.Add(this.dgvIssues);
            this.Controls.Add(this.btnClose);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).EndInit();
            this.ResumeLayout(false);
        }
    }
}