namespace MunicipalityApp
{
    partial class LocalEventsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            searchTableLayoutPanel = new TableLayoutPanel();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblStartDate = new Label();
            lblEndDate = new Label();
            dtpStart = new DateTimePicker();
            btnSearch = new Button();
            btnClear = new Button();
            btnBack = new Button();
            dtpEnd = new DateTimePicker();
            dgvEvents = new DataGridView();
            recPanel = new Panel();
            lstRecommendations = new ListBox();
            lblRec = new Label();
            splitContainer = new SplitContainer();
            searchTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            recPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // searchTableLayoutPanel
            // 
            searchTableLayoutPanel.BackColor = Color.FromArgb(62, 142, 222);
            searchTableLayoutPanel.ColumnCount = 7;
            searchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            searchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            searchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            searchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            searchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            searchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            searchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            searchTableLayoutPanel.Controls.Add(lblCategory, 0, 0);
            searchTableLayoutPanel.Controls.Add(cmbCategory, 1, 0);
            searchTableLayoutPanel.Controls.Add(lblStartDate, 2, 0);
            searchTableLayoutPanel.Controls.Add(lblEndDate, 4, 0);
            searchTableLayoutPanel.Controls.Add(dtpStart, 3, 0);
            searchTableLayoutPanel.Controls.Add(btnSearch, 6, 1);
            searchTableLayoutPanel.Controls.Add(btnClear, 6, 0);
            searchTableLayoutPanel.Controls.Add(btnBack, 6, 2);
            searchTableLayoutPanel.Controls.Add(dtpEnd, 5, 0);
            searchTableLayoutPanel.Dock = DockStyle.Top;
            searchTableLayoutPanel.Location = new Point(0, 0);
            searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            searchTableLayoutPanel.Padding = new Padding(10);
            searchTableLayoutPanel.RowCount = 3;
            searchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            searchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            searchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            searchTableLayoutPanel.Size = new Size(1097, 119);
            searchTableLayoutPanel.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.Left;
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.5F);
            lblCategory.Location = new Point(13, 15);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(92, 25);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Left;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(111, 13);
            cmbCategory.Margin = new Padding(3, 3, 10, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(150, 36);
            cmbCategory.TabIndex = 1;
            // 
            // lblStartDate
            // 
            lblStartDate.Anchor = AnchorStyles.Left;
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9.5F);
            lblStartDate.Location = new Point(281, 15);
            lblStartDate.Margin = new Padding(10, 0, 3, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(98, 25);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            lblEndDate.Anchor = AnchorStyles.Left;
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9.5F);
            lblEndDate.Location = new Point(525, 15);
            lblEndDate.Margin = new Padding(10, 0, 3, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(92, 25);
            lblEndDate.TabIndex = 4;
            lblEndDate.Text = "End Date:";
            // 
            // dtpStart
            // 
            dtpStart.Anchor = AnchorStyles.Left;
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(385, 13);
            dtpStart.Margin = new Padding(3, 3, 10, 3);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(120, 33);
            dtpStart.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(50, 205, 50);
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(50, 205, 50);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(984, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(62, 142, 222);
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(50, 205, 50);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.WhiteSmoke;
            btnClear.Location = new Point(984, 13);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(62, 142, 222);
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(50, 205, 50);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.WhiteSmoke;
            btnBack.Location = new Point(984, 83);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // dtpEnd
            // 
            dtpEnd.Anchor = AnchorStyles.Left;
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(623, 13);
            dtpEnd.Margin = new Padding(3, 3, 10, 3);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(120, 33);
            dtpEnd.TabIndex = 5;
            // 
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AllowUserToDeleteRows = false;
            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvents.BackgroundColor = Color.FromArgb(62, 142, 222);
            dgvEvents.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 108, 163);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(50, 205, 50);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 108, 163);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(50, 205, 50);
            dgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Dock = DockStyle.Fill;
            dgvEvents.EnableHeadersVisualStyles = false;
            dgvEvents.GridColor = Color.FromArgb(62, 142, 222);
            dgvEvents.Location = new Point(0, 0);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersVisible = false;
            dgvEvents.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 50, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 70, 140);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dgvEvents.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvEvents.RowTemplate.Height = 28;
            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.Size = new Size(827, 481);
            dgvEvents.TabIndex = 0;
            // 
            // recPanel
            // 
            recPanel.BackColor = Color.FromArgb(43, 108, 163);
            recPanel.Controls.Add(lstRecommendations);
            recPanel.Controls.Add(lblRec);
            recPanel.Dock = DockStyle.Fill;
            recPanel.Location = new Point(0, 0);
            recPanel.Name = "recPanel";
            recPanel.Padding = new Padding(10);
            recPanel.Size = new Size(266, 481);
            recPanel.TabIndex = 0;
            // 
            // lstRecommendations
            // 
            lstRecommendations.BackColor = Color.FromArgb(62, 142, 222);
            lstRecommendations.Dock = DockStyle.Fill;
            lstRecommendations.Font = new Font("Segoe UI", 9.5F);
            lstRecommendations.ForeColor = Color.WhiteSmoke;
            lstRecommendations.FormattingEnabled = true;
            lstRecommendations.ItemHeight = 25;
            lstRecommendations.Location = new Point(10, 52);
            lstRecommendations.Name = "lstRecommendations";
            lstRecommendations.Size = new Size(246, 419);
            lstRecommendations.TabIndex = 1;
            // 
            // lblRec
            // 
            lblRec.AutoSize = true;
            lblRec.Dock = DockStyle.Top;
            lblRec.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRec.ForeColor = Color.FromArgb(50, 205, 50);
            lblRec.Location = new Point(10, 10);
            lblRec.Name = "lblRec";
            lblRec.Padding = new Padding(0, 0, 0, 10);
            lblRec.Size = new Size(312, 42);
            lblRec.TabIndex = 0;
            lblRec.Text = "Recommended Categories";
            lblRec.Click += lblRec_Click;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 119);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(dgvEvents);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(recPanel);
            splitContainer.Size = new Size(1097, 481);
            splitContainer.SplitterDistance = 827;
            splitContainer.TabIndex = 1;
            // 
            // LocalEventsForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 30, 60);
            ClientSize = new Size(1097, 600);
            Controls.Add(splitContainer);
            Controls.Add(searchTableLayoutPanel);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.WhiteSmoke;
            Name = "LocalEventsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Local Events and Announcements";
            searchTableLayoutPanel.ResumeLayout(false);
            searchTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            recPanel.ResumeLayout(false);
            recPanel.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);

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
