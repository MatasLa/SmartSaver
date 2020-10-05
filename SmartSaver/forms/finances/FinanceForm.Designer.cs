﻿namespace Forms
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
            this.labelBalance = new System.Windows.Forms.Label();
            this.buttonAddEntry = new System.Windows.Forms.Button();
            this.buttonNextYear = new System.Windows.Forms.Button();
            this.buttonPreviousYear = new System.Windows.Forms.Button();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.buttonPreviousMonth = new System.Windows.Forms.Button();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelNetBalance = new System.Windows.Forms.Label();
            this.labelNetBalanceValue = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.labelBalance);
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
            // labelBalance
            // 
            this.labelBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBalance.AutoSize = true;
            this.labelBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelBalance.Location = new System.Drawing.Point(874, 42);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(91, 26);
            this.labelBalance.TabIndex = 9;
            this.labelBalance.Text = "Balance";
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
            this.buttonNextMonth.Location = new System.Drawing.Point(559, 48);
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
            this.buttonPreviousMonth.Location = new System.Drawing.Point(453, 48);
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
            this.splitContainer.Panel2.Controls.Add(this.labelNetBalanceValue);
            this.splitContainer.Panel2.Controls.Add(this.labelNetBalance);
            this.splitContainer.Panel2MinSize = 300;
            this.splitContainer.Size = new System.Drawing.Size(1110, 621);
            this.splitContainer.SplitterDistance = 749;
            this.splitContainer.SplitterWidth = 5;
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
            this.dataGridView.Size = new System.Drawing.Size(749, 621);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Text = "dataGridView";
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // labelNetBalance
            // 
            this.labelNetBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNetBalance.AutoSize = true;
            this.labelNetBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelNetBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNetBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelNetBalance.Location = new System.Drawing.Point(120, 307);
            this.labelNetBalance.Name = "labelNetBalance";
            this.labelNetBalance.Size = new System.Drawing.Size(137, 26);
            this.labelNetBalance.TabIndex = 9;
            this.labelNetBalance.Text = "Net Balance:";
            // 
            // labelNetBalanceValue
            // 
            this.labelNetBalanceValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNetBalanceValue.AutoSize = true;
            this.labelNetBalanceValue.BackColor = System.Drawing.Color.Transparent;
            this.labelNetBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNetBalanceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelNetBalanceValue.Location = new System.Drawing.Point(133, 350);
            this.labelNetBalanceValue.Name = "labelNetBalanceValue";
            this.labelNetBalanceValue.Size = new System.Drawing.Size(91, 26);
            this.labelNetBalanceValue.TabIndex = 9;
            this.labelNetBalanceValue.Text = "Balance";
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
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelNetBalanceValue;
        private System.Windows.Forms.Label labelNetBalance;
    }
}