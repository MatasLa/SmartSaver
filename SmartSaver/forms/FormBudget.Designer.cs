namespace SmartSaver.forms
{
    partial class FormBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBudget));
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddExpense = new System.Windows.Forms.Button();
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
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Controls.Add(this.buttonAddExpense);
            this.panelTop.Controls.Add(this.buttonAddIncome);
            this.panelTop.Controls.Add(this.buttonNextYear);
            this.panelTop.Controls.Add(this.buttonPreviousYear);
            this.panelTop.Controls.Add(this.buttonNextMonth);
            this.panelTop.Controls.Add(this.buttonPreviousMonth);
            this.panelTop.Controls.Add(this.textBoxCurrentMonth);
            this.panelTop.Controls.Add(this.textBoxCurrentYear);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1110, 125);
            this.panelTop.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(830, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "TOTAL";
            // 
            // buttonAddExpense
            // 
            this.buttonAddExpense.Location = new System.Drawing.Point(660, 73);
            this.buttonAddExpense.Name = "buttonAddExpense";
            this.buttonAddExpense.Size = new System.Drawing.Size(153, 29);
            this.buttonAddExpense.TabIndex = 4;
            this.buttonAddExpense.Text = "Add Expense";
            this.buttonAddExpense.UseVisualStyleBackColor = true;
            this.buttonAddExpense.Click += new System.EventHandler(this.ButtonAddExpense_Click);
            // 
            // buttonAddIncome
            // 
            this.buttonAddIncome.Location = new System.Drawing.Point(68, 66);
            this.buttonAddIncome.Name = "buttonAddIncome";
            this.buttonAddIncome.Size = new System.Drawing.Size(120, 29);
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
            this.buttonNextYear.Location = new System.Drawing.Point(570, 12);
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
            this.buttonPreviousYear.Location = new System.Drawing.Point(456, 12);
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
            this.buttonNextMonth.Location = new System.Drawing.Point(564, 66);
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
            this.buttonPreviousMonth.Location = new System.Drawing.Point(460, 66);
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
            this.textBoxCurrentMonth.Location = new System.Drawing.Point(483, 73);
            this.textBoxCurrentMonth.Name = "textBoxCurrentMonth";
            this.textBoxCurrentMonth.ReadOnly = true;
            this.textBoxCurrentMonth.Size = new System.Drawing.Size(101, 31);
            this.textBoxCurrentMonth.TabIndex = 0;
            this.textBoxCurrentMonth.Text = "MON";
            this.textBoxCurrentMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCurrentMonth.Click += new System.EventHandler(this.TestClick);
            // 
            // textBoxCurrentYear
            // 
            this.textBoxCurrentYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCurrentYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCurrentYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxCurrentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCurrentYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.textBoxCurrentYear.Location = new System.Drawing.Point(483, 20);
            this.textBoxCurrentYear.Name = "textBoxCurrentYear";
            this.textBoxCurrentYear.ReadOnly = true;
            this.textBoxCurrentYear.Size = new System.Drawing.Size(101, 31);
            this.textBoxCurrentYear.TabIndex = 0;
            this.textBoxCurrentYear.Text = "YEAR";
            this.textBoxCurrentYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 125);
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
            this.splitContainer.Size = new System.Drawing.Size(1110, 776);
            this.splitContainer.SplitterDistance = 750;
            this.splitContainer.TabIndex = 1;
            this.splitContainer.Text = "splitContainer1";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(750, 776);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Text = "dataGridView";
            // 
            // FormBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 901);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBudget";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAddExpense;
        private System.Windows.Forms.Button buttonAddIncome;
    }
}