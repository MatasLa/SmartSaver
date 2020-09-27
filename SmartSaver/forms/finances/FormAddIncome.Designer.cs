﻿namespace SmartSaver.forms
{
    partial class FormAddIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddIncome));
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.checkBoxMonthly = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(307, 95);
            this.textBoxTitle.MaxLength = 60;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(200, 27);
            this.textBoxTitle.TabIndex = 0;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(116, 92);
            this.textBoxValue.MaxLength = 12;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(125, 27);
            this.textBoxValue.TabIndex = 1;
            this.textBoxValue.TextChanged += new System.EventHandler(this.TextBoxValue_TextChanged);
            this.textBoxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxValue_KeyPress);
            // 
            // checkBoxMonthly
            // 
            this.checkBoxMonthly.AutoSize = true;
            this.checkBoxMonthly.Location = new System.Drawing.Point(559, 98);
            this.checkBoxMonthly.Name = "checkBoxMonthly";
            this.checkBoxMonthly.Size = new System.Drawing.Size(85, 24);
            this.checkBoxMonthly.TabIndex = 2;
            this.checkBoxMonthly.Text = "Monthly";
            this.checkBoxMonthly.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.Location = new System.Drawing.Point(324, 167);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 228);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxMonthly);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddIncome";
            this.Text = "Add Income";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.CheckBox checkBoxMonthly;
        private System.Windows.Forms.Button buttonAdd;
    }
}