namespace ePiggy.Forms.Reports
{
    partial class FormIncomeVExpenses
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxTotal = new System.Windows.Forms.PictureBox();
            this.pictureBoxCurrent = new System.Windows.Forms.PictureBox();
            this.pictureBoxPrevious = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 107);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxTotal
            // 
            this.pictureBoxTotal.Location = new System.Drawing.Point(701, 3);
            this.pictureBoxTotal.MinimumSize = new System.Drawing.Size(343, 320);
            this.pictureBoxTotal.Name = "pictureBoxTotal";
            this.pictureBoxTotal.Size = new System.Drawing.Size(343, 320);
            this.pictureBoxTotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTotal.TabIndex = 0;
            this.pictureBoxTotal.TabStop = false;
            // 
            // pictureBoxCurrent
            // 
            this.pictureBoxCurrent.Location = new System.Drawing.Point(352, 3);
            this.pictureBoxCurrent.MinimumSize = new System.Drawing.Size(343, 320);
            this.pictureBoxCurrent.Name = "pictureBoxCurrent";
            this.pictureBoxCurrent.Size = new System.Drawing.Size(343, 320);
            this.pictureBoxCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCurrent.TabIndex = 0;
            this.pictureBoxCurrent.TabStop = false;
            // 
            // pictureBoxPrevious
            // 
            this.pictureBoxPrevious.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPrevious.MinimumSize = new System.Drawing.Size(343, 320);
            this.pictureBoxPrevious.Name = "pictureBoxPrevious";
            this.pictureBoxPrevious.Size = new System.Drawing.Size(343, 320);
            this.pictureBoxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrevious.TabIndex = 0;
            this.pictureBoxPrevious.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxPrevious);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxCurrent);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxTotal);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 107);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1110, 614);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // FormIncomeVExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 721);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(109)))), ((int)(((byte)(193)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormIncomeVExpenses";
            this.Text = "FormIncomeVExpenses";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxTotal;
        private System.Windows.Forms.PictureBox pictureBoxCurrent;
        private System.Windows.Forms.PictureBox pictureBoxPrevious;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}