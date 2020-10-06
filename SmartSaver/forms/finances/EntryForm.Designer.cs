namespace Forms
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
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTitle.BackColor = System.Drawing.Color.White;
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitle.Location = new System.Drawing.Point(29, 27);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.MaxLength = 60;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PlaceholderText = "Title";
            this.textBoxTitle.Size = new System.Drawing.Size(237, 23);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsualEscAndEnterKeyPress);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxValue.BackColor = System.Drawing.Color.White;
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValue.Location = new System.Drawing.Point(29, 79);
            this.textBoxValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxValue.MaxLength = 12;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.PlaceholderText = "Value";
            this.textBoxValue.Size = new System.Drawing.Size(237, 23);
            this.textBoxValue.TabIndex = 1;
            this.textBoxValue.TextChanged += new System.EventHandler(this.TextBoxValue_TextChanged);
            this.textBoxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxValue_KeyPress);
            // 
            // checkBoxMonthly
            // 
            this.checkBoxMonthly.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxMonthly.AutoSize = true;
            this.checkBoxMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMonthly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.checkBoxMonthly.Location = new System.Drawing.Point(109, 344);
            this.checkBoxMonthly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMonthly.Name = "checkBoxMonthly";
            this.checkBoxMonthly.Size = new System.Drawing.Size(83, 24);
            this.checkBoxMonthly.TabIndex = 2;
            this.checkBoxMonthly.Text = "Monthly";
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
            this.buttonOK.Location = new System.Drawing.Point(173, 395);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 25);
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
            this.buttonCancel.Location = new System.Drawing.Point(29, 394);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 25);
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
            this.buttonDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.buttonDate.Location = new System.Drawing.Point(83, 118);
            this.buttonDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(125, 25);
            this.buttonDate.TabIndex = 5;
            this.buttonDate.Text = "Select Date";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.ButtonDate_Click);
            this.buttonDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsualEscAndEnterKeyPress);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(35, 158);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 6;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.monthCalendar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsualEscAndEnterKeyPress);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(295, 447);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxMonthly);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxTitle);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.CheckBox checkBoxMonthly;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}