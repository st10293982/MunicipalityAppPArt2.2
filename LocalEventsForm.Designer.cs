namespace MunicipalityApp
{
    partial class LocalEventsForm
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
            // Theme Colors and Fonts
            var primaryBlue = System.Drawing.Color.FromArgb(0, 30, 60);
            var accentGold = System.Drawing.Color.FromArgb(255, 215, 0);
            var lightTextColor = System.Drawing.Color.WhiteSmoke;
            var controlBackColor = System.Drawing.Color.FromArgb(0, 50, 100);
            var titleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            var buttonFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            var labelFont = new System.Drawing.Font("Segoe UI", 9.5F);

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.recPanel = new System.Windows.Forms.Panel();
            this.lblRec = new System.Windows.Forms.Label();
            this.lstRecommendations = new System.Windows.Forms.ListBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.searchTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.recPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();

            // Form Styling
            this.BackColor = primaryBlue;
            this.ForeColor = lightTextColor;
            this.Text = "Local Events and Announcements";
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 7;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchTableLayoutPanel.Controls.Add(this.lblCategory, 0, 0);
            this.searchTableLayoutPanel.Controls.Add(this.cmbCategory, 1, 0);
            this.searchTableLayoutPanel.Controls.Add(this.lblStartDate, 2, 0);
            this.searchTableLayoutPanel.Controls.Add(this.dtpStart, 3, 0);
            this.searchTableLayoutPanel.Controls.Add(this.lblEndDate, 4, 0);
            this.searchTableLayoutPanel.Controls.Add(this.dtpEnd, 5, 0);
            this.searchTableLayoutPanel.Controls.Add(this.btnSearch, 6, 0);
            this.searchTableLayoutPanel.Controls.Add(this.btnClear, 6, 1);
            this.searchTableLayoutPanel.Controls.Add(this.btnBack, 6, 2);
            this.searchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchTableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.searchTableLayoutPanel.RowCount = 3;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.searchTableLayoutPanel.Height = 125;
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(900, 125);
            this.searchTableLayoutPanel.TabIndex = 0;
            this.searchTableLayoutPanel.BackColor = controlBackColor;
            //
            // lblCategory
            //
            this.lblCategory.AutoSize = true;
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCategory.Font = labelFont;
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category:";
            //
            // cmbCategory
            //
            this.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 25);
            this.cmbCategory.TabIndex = 1;
            //
            // lblStartDate
            //
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStartDate.Font = labelFont;
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(68, 17);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date:";
            //
            // dtpStart
            //
            this.dtpStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(120, 25);
            this.dtpStart.TabIndex = 3;
            //
            // lblEndDate
            //
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEndDate.Font = labelFont;
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(63, 17);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End Date:";
            //
            // dtpEnd
            //
            this.dtpEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(120, 25);
            this.dtpEnd.TabIndex = 5;
            //
            // btnSearch
            //
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            this.btnSearch.BackColor = accentGold;
            this.btnSearch.ForeColor = primaryBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = buttonFont;
            //
            // btnClear
            //
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            this.btnClear.BackColor = controlBackColor;
            this.btnClear.ForeColor = lightTextColor;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderColor = accentGold;
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.Font = buttonFont;
            //
            // btnBack
            //
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            this.btnBack.BackColor = controlBackColor;
            this.btnBack.ForeColor = lightTextColor;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderColor = accentGold;
            this.btnBack.FlatAppearance.BorderSize = 1;
            this.btnBack.Font = buttonFont;
            //
            // dgvEvents
            //
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.BackgroundColor = controlBackColor;
            this.dgvEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = primaryBlue;
            dataGridViewCellStyle1.Font = buttonFont;
            dataGridViewCellStyle1.ForeColor = accentGold;
            dataGridViewCellStyle1.SelectionBackColor = primaryBlue;
            dataGridViewCellStyle1.SelectionForeColor = accentGold;
            this.dgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvents.EnableHeadersVisualStyles = false;
            this.dgvEvents.GridColor = primaryBlue;
            this.dgvEvents.Location = new System.Drawing.Point(0, 0);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = controlBackColor;
            dataGridViewCellStyle2.Font = labelFont;
            dataGridViewCellStyle2.ForeColor = lightTextColor;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(0, 70, 140);
            dataGridViewCellStyle2.SelectionForeColor = lightTextColor;
            this.dgvEvents.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEvents.RowTemplate.Height = 28;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(680, 475);
            this.dgvEvents.TabIndex = 0;
            //
            // recPanel
            //
            this.recPanel.Controls.Add(this.lstRecommendations);
            this.recPanel.Controls.Add(this.lblRec);
            this.recPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recPanel.Location = new System.Drawing.Point(0, 0);
            this.recPanel.Padding = new System.Windows.Forms.Padding(10);
            this.recPanel.Name = "recPanel";
            this.recPanel.Size = new System.Drawing.Size(216, 475);
            this.recPanel.TabIndex = 0;
            this.recPanel.BackColor = controlBackColor;
            //
            // lblRec
            //
            this.lblRec.AutoSize = true;
            this.lblRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRec.Font = titleFont;
            this.lblRec.Name = "lblRec";
            this.lblRec.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblRec.Size = new System.Drawing.Size(236, 31);
            this.lblRec.TabIndex = 0;
            this.lblRec.Text = "Recommended Categories";
            //
            // lstRecommendations
            //
            this.lstRecommendations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRecommendations.Font = labelFont;
            this.lstRecommendations.FormattingEnabled = true;
            this.lstRecommendations.Location = new System.Drawing.Point(10, 30);
            this.lstRecommendations.Name = "lstRecommendations";
            this.lstRecommendations.Size = new System.Drawing.Size(180, 430);
            this.lstRecommendations.TabIndex = 1;
            this.lstRecommendations.BackColor = primaryBlue;
            this.lstRecommendations.ForeColor = lightTextColor;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 125);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvEvents);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.recPanel);
            this.splitContainer.Size = new System.Drawing.Size(900, 475);
            this.splitContainer.SplitterDistance = 680;
            this.splitContainer.TabIndex = 1;
            // 
            // LocalEventsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.searchTableLayoutPanel);
            this.Name = "LocalEventsForm";
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.recPanel.ResumeLayout(false);
            this.recPanel.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Panel recPanel;
        private System.Windows.Forms.Label lblRec;
        private System.Windows.Forms.ListBox lstRecommendations;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}
