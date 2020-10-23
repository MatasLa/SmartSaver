namespace ePiggy.Forms.Finances.Budget
{
    partial class FinanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonAddEntry = new System.Windows.Forms.Button();
            this.buttonNextYear = new System.Windows.Forms.Button();
            this.buttonPreviousYear = new System.Windows.Forms.Button();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.buttonPreviousMonth = new System.Windows.Forms.Button();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelValueMonthlyBalance = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.labelValueMonths = new System.Windows.Forms.Label();
            this.labelMonthsTotal = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMonthlyBalance = new System.Windows.Forms.Label();
            this.labelTotalBalance = new System.Windows.Forms.Label();
            this.labelValueTotalBalance = new System.Windows.Forms.Label();
            this.labelBalanceUntilToday = new System.Windows.Forms.Label();
            this.labelValueBalanceUntilToday = new System.Windows.Forms.Label();
            this.labelBalanceEndOfMonth = new System.Windows.Forms.Label();
            this.labelValueBalanceEndOfMonth = new System.Windows.Forms.Label();
            this.labelNecessary = new System.Windows.Forms.Label();
            this.labelValueNecessary = new System.Windows.Forms.Label();
            this.labelHighImportance = new System.Windows.Forms.Label();
            this.labelValueHighImportance = new System.Windows.Forms.Label();
            this.labelMediumImportance = new System.Windows.Forms.Label();
            this.labelValueMediumImportance = new System.Windows.Forms.Label();
            this.labelLowImportance = new System.Windows.Forms.Label();
            this.labelValueLowImportance = new System.Windows.Forms.Label();
            this.labelUnnecessary = new System.Windows.Forms.Label();
            this.labelValueUnnecessary = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.buttonShowAll);
            this.panelTop.Controls.Add(this.buttonAddEntry);
            this.panelTop.Controls.Add(this.buttonNextYear);
            this.panelTop.Controls.Add(this.buttonPreviousYear);
            this.panelTop.Controls.Add(this.buttonNextMonth);
            this.panelTop.Controls.Add(this.buttonPreviousMonth);
            this.panelTop.Controls.Add(this.labelYear);
            this.panelTop.Controls.Add(this.labelMonth);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1110, 100);
            this.panelTop.TabIndex = 0;
            this.panelTop.Click += new System.EventHandler(this.PanelTop_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowAll.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowAll.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.buttonShowAll.Location = new System.Drawing.Point(992, 4);
            this.buttonShowAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(118, 39);
            this.buttonShowAll.TabIndex = 3;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.ButtonShowAll_Click);
            // 
            // buttonAddEntry
            // 
            this.buttonAddEntry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAddEntry.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddEntry.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.buttonAddEntry.Location = new System.Drawing.Point(43, 28);
            this.buttonAddEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddEntry.Name = "buttonAddEntry";
            this.buttonAddEntry.Size = new System.Drawing.Size(198, 47);
            this.buttonAddEntry.TabIndex = 3;
            this.buttonAddEntry.Text = "Add Entry";
            this.buttonAddEntry.UseVisualStyleBackColor = false;
            this.buttonAddEntry.Click += new System.EventHandler(this.ButtonAddEntry_Click);
            // 
            // buttonNextYear
            // 
            this.buttonNextYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextYear.FlatAppearance.BorderSize = 0;
            this.buttonNextYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNextYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNextYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextYear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNextYear.Image = ((System.Drawing.Image)(resources.GetObject("buttonNextYear.Image")));
            this.buttonNextYear.Location = new System.Drawing.Point(559, 1);
            this.buttonNextYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextYear.Name = "buttonNextYear";
            this.buttonNextYear.Size = new System.Drawing.Size(51, 48);
            this.buttonNextYear.TabIndex = 2;
            this.buttonNextYear.UseVisualStyleBackColor = true;
            this.buttonNextYear.Click += new System.EventHandler(this.ButtonNextYear_Click);
            this.buttonNextYear.MouseEnter += new System.EventHandler(this.ButtonNextYear_MouseEnter);
            this.buttonNextYear.MouseLeave += new System.EventHandler(this.ButtonNextYear_MouseLeave);
            // 
            // buttonPreviousYear
            // 
            this.buttonPreviousYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPreviousYear.FlatAppearance.BorderSize = 0;
            this.buttonPreviousYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPreviousYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPreviousYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousYear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPreviousYear.Image = ((System.Drawing.Image)(resources.GetObject("buttonPreviousYear.Image")));
            this.buttonPreviousYear.Location = new System.Drawing.Point(453, 1);
            this.buttonPreviousYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousYear.Name = "buttonPreviousYear";
            this.buttonPreviousYear.Size = new System.Drawing.Size(51, 48);
            this.buttonPreviousYear.TabIndex = 1;
            this.buttonPreviousYear.Click += new System.EventHandler(this.ButtonPreviousYear_Click);
            this.buttonPreviousYear.MouseEnter += new System.EventHandler(this.ButtonPreviousYear_MouseEnter);
            this.buttonPreviousYear.MouseLeave += new System.EventHandler(this.ButtonPreviousYear_MouseLeave);
            // 
            // buttonNextMonth
            // 
            this.buttonNextMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextMonth.BackColor = System.Drawing.Color.Transparent;
            this.buttonNextMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNextMonth.FlatAppearance.BorderSize = 0;
            this.buttonNextMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNextMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextMonth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNextMonth.Image = ((System.Drawing.Image)(resources.GetObject("buttonNextMonth.Image")));
            this.buttonNextMonth.Location = new System.Drawing.Point(559, 44);
            this.buttonNextMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(51, 48);
            this.buttonNextMonth.TabIndex = 2;
            this.buttonNextMonth.UseVisualStyleBackColor = false;
            this.buttonNextMonth.Click += new System.EventHandler(this.ButtonNextMonth_Click);
            this.buttonNextMonth.MouseEnter += new System.EventHandler(this.buttonNextMonth_MouseEnter);
            this.buttonNextMonth.MouseLeave += new System.EventHandler(this.ButtonNextMonth_MouseLeave);
            // 
            // buttonPreviousMonth
            // 
            this.buttonPreviousMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPreviousMonth.FlatAppearance.BorderSize = 0;
            this.buttonPreviousMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPreviousMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPreviousMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousMonth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPreviousMonth.Image = ((System.Drawing.Image)(resources.GetObject("buttonPreviousMonth.Image")));
            this.buttonPreviousMonth.Location = new System.Drawing.Point(453, 44);
            this.buttonPreviousMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousMonth.Name = "buttonPreviousMonth";
            this.buttonPreviousMonth.Size = new System.Drawing.Size(51, 48);
            this.buttonPreviousMonth.TabIndex = 1;
            this.buttonPreviousMonth.Click += new System.EventHandler(this.ButtonPreviousMonth_Click);
            this.buttonPreviousMonth.MouseEnter += new System.EventHandler(this.ButtonPreviousMonth_MouseEnter);
            this.buttonPreviousMonth.MouseLeave += new System.EventHandler(this.ButtonPreviousMonth_MouseLeave);
            // 
            // labelYear
            // 
            this.labelYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelYear.AutoSize = true;
            this.labelYear.BackColor = System.Drawing.Color.Transparent;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelYear.Location = new System.Drawing.Point(501, 12);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(74, 26);
            this.labelYear.TabIndex = 6;
            this.labelYear.Text = "YEAR";
            this.labelYear.Click += new System.EventHandler(this.LabelYear_Click);
            // 
            // labelMonth
            // 
            this.labelMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMonth.AutoSize = true;
            this.labelMonth.BackColor = System.Drawing.Color.Transparent;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelMonth.Location = new System.Drawing.Point(505, 55);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(63, 26);
            this.labelMonth.TabIndex = 7;
            this.labelMonth.Text = "MON";
            // 
            // labelValueMonthlyBalance
            // 
            this.labelValueMonthlyBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelValueMonthlyBalance.AutoSize = true;
            this.labelValueMonthlyBalance.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.SetFlowBreak(this.labelValueMonthlyBalance, true);
            this.labelValueMonthlyBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValueMonthlyBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelValueMonthlyBalance.Location = new System.Drawing.Point(169, 0);
            this.labelValueMonthlyBalance.Name = "labelValueMonthlyBalance";
            this.labelValueMonthlyBalance.Size = new System.Drawing.Size(62, 26);
            this.labelValueMonthlyBalance.TabIndex = 9;
            this.labelValueMonthlyBalance.Text = "NUM";
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 100);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel1.Controls.Add(this.dataGridView);
            this.splitContainer.Panel1MinSize = 600;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel);
            this.splitContainer.Panel2MinSize = 300;
            this.splitContainer.Size = new System.Drawing.Size(1110, 621);
            this.splitContainer.SplitterDistance = 749;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 1;
            this.splitContainer.Text = "splitContainer1";
            // 
            // labelValueMonths
            // 
            this.labelValueMonths.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelValueMonths.AutoSize = true;
            this.labelValueMonths.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.SetFlowBreak(this.labelValueMonths, true);
            this.labelValueMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValueMonths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelValueMonths.Location = new System.Drawing.Point(181, 353);
            this.labelValueMonths.Name = "labelValueMonths";
            this.labelValueMonths.Size = new System.Drawing.Size(91, 26);
            this.labelValueMonths.TabIndex = 9;
            this.labelValueMonths.Text = "Balance";
            // 
            // labelMonthsTotal
            // 
            this.labelMonthsTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMonthsTotal.AutoSize = true;
            this.labelMonthsTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelMonthsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMonthsTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelMonthsTotal.Location = new System.Drawing.Point(3, 353);
            this.labelMonthsTotal.Name = "labelMonthsTotal";
            this.labelMonthsTotal.Size = new System.Drawing.Size(172, 26);
            this.labelMonthsTotal.TabIndex = 9;
            this.labelMonthsTotal.Text = "Total this month:";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(749, 621);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Text = "dataGridView";
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            this.dataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataGridView_KeyPress);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.labelMonthsTotal);
            this.flowLayoutPanel.Controls.Add(this.labelValueMonths);
            this.flowLayoutPanel.Controls.Add(this.labelMonthlyBalance);
            this.flowLayoutPanel.Controls.Add(this.labelValueMonthlyBalance);
            this.flowLayoutPanel.Controls.Add(this.labelTotalBalance);
            this.flowLayoutPanel.Controls.Add(this.labelValueTotalBalance);
            this.flowLayoutPanel.Controls.Add(this.labelBalanceUntilToday);
            this.flowLayoutPanel.Controls.Add(this.labelValueBalanceUntilToday);
            this.flowLayoutPanel.Controls.Add(this.labelBalanceEndOfMonth);
            this.flowLayoutPanel.Controls.Add(this.labelValueBalanceEndOfMonth);
            this.flowLayoutPanel.Controls.Add(this.labelNecessary);
            this.flowLayoutPanel.Controls.Add(this.labelValueNecessary);
            this.flowLayoutPanel.Controls.Add(this.labelHighImportance);
            this.flowLayoutPanel.Controls.Add(this.labelValueHighImportance);
            this.flowLayoutPanel.Controls.Add(this.labelMediumImportance);
            this.flowLayoutPanel.Controls.Add(this.labelValueMediumImportance);
            this.flowLayoutPanel.Controls.Add(this.labelLowImportance);
            this.flowLayoutPanel.Controls.Add(this.labelValueLowImportance);
            this.flowLayoutPanel.Controls.Add(this.labelUnnecessary);
            this.flowLayoutPanel.Controls.Add(this.labelValueUnnecessary);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(356, 621);
            this.flowLayoutPanel.TabIndex = 10;
            // 
            // labelMonthlyBalance
            // 
            this.labelMonthlyBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMonthlyBalance.AutoSize = true;
            this.labelMonthlyBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelMonthlyBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMonthlyBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelMonthlyBalance.Location = new System.Drawing.Point(3, 0);
            this.labelMonthlyBalance.Name = "labelMonthlyBalance";
            this.labelMonthlyBalance.Size = new System.Drawing.Size(160, 26);
            this.labelMonthlyBalance.TabIndex = 9;
            this.labelMonthlyBalance.Text = "Month balance:";
            // 
            // labelTotalBalance
            // 
            this.labelTotalBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalBalance.AutoSize = true;
            this.labelTotalBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelTotalBalance.Location = new System.Drawing.Point(3, 27);
            this.labelTotalBalance.Margin = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.labelTotalBalance.Name = "labelTotalBalance";
            this.labelTotalBalance.Size = new System.Drawing.Size(147, 26);
            this.labelTotalBalance.TabIndex = 9;
            this.labelTotalBalance.Text = "Total balance:";
            // 
            // labelValueTotalBalance
            // 
            this.labelValueTotalBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValueTotalBalance.AutoSize = true;
            this.labelValueTotalBalance.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.SetFlowBreak(this.labelValueTotalBalance, true);
            this.labelValueTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValueTotalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelValueTotalBalance.Location = new System.Drawing.Point(153, 26);
            this.labelValueTotalBalance.Name = "labelValueTotalBalance";
            this.labelValueTotalBalance.Size = new System.Drawing.Size(62, 26);
            this.labelValueTotalBalance.TabIndex = 9;
            this.labelValueTotalBalance.Text = "NUM";
            // 
            // labelBalanceUntilToday
            // 
            this.labelBalanceUntilToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBalanceUntilToday.AutoSize = true;
            this.labelBalanceUntilToday.BackColor = System.Drawing.Color.Transparent;
            this.labelBalanceUntilToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBalanceUntilToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelBalanceUntilToday.Location = new System.Drawing.Point(3, 54);
            this.labelBalanceUntilToday.Margin = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.labelBalanceUntilToday.Name = "labelBalanceUntilToday";
            this.labelBalanceUntilToday.Size = new System.Drawing.Size(202, 26);
            this.labelBalanceUntilToday.TabIndex = 9;
            this.labelBalanceUntilToday.Text = "Balance until today:";
            // 
            // labelValueBalanceUntilToday
            // 
            this.labelValueBalanceUntilToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValueBalanceUntilToday.AutoSize = true;
            this.labelValueBalanceUntilToday.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.SetFlowBreak(this.labelValueBalanceUntilToday, true);
            this.labelValueBalanceUntilToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValueBalanceUntilToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelValueBalanceUntilToday.Location = new System.Drawing.Point(208, 53);
            this.labelValueBalanceUntilToday.Name = "labelValueBalanceUntilToday";
            this.labelValueBalanceUntilToday.Size = new System.Drawing.Size(62, 26);
            this.labelValueBalanceUntilToday.TabIndex = 9;
            this.labelValueBalanceUntilToday.Text = "NUM";
            // 
            // labelBalanceEndOfMonth
            // 
            this.labelBalanceEndOfMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBalanceEndOfMonth.AutoSize = true;
            this.labelBalanceEndOfMonth.BackColor = System.Drawing.Color.Transparent;
            this.labelBalanceEndOfMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBalanceEndOfMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelBalanceEndOfMonth.Location = new System.Drawing.Point(3, 81);
            this.labelBalanceEndOfMonth.Margin = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.labelBalanceEndOfMonth.Name = "labelBalanceEndOfMonth";
            this.labelBalanceEndOfMonth.Size = new System.Drawing.Size(318, 52);
            this.labelBalanceEndOfMonth.TabIndex = 9;
            this.labelBalanceEndOfMonth.Text = "Balance until the end of current month:";
            // 
            // labelValueBalanceEndOfMonth
            // 
            this.labelValueBalanceEndOfMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValueBalanceEndOfMonth.AutoSize = true;
            this.labelValueBalanceEndOfMonth.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.SetFlowBreak(this.labelValueBalanceEndOfMonth, true);
            this.labelValueBalanceEndOfMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValueBalanceEndOfMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelValueBalanceEndOfMonth.Location = new System.Drawing.Point(3, 148);
            this.labelValueBalanceEndOfMonth.Name = "labelValueBalanceEndOfMonth";
            this.labelValueBalanceEndOfMonth.Size = new System.Drawing.Size(62, 26);
            this.labelValueBalanceEndOfMonth.TabIndex = 9;
            this.labelValueBalanceEndOfMonth.Text = "NUM";
            // 
            // labelNecessary
            // 
            this.labelNecessary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNecessary.AutoSize = true;
            this.labelNecessary.BackColor = System.Drawing.Color.Transparent;
            this.labelNecessary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNecessary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelNecessary.Location = new System.Drawing.Point(3, 219);
            this.labelNecessary.Margin = new System.Windows.Forms.Padding(3, 30, 0, 0);
            this.labelNecessary.Name = "labelNecessary";
            this.labelNecessary.Size = new System.Drawing.Size(121, 26);
            this.labelNecessary.TabIndex = 9;
            this.labelNecessary.Text = "Necessary:";
            // 
            // labelValueNecessary
            // 
            this.labelValueNecessary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValueNecessary.AutoSize = true;
            this.labelValueNecessary.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.SetFlowBreak(this.labelValueNecessary, true);
            this.labelValueNecessary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValueNecessary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelValueNecessary.Location = new System.Drawing.Point(127, 219);
            this.labelValueNecessary.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.labelValueNecessary.Name = "labelValueNecessary";
            this.labelValueNecessary.Size = new System.Drawing.Size(62, 26);
            this.labelValueNecessary.TabIndex = 9;
            this.labelValueNecessary.Text = "NUM";
            // 
            // labelHighImportance
            // 
            this.labelHighImportance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHighImportance.AutoSize = true;
            this.labelHighImportance.BackColor = System.Drawing.Color.Transparent;
            this.labelHighImportance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHighImportance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelHighImportance.Location = new System.Drawing.Point(3, 246);
            this.labelHighImportance.Margin = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.labelHighImportance.Name = "labelHighImportance";
            this.labelHighImportance.Size = new System.Drawing.Size(177, 26);
            this.labelHighImportance.TabIndex = 9;
            this.labelHighImportance.Text = "High importance:";
            // 
            // labelValueHighImportance
            // 
            this.labelValueHighImportance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValueHighImportance.AutoSize = true;
            this.labelValueHighImportance.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.SetFlowBreak(this.labelValueHighImportance, true);
            this.labelValueHighImportance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValueHighImportance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelValueHighImportance.Location = new System.Drawing.Point(183, 245);
            this.labelValueHighImportance.Name = "labelValueHighImportance";
            this.labelValueHighImportance.Size = new System.Drawing.Size(62, 26);
            this.labelValueHighImportance.TabIndex = 9;
            this.labelValueHighImportance.Text = "NUM";
            // 
            // labelMediumImportance
            // 
            this.labelMediumImportance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMediumImportance.AutoSize = true;
            this.labelMediumImportance.BackColor = System.Drawing.Color.Transparent;
            this.labelMediumImportance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMediumImportance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelMediumImportance.Location = new System.Drawing.Point(3, 273);
            this.labelMediumImportance.Margin = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.labelMediumImportance.Name = "labelMediumImportance";
            this.labelMediumImportance.Size = new System.Drawing.Size(210, 26);
            this.labelMediumImportance.TabIndex = 9;
            this.labelMediumImportance.Text = "Medium importance:";
            // 
            // labelValueMediumImportance
            // 
            this.labelValueMediumImportance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValueMediumImportance.AutoSize = true;
            this.labelValueMediumImportance.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.SetFlowBreak(this.labelValueMediumImportance, true);
            this.labelValueMediumImportance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValueMediumImportance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelValueMediumImportance.Location = new System.Drawing.Point(216, 272);
            this.labelValueMediumImportance.Name = "labelValueMediumImportance";
            this.labelValueMediumImportance.Size = new System.Drawing.Size(62, 26);
            this.labelValueMediumImportance.TabIndex = 9;
            this.labelValueMediumImportance.Text = "NUM";
            // 
            // labelLowImportance
            // 
            this.labelLowImportance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLowImportance.AutoSize = true;
            this.labelLowImportance.BackColor = System.Drawing.Color.Transparent;
            this.labelLowImportance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLowImportance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelLowImportance.Location = new System.Drawing.Point(3, 300);
            this.labelLowImportance.Margin = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.labelLowImportance.Name = "labelLowImportance";
            this.labelLowImportance.Size = new System.Drawing.Size(172, 26);
            this.labelLowImportance.TabIndex = 9;
            this.labelLowImportance.Text = "Low importance:";
            // 
            // labelValueLowImportance
            // 
            this.labelValueLowImportance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValueLowImportance.AutoSize = true;
            this.labelValueLowImportance.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.SetFlowBreak(this.labelValueLowImportance, true);
            this.labelValueLowImportance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValueLowImportance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelValueLowImportance.Location = new System.Drawing.Point(178, 299);
            this.labelValueLowImportance.Name = "labelValueLowImportance";
            this.labelValueLowImportance.Size = new System.Drawing.Size(62, 26);
            this.labelValueLowImportance.TabIndex = 9;
            this.labelValueLowImportance.Text = "NUM";
            // 
            // labelUnnecessary
            // 
            this.labelUnnecessary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUnnecessary.AutoSize = true;
            this.labelUnnecessary.BackColor = System.Drawing.Color.Transparent;
            this.labelUnnecessary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnnecessary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelUnnecessary.Location = new System.Drawing.Point(3, 327);
            this.labelUnnecessary.Margin = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.labelUnnecessary.Name = "labelUnnecessary";
            this.labelUnnecessary.Size = new System.Drawing.Size(145, 26);
            this.labelUnnecessary.TabIndex = 9;
            this.labelUnnecessary.Text = "Unnecessary:";
            // 
            // labelValueUnnecessary
            // 
            this.labelValueUnnecessary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValueUnnecessary.AutoSize = true;
            this.labelValueUnnecessary.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.SetFlowBreak(this.labelValueUnnecessary, true);
            this.labelValueUnnecessary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValueUnnecessary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelValueUnnecessary.Location = new System.Drawing.Point(151, 326);
            this.labelValueUnnecessary.Name = "labelValueUnnecessary";
            this.labelValueUnnecessary.Size = new System.Drawing.Size(62, 26);
            this.labelValueUnnecessary.TabIndex = 9;
            this.labelValueUnnecessary.Text = "NUM";
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 721);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FinanceForm";
            this.Text = "FormBudget";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button buttonNextMonth;
        private System.Windows.Forms.Button buttonPreviousMonth;
        private System.Windows.Forms.Button buttonNextYear;
        private System.Windows.Forms.Button buttonPreviousYear;
        private System.Windows.Forms.DataGridView dataGridView
            ;
        private System.Windows.Forms.Button buttonAddEntry;
        private System.Windows.Forms.Label labelValueMonthlyBalance;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelValueBalanceUntilToday;
        private System.Windows.Forms.Label labelBalanceEndOfMonth;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label labelValueTotalBalance;
        private System.Windows.Forms.Label labelBalanceUntilToday;
        private System.Windows.Forms.Label labelValueBalanceEndOfMonth;
        private System.Windows.Forms.Label labelNecessary;
        private System.Windows.Forms.Label labelTotalBalance;
        private System.Windows.Forms.Label labelValueNecessary;
        private System.Windows.Forms.Label labelHighImportance;
        private System.Windows.Forms.Label labelValueHighImportance;
        private System.Windows.Forms.Label labelMediumImportance;
        private System.Windows.Forms.Label labelValueMediumImportance;
        private System.Windows.Forms.Label labelLowImportance;
        private System.Windows.Forms.Label labelValueLowImportance;
        private System.Windows.Forms.Label labelUnnecessary;
        private System.Windows.Forms.Label labelValueUnnecessary;
        private System.Windows.Forms.Label labelMonthlyBalance;
        private System.Windows.Forms.Label labelValueMonths;
        private System.Windows.Forms.Label labelMonthsTotal;
    }
}