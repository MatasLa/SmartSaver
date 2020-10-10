namespace ePiggy.forms.finances
{
    partial class MultiEntryInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiEntryInfoForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelValueText = new System.Windows.Forms.Label();
            this.labelTotalValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelTitle.Location = new System.Drawing.Point(100, 114);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(199, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Multiple Entries";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValueText
            // 
            this.labelValueText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelValueText.AutoSize = true;
            this.labelValueText.BackColor = System.Drawing.Color.Transparent;
            this.labelValueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelValueText.Location = new System.Drawing.Point(125, 210);
            this.labelValueText.Name = "labelValueText";
            this.labelValueText.Size = new System.Drawing.Size(175, 31);
            this.labelValueText.TabIndex = 0;
            this.labelValueText.Text = "Total Amount";
            this.labelValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalValue.AutoSize = true;
            this.labelTotalValue.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.labelTotalValue.Location = new System.Drawing.Point(125, 295);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.Size = new System.Drawing.Size(107, 31);
            this.labelTotalValue.TabIndex = 0;
            this.labelTotalValue.Text = "Amount";
            this.labelTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultiEntryInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 621);
            this.Controls.Add(this.labelTotalValue);
            this.Controls.Add(this.labelValueText);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiEntryInfoForm";
            this.Text = "EntryInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelValueText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelTotalValue;
    }
}