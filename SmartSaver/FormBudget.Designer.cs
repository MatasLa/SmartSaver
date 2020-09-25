namespace TimeManager
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonNextYear = new System.Windows.Forms.Button();
            this.buttonPreviousYear = new System.Windows.Forms.Button();
            this.textBoxCurrentYear = new System.Windows.Forms.TextBox();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.buttonPreviousMonth = new System.Windows.Forms.Button();
            this.textBoxCurrentMonth = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.buttonNextYear);
            this.panelTop.Controls.Add(this.buttonPreviousYear);
            this.panelTop.Controls.Add(this.textBoxCurrentYear);
            this.panelTop.Controls.Add(this.buttonNextMonth);
            this.panelTop.Controls.Add(this.buttonPreviousMonth);
            this.panelTop.Controls.Add(this.textBoxCurrentMonth);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1110, 125);
            this.panelTop.TabIndex = 0;
            // 
            // buttonNextYear
            // 
            this.buttonNextYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextYear.Location = new System.Drawing.Point(643, 29);
            this.buttonNextYear.Name = "buttonNextYear";
            this.buttonNextYear.Size = new System.Drawing.Size(30, 26);
            this.buttonNextYear.TabIndex = 2;
            this.buttonNextYear.Text = ">";
            this.buttonNextYear.UseVisualStyleBackColor = true;
            this.buttonNextYear.Click += new System.EventHandler(this.ButtonNextYear_Click);
            // 
            // buttonPreviousYear
            // 
            this.buttonPreviousYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPreviousYear.Location = new System.Drawing.Point(422, 29);
            this.buttonPreviousYear.Name = "buttonPreviousYear";
            this.buttonPreviousYear.Size = new System.Drawing.Size(30, 26);
            this.buttonPreviousYear.TabIndex = 1;
            this.buttonPreviousYear.Text = "<";
            this.buttonPreviousYear.UseVisualStyleBackColor = true;
            this.buttonPreviousYear.Click += new System.EventHandler(this.ButtonPreviousYear_Click);
            // 
            // textBoxCurrentYear
            // 
            this.textBoxCurrentYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCurrentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCurrentYear.Location = new System.Drawing.Point(471, 29);
            this.textBoxCurrentYear.Name = "textBoxCurrentYear";
            this.textBoxCurrentYear.ReadOnly = true;
            this.textBoxCurrentYear.Size = new System.Drawing.Size(151, 26);
            this.textBoxCurrentYear.TabIndex = 0;
            this.textBoxCurrentYear.Text = "Current Year";
            this.textBoxCurrentYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCurrentYear.Click += new System.EventHandler(this.TestClick);
            // 
            // buttonNextMonth
            // 
            this.buttonNextMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextMonth.Location = new System.Drawing.Point(643, 61);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(30, 26);
            this.buttonNextMonth.TabIndex = 2;
            this.buttonNextMonth.Text = ">";
            this.buttonNextMonth.UseVisualStyleBackColor = true;
            this.buttonNextMonth.Click += new System.EventHandler(this.ButtonNextMonth_Click);
            // 
            // buttonPreviousMonth
            // 
            this.buttonPreviousMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPreviousMonth.Location = new System.Drawing.Point(422, 61);
            this.buttonPreviousMonth.Name = "buttonPreviousMonth";
            this.buttonPreviousMonth.Size = new System.Drawing.Size(30, 26);
            this.buttonPreviousMonth.TabIndex = 1;
            this.buttonPreviousMonth.Text = "<";
            this.buttonPreviousMonth.UseVisualStyleBackColor = true;
            this.buttonPreviousMonth.Click += new System.EventHandler(this.ButtonPreviousMonth_Click);
            // 
            // textBoxCurrentMonth
            // 
            this.textBoxCurrentMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCurrentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCurrentMonth.Location = new System.Drawing.Point(471, 61);
            this.textBoxCurrentMonth.Name = "textBoxCurrentMonth";
            this.textBoxCurrentMonth.ReadOnly = true;
            this.textBoxCurrentMonth.Size = new System.Drawing.Size(151, 26);
            this.textBoxCurrentMonth.TabIndex = 0;
            this.textBoxCurrentMonth.Text = "Current Month";
            this.textBoxCurrentMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCurrentMonth.Click += new System.EventHandler(this.TestClick);
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.White;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 125);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer.Panel1MinSize = 600;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.splitContainer.Panel2MinSize = 300;
            this.splitContainer.Size = new System.Drawing.Size(1110, 776);
            this.splitContainer.SplitterDistance = 750;
            this.splitContainer.TabIndex = 1;
            this.splitContainer.Text = "splitContainer1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(750, 776);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox textBoxCurrentMonth;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonNextMonth;
        private System.Windows.Forms.Button buttonPreviousMonth;
        private System.Windows.Forms.Button buttonNextYear;
        private System.Windows.Forms.Button buttonPreviousYear;
        private System.Windows.Forms.TextBox textBoxCurrentYear;
    }
}