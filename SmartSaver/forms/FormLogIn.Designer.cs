﻿namespace Forms
{
    partial class FormLogIn
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
            this.emailInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signInText = new System.Windows.Forms.Label();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.qouteText = new System.Windows.Forms.Label();
            this.forgotPassLink = new System.Windows.Forms.LinkLabel();
            this.noAccLink = new System.Windows.Forms.LinkLabel();
            this.noAccLable = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.loginButton = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // emailInput
            // 
            this.emailInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailInput.Location = new System.Drawing.Point(171, 151);
            this.emailInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(206, 23);
            this.emailInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(171, 215);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '•';
            this.passwordInput.Size = new System.Drawing.Size(206, 23);
            this.passwordInput.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.emailLabel.Location = new System.Drawing.Point(171, 129);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 19);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "E-mail";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.passwordLabel.Location = new System.Drawing.Point(171, 193);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 19);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // signInText
            // 
            this.signInText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signInText.AutoSize = true;
            this.signInText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signInText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.signInText.Location = new System.Drawing.Point(231, 91);
            this.signInText.Name = "signInText";
            this.signInText.Size = new System.Drawing.Size(84, 30);
            this.signInText.TabIndex = 9;
            this.signInText.Text = "Sign In";
            // 
            // logoPic
            // 
            this.logoPic.InitialImage = null;
            this.logoPic.Location = new System.Drawing.Point(145, 19);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(268, 69);
            this.logoPic.TabIndex = 10;
            this.logoPic.TabStop = false;
            // 
            // qouteText
            // 
            this.qouteText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.qouteText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.qouteText.Location = new System.Drawing.Point(22, 410);
            this.qouteText.Name = "qouteText";
            this.qouteText.Size = new System.Drawing.Size(490, 15);
            this.qouteText.TabIndex = 8;
            this.qouteText.Text = "Qoute";
            this.qouteText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forgotPassLink
            // 
            this.forgotPassLink.AutoSize = true;
            this.forgotPassLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forgotPassLink.LinkColor = System.Drawing.Color.Silver;
            this.forgotPassLink.Location = new System.Drawing.Point(277, 241);
            this.forgotPassLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotPassLink.Name = "forgotPassLink";
            this.forgotPassLink.Size = new System.Drawing.Size(100, 15);
            this.forgotPassLink.TabIndex = 5;
            this.forgotPassLink.TabStop = true;
            this.forgotPassLink.Text = "Forgot Password?";
            this.forgotPassLink.VisitedLinkColor = System.Drawing.Color.Silver;
            this.forgotPassLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // noAccLink
            // 
            this.noAccLink.AutoSize = true;
            this.noAccLink.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noAccLink.LinkColor = System.Drawing.Color.Silver;
            this.noAccLink.Location = new System.Drawing.Point(322, 333);
            this.noAccLink.Name = "noAccLink";
            this.noAccLink.Size = new System.Drawing.Size(61, 20);
            this.noAccLink.TabIndex = 7;
            this.noAccLink.TabStop = true;
            this.noAccLink.Text = "Sign Up";
            this.noAccLink.VisitedLinkColor = System.Drawing.Color.Silver;
            this.noAccLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.noAccLink_LinkClicked);
            // 
            // noAccLable
            // 
            this.noAccLable.AutoSize = true;
            this.noAccLable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noAccLable.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.noAccLable.Location = new System.Drawing.Point(162, 333);
            this.noAccLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noAccLable.Name = "noAccLable";
            this.noAccLable.Size = new System.Drawing.Size(153, 19);
            this.noAccLable.TabIndex = 6;
            this.noAccLable.Text = "Don\'t have an account?";
            // 
            // errorMessage
            // 
            this.errorMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(171, 310);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(212, 19);
            this.errorMessage.TabIndex = 11;
            this.errorMessage.Text = "label1";
            this.errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BorderColor = System.Drawing.Color.Transparent;
            this.loginButton.ButtonColor = System.Drawing.Color.MintCream;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.Transparent;
            this.loginButton.Location = new System.Drawing.Point(212, 269);
            this.loginButton.Name = "loginButton";
            this.loginButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.loginButton.OnHoverButtonColor = System.Drawing.Color.LightCyan;
            this.loginButton.OnHoverTextColor = System.Drawing.Color.SteelBlue;
            this.loginButton.Size = new System.Drawing.Size(117, 33);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Login";
            this.loginButton.TextColor = System.Drawing.Color.SteelBlue;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.logoPic);
            this.Controls.Add(this.signInText);
            this.Controls.Add(this.qouteText);
            this.Controls.Add(this.noAccLink);
            this.Controls.Add(this.noAccLable);
            this.Controls.Add(this.forgotPassLink);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.emailInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ePiggy";
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label signInText;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Label qouteText;
        private System.Windows.Forms.LinkLabel forgotPassLink;
        private System.Windows.Forms.LinkLabel noAccLink;
        private System.Windows.Forms.Label noAccLable;
        private System.Windows.Forms.Label errorMessage;
        private ePOSOne.btnProduct.Button_WOC loginButton;
    }
}