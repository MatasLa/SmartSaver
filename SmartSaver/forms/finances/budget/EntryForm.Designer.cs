﻿namespace ePiggy.Forms.Finances.Budget
{
    partial class EntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.checkBoxMonthly = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDate = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelImportance = new System.Windows.Forms.Label();
            this.comboBoxImportance = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTitle.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.SetFlowBreak(this.textBoxTitle, true);
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitle.Location = new System.Drawing.Point(40, 40);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(40, 40, 40, 20);
            this.textBoxTitle.MaxLength = 60;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PlaceholderText = "Title";
            this.textBoxTitle.Size = new System.Drawing.Size(220, 26);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsualEscAndEnterKeyPress);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxValue.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.SetFlowBreak(this.textBoxValue, true);
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValue.Location = new System.Drawing.Point(40, 106);
            this.textBoxValue.Margin = new System.Windows.Forms.Padding(40, 20, 40, 40);
            this.textBoxValue.MaxLength = 12;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.PlaceholderText = "Value";
            this.textBoxValue.Size = new System.Drawing.Size(220, 26);
            this.textBoxValue.TabIndex = 1;
            this.textBoxValue.TextChanged += new System.EventHandler(this.TextBoxValue_TextChanged);
            this.textBoxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxValue_KeyPress);
            // 
            // checkBoxMonthly
            // 
            this.checkBoxMonthly.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxMonthly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxMonthly, true);
            this.checkBoxMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMonthly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.checkBoxMonthly.Location = new System.Drawing.Point(90, 496);
            this.checkBoxMonthly.Margin = new System.Windows.Forms.Padding(90, 10, 0, 0);
            this.checkBoxMonthly.Name = "checkBoxMonthly";
            this.checkBoxMonthly.Size = new System.Drawing.Size(100, 30);
            this.checkBoxMonthly.TabIndex = 2;
            this.checkBoxMonthly.Text = "Monthly";
            this.checkBoxMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxMonthly.UseVisualStyleBackColor = true;
            this.checkBoxMonthly.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsualEscAndEnterKeyPress);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.buttonOK.Location = new System.Drawing.Point(175, 546);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 30);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "Add";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonAdd_Click);
            this.buttonOK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddAndCancelKeyPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.buttonCancel.Location = new System.Drawing.Point(25, 546);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(25, 20, 25, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddAndCancelKeyPress);
            // 
            // buttonDate
            // 
            this.buttonDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDate.FlatAppearance.BorderSize = 0;
            this.buttonDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.buttonDate, true);
            this.buttonDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.buttonDate.Location = new System.Drawing.Point(75, 220);
            this.buttonDate.Margin = new System.Windows.Forms.Padding(75, 20, 0, 10);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(150, 30);
            this.buttonDate.TabIndex = 5;
            this.buttonDate.Text = "Select Date";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.ButtonDate_Click);
            this.buttonDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsualEscAndEnterKeyPress);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(20, 270);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(20, 10, 9, 9);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 6;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.monthCalendar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsualEscAndEnterKeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBoxTitle);
            this.flowLayoutPanel1.Controls.Add(this.textBoxValue);
            this.flowLayoutPanel1.Controls.Add(this.labelImportance);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxImportance);
            this.flowLayoutPanel1.Controls.Add(this.buttonDate);
            this.flowLayoutPanel1.Controls.Add(this.monthCalendar);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxMonthly);
            this.flowLayoutPanel1.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel1.Controls.Add(this.buttonOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 600);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // labelImportance
            // 
            this.labelImportance.AutoSize = true;
            this.labelImportance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImportance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelImportance.Location = new System.Drawing.Point(25, 172);
            this.labelImportance.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.labelImportance.Name = "labelImportance";
            this.labelImportance.Size = new System.Drawing.Size(115, 25);
            this.labelImportance.TabIndex = 6;
            this.labelImportance.Text = "Importance:";
            // 
            // comboBoxImportance
            // 
            this.comboBoxImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxImportance, true);
            this.comboBoxImportance.FormattingEnabled = true;
            this.comboBoxImportance.Items.AddRange(new object[] {
            "Necessary",
            "High",
            "Medium",
            "Low",
            "Unnecessary"});
            this.comboBoxImportance.Location = new System.Drawing.Point(140, 172);
            this.comboBoxImportance.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxImportance.Name = "comboBoxImportance";
            this.comboBoxImportance.Size = new System.Drawing.Size(125, 28);
            this.comboBoxImportance.TabIndex = 2;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(300, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entry Form";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsualEscAndEnterKeyPress);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.CheckBox checkBoxMonthly;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxImportance;
        private System.Windows.Forms.Label labelImportance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}