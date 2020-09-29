namespace SmartSaver.forms
{
    partial class FormAddExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddExpense));
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.checkBoxMonthly = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(25, 25);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.MaxLength = 60;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PlaceholderText = "Title";
            this.textBoxTitle.Size = new System.Drawing.Size(208, 23);
            this.textBoxTitle.TabIndex = 0;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(25, 74);
            this.textBoxValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxValue.MaxLength = 12;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.PlaceholderText = "Value";
            this.textBoxValue.Size = new System.Drawing.Size(208, 23);
            this.textBoxValue.TabIndex = 1;
            this.textBoxValue.TextChanged += new System.EventHandler(this.TextBoxValue_TextChanged);
            this.textBoxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxValue_KeyPress);
            // 
            // checkBoxMonthly
            // 
            this.checkBoxMonthly.AutoSize = true;
            this.checkBoxMonthly.Location = new System.Drawing.Point(95, 129);
            this.checkBoxMonthly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMonthly.Name = "checkBoxMonthly";
            this.checkBoxMonthly.Size = new System.Drawing.Size(71, 19);
            this.checkBoxMonthly.TabIndex = 2;
            this.checkBoxMonthly.Text = "Monthly";
            this.checkBoxMonthly.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(151, 172);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 22);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(25, 171);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(258, 220);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxMonthly);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Expense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.CheckBox checkBoxMonthly;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}