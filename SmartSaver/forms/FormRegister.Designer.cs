namespace Forms
{
    partial class FormRegister
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
            this.registerLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.passwordLabel1 = new System.Windows.Forms.Label();
            this.passwordInput1 = new System.Windows.Forms.TextBox();
            this.passwordInput2 = new System.Windows.Forms.TextBox();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.backToLoginButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.registerButton = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.registerLabel.Location = new System.Drawing.Point(164, 65);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(221, 30);
            this.registerLabel.TabIndex = 0;
            this.registerLabel.Text = "Welcome to ePiggy!";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.emailLabel.Location = new System.Drawing.Point(171, 119);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 19);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "E-mail";
            // 
            // emailInput
            // 
            this.emailInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailInput.Location = new System.Drawing.Point(171, 141);
            this.emailInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(206, 23);
            this.emailInput.TabIndex = 1;
            // 
            // passwordLabel1
            // 
            this.passwordLabel1.AutoSize = true;
            this.passwordLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.passwordLabel1.Location = new System.Drawing.Point(170, 187);
            this.passwordLabel1.Name = "passwordLabel1";
            this.passwordLabel1.Size = new System.Drawing.Size(67, 19);
            this.passwordLabel1.TabIndex = 4;
            this.passwordLabel1.Text = "Password";
            // 
            // passwordInput1
            // 
            this.passwordInput1.Location = new System.Drawing.Point(170, 209);
            this.passwordInput1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordInput1.Name = "passwordInput1";
            this.passwordInput1.PasswordChar = '•';
            this.passwordInput1.Size = new System.Drawing.Size(206, 23);
            this.passwordInput1.TabIndex = 2;
            // 
            // passwordInput2
            // 
            this.passwordInput2.Location = new System.Drawing.Point(170, 272);
            this.passwordInput2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordInput2.Name = "passwordInput2";
            this.passwordInput2.PasswordChar = '•';
            this.passwordInput2.Size = new System.Drawing.Size(206, 23);
            this.passwordInput2.TabIndex = 2;
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.passwordLabel2.Location = new System.Drawing.Point(170, 250);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(120, 19);
            this.passwordLabel2.TabIndex = 4;
            this.passwordLabel2.Text = "Confirm Password";
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.FlatAppearance.BorderSize = 0;
            this.backToLoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backToLoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backToLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLoginButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.backToLoginButton.Location = new System.Drawing.Point(27, 29);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(40, 39);
            this.backToLoginButton.TabIndex = 6;
            this.backToLoginButton.UseVisualStyleBackColor = true;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            this.backToLoginButton.MouseEnter += new System.EventHandler(this.backToLoginButton_MouseEnter);
            this.backToLoginButton.MouseLeave += new System.EventHandler(this.backToLoginButton_MouseLeave);
            // 
            // errorMessage
            // 
            this.errorMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(146, 307);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(250, 19);
            this.errorMessage.TabIndex = 7;
            this.errorMessage.Text = "label1";
            this.errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.BorderColor = System.Drawing.Color.Transparent;
            this.registerButton.ButtonColor = System.Drawing.Color.MintCream;
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerButton.ForeColor = System.Drawing.Color.Transparent;
            this.registerButton.Location = new System.Drawing.Point(209, 329);
            this.registerButton.Name = "registerButton";
            this.registerButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.registerButton.OnHoverButtonColor = System.Drawing.Color.LightCyan;
            this.registerButton.OnHoverTextColor = System.Drawing.Color.SteelBlue;
            this.registerButton.Size = new System.Drawing.Size(117, 33);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Register";
            this.registerButton.TextColor = System.Drawing.Color.SteelBlue;
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click_1);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.backToLoginButton);
            this.Controls.Add(this.passwordLabel2);
            this.Controls.Add(this.passwordInput2);
            this.Controls.Add(this.passwordInput1);
            this.Controls.Add(this.passwordLabel1);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.registerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ePiggy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label passwordLabel1;
        private System.Windows.Forms.TextBox passwordInput1;
        private System.Windows.Forms.TextBox passwordInput2;
        private System.Windows.Forms.Label passwordLabel2;
        private System.Windows.Forms.Button backToLoginButton;
        private System.Windows.Forms.Label errorMessage;
        private ePOSOne.btnProduct.Button_WOC registerButton;
    }
}