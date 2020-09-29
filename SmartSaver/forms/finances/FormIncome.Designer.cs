namespace FormIncome
{
    partial class FormIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncome));
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.buttonAddIncome = new System.Windows.Forms.Button();
            this.buttonNextYear = new System.Windows.Forms.Button();
            this.buttonPreviousYear = new System.Windows.Forms.Button();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.buttonPreviousMonth = new System.Windows.Forms.Button();
            this.textBoxCurrentMonth = new System.Windows.Forms.TextBox();
            this.textBoxCurrentYear = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.textBoxBalance);
            this.panelTop.Controls.Add(this.buttonAddIncome);
            this.panelTop.Controls.Add(this.buttonNextYear);
            this.panelTop.Controls.Add(this.buttonPreviousYear);
            this.panelTop.Controls.Add(this.buttonNextMonth);
            this.panelTop.Controls.Add(this.buttonPreviousMonth);
            this.panelTop.Controls.Add(this.textBoxCurrentMonth);
            this.panelTop.Controls.Add(this.textBoxCurrentYear);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(971, 94);
            this.panelTop.TabIndex = 0;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBalance.Location = new System.Drawing.Point(726, 55);
            this.textBoxBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(110, 23);
            this.textBoxBalance.TabIndex = 5;
            this.textBoxBalance.Text = "Balance";
            // 
            // buttonAddIncome
            // 
            this.buttonAddIncome.Location = new System.Drawing.Point(60, 50);
            this.buttonAddIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddIncome.Name = "buttonAddIncome";
            this.buttonAddIncome.Size = new System.Drawing.Size(105, 22);
            this.buttonAddIncome.TabIndex = 3;
            this.buttonAddIncome.Text = "Add Income";
            this.buttonAddIncome.UseVisualStyleBackColor = true;
            this.buttonAddIncome.Click += new System.EventHandler(this.ButtonAddIncome_Click);
            // 
            // buttonNextYear
            // 
            this.buttonNextYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextYear.FlatAppearance.BorderSize = 0;
            this.buttonNextYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNextYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNextYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextYear.Image = ((System.Drawing.Image)(resources.GetObject("buttonNextYear.Image")));
            this.buttonNextYear.Location = new System.Drawing.Point(489, 1);
            this.buttonNextYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextYear.Name = "buttonNextYear";
            this.buttonNextYear.Size = new System.Drawing.Size(45, 45);
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
            this.buttonPreviousYear.Image = ((System.Drawing.Image)(resources.GetObject("buttonPreviousYear.Image")));
            this.buttonPreviousYear.Location = new System.Drawing.Point(396, 1);
            this.buttonPreviousYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousYear.Name = "buttonPreviousYear";
            this.buttonPreviousYear.Size = new System.Drawing.Size(45, 45);
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
            this.buttonNextMonth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNextMonth.Image = ((System.Drawing.Image)(resources.GetObject("buttonNextMonth.Image")));
            this.buttonNextMonth.Location = new System.Drawing.Point(489, 45);
            this.buttonNextMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(45, 45);
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
            this.buttonPreviousMonth.Image = ((System.Drawing.Image)(resources.GetObject("buttonPreviousMonth.Image")));
            this.buttonPreviousMonth.Location = new System.Drawing.Point(396, 45);
            this.buttonPreviousMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousMonth.Name = "buttonPreviousMonth";
            this.buttonPreviousMonth.Size = new System.Drawing.Size(45, 45);
            this.buttonPreviousMonth.TabIndex = 1;
            this.buttonPreviousMonth.Click += new System.EventHandler(this.ButtonPreviousMonth_Click);
            this.buttonPreviousMonth.MouseEnter += new System.EventHandler(this.ButtonPreviousMonth_MouseEnter);
            this.buttonPreviousMonth.MouseLeave += new System.EventHandler(this.ButtonPreviousMonth_MouseLeave);
            // 
            // textBoxCurrentMonth
            // 
            this.textBoxCurrentMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCurrentMonth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCurrentMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentMonth.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxCurrentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCurrentMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.textBoxCurrentMonth.Location = new System.Drawing.Point(423, 55);
            this.textBoxCurrentMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCurrentMonth.Name = "textBoxCurrentMonth";
            this.textBoxCurrentMonth.ReadOnly = true;
            this.textBoxCurrentMonth.Size = new System.Drawing.Size(88, 25);
            this.textBoxCurrentMonth.TabIndex = 0;
            this.textBoxCurrentMonth.Text = "MON";
            this.textBoxCurrentMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCurrentYear
            // 
            this.textBoxCurrentYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCurrentYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCurrentYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxCurrentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCurrentYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.textBoxCurrentYear.Location = new System.Drawing.Point(423, 15);
            this.textBoxCurrentYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCurrentYear.Name = "textBoxCurrentYear";
            this.textBoxCurrentYear.ReadOnly = true;
            this.textBoxCurrentYear.Size = new System.Drawing.Size(88, 25);
            this.textBoxCurrentYear.TabIndex = 0;
            this.textBoxCurrentYear.Text = "YEAR";
            this.textBoxCurrentYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 94);
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
            this.splitContainer.Panel2MinSize = 300;
            this.splitContainer.Size = new System.Drawing.Size(971, 582);
            this.splitContainer.SplitterDistance = 656;
            this.splitContainer.TabIndex = 1;
            this.splitContainer.Text = "splitContainer1";
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
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(656, 582);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Text = "dataGridView";
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // FormIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 676);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormIncome";
            this.Text = "FormBudget";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox textBoxCurrentMonth;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button buttonNextMonth;
        private System.Windows.Forms.Button buttonPreviousMonth;
        private System.Windows.Forms.Button buttonNextYear;
        private System.Windows.Forms.Button buttonPreviousYear;
        private System.Windows.Forms.TextBox textBoxCurrentYear;
        private System.Windows.Forms.DataGridView dataGridView
            ;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Button buttonAddIncome;
    }
}