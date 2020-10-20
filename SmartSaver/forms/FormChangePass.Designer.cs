namespace ePiggy.forms
{
    partial class FormChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePass));
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.confirmButton = new ePiggy.Forms.CustomControls.ButtonWoc();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(139, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter new password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(139, 103);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(233, 23);
            this.password.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(139, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Confirm new password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(139, 183);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '•';
            this.confirmPassword.Size = new System.Drawing.Size(233, 23);
            this.confirmPassword.TabIndex = 1;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.BorderColor = System.Drawing.Color.Transparent;
            this.confirmButton.ButtonColor = System.Drawing.Color.MintCream;
            this.confirmButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.ForeColor = System.Drawing.Color.Transparent;
            this.confirmButton.Location = new System.Drawing.Point(188, 277);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.confirmButton.OnHoverButtonColor = System.Drawing.Color.LightCyan;
            this.confirmButton.OnHoverTextColor = System.Drawing.Color.SteelBlue;
            this.confirmButton.Size = new System.Drawing.Size(117, 33);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.TextColor = System.Drawing.Color.SteelBlue;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(102, 225);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(294, 49);
            this.errorMessage.TabIndex = 13;
            this.errorMessage.Text = "label3";
            this.errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormChangePass
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormChangePass";
            this.Text = "ePiggy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmPassword;
        private Forms.CustomControls.ButtonWoc confirmButton;
        private System.Windows.Forms.Label errorMessage;
    }
}