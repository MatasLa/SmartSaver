namespace SmartSaver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panelReportsSubMenu = new System.Windows.Forms.Panel();
            this.buttonGoalReport = new System.Windows.Forms.Button();
            this.buttonIncomevExpenses = new System.Windows.Forms.Button();
            this.buttonNetWorth = new System.Windows.Forms.Button();
            this.buttonSpending = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.panelFinancesSubMenu = new System.Windows.Forms.Panel();
            this.buttonGoals = new System.Windows.Forms.Button();
            this.buttonExpenses = new System.Windows.Forms.Button();
            this.buttonIncome = new System.Windows.Forms.Button();
            this.buttonBudget = new System.Windows.Forms.Button();
            this.buttonFinances = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelReportsSubMenu.SuspendLayout();
            this.panelFinancesSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.buttonLogOut);
            this.panelSideMenu.Controls.Add(this.buttonHelp);
            this.panelSideMenu.Controls.Add(this.panelReportsSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonReports);
            this.panelSideMenu.Controls.Add(this.panelFinancesSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonFinances);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 735);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogOut.Location = new System.Drawing.Point(0, 557);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonLogOut.Size = new System.Drawing.Size(250, 45);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp.Location = new System.Drawing.Point(0, 512);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonHelp.Size = new System.Drawing.Size(250, 45);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // panelReportsSubMenu
            // 
            this.panelReportsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelReportsSubMenu.Controls.Add(this.buttonGoalReport);
            this.panelReportsSubMenu.Controls.Add(this.buttonIncomevExpenses);
            this.panelReportsSubMenu.Controls.Add(this.buttonNetWorth);
            this.panelReportsSubMenu.Controls.Add(this.buttonSpending);
            this.panelReportsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportsSubMenu.Location = new System.Drawing.Point(0, 351);
            this.panelReportsSubMenu.Name = "panelReportsSubMenu";
            this.panelReportsSubMenu.Size = new System.Drawing.Size(250, 161);
            this.panelReportsSubMenu.TabIndex = 2;
            this.panelReportsSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReportsSubMenu_Paint);
            // 
            // buttonGoalReport
            // 
            this.buttonGoalReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGoalReport.FlatAppearance.BorderSize = 0;
            this.buttonGoalReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoalReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGoalReport.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGoalReport.Location = new System.Drawing.Point(0, 120);
            this.buttonGoalReport.Name = "buttonGoalReport";
            this.buttonGoalReport.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonGoalReport.Size = new System.Drawing.Size(250, 40);
            this.buttonGoalReport.TabIndex = 0;
            this.buttonGoalReport.Text = "Goal Reports";
            this.buttonGoalReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoalReport.UseVisualStyleBackColor = true;
            this.buttonGoalReport.Click += new System.EventHandler(this.buttonGoalReport_Click);
            // 
            // buttonIncomevExpenses
            // 
            this.buttonIncomevExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIncomevExpenses.FlatAppearance.BorderSize = 0;
            this.buttonIncomevExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncomevExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIncomevExpenses.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonIncomevExpenses.Location = new System.Drawing.Point(0, 80);
            this.buttonIncomevExpenses.Name = "buttonIncomevExpenses";
            this.buttonIncomevExpenses.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonIncomevExpenses.Size = new System.Drawing.Size(250, 40);
            this.buttonIncomevExpenses.TabIndex = 0;
            this.buttonIncomevExpenses.Text = "Income v Expenses";
            this.buttonIncomevExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIncomevExpenses.UseVisualStyleBackColor = true;
            this.buttonIncomevExpenses.Click += new System.EventHandler(this.buttonIncomevExpenses_Click);
            // 
            // buttonNetWorth
            // 
            this.buttonNetWorth.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNetWorth.FlatAppearance.BorderSize = 0;
            this.buttonNetWorth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNetWorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNetWorth.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNetWorth.Location = new System.Drawing.Point(0, 40);
            this.buttonNetWorth.Name = "buttonNetWorth";
            this.buttonNetWorth.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonNetWorth.Size = new System.Drawing.Size(250, 40);
            this.buttonNetWorth.TabIndex = 0;
            this.buttonNetWorth.Text = "Net Worth";
            this.buttonNetWorth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNetWorth.UseVisualStyleBackColor = true;
            this.buttonNetWorth.Click += new System.EventHandler(this.buttonNetWorth_Click);
            // 
            // buttonSpending
            // 
            this.buttonSpending.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSpending.FlatAppearance.BorderSize = 0;
            this.buttonSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSpending.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSpending.Location = new System.Drawing.Point(0, 0);
            this.buttonSpending.Name = "buttonSpending";
            this.buttonSpending.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSpending.Size = new System.Drawing.Size(250, 40);
            this.buttonSpending.TabIndex = 0;
            this.buttonSpending.Text = "Spending";
            this.buttonSpending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSpending.UseVisualStyleBackColor = true;
            this.buttonSpending.Click += new System.EventHandler(this.buttonSpending_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReports.FlatAppearance.BorderSize = 0;
            this.buttonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReports.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReports.Location = new System.Drawing.Point(0, 306);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonReports.Size = new System.Drawing.Size(250, 45);
            this.buttonReports.TabIndex = 1;
            this.buttonReports.Text = "Reports";
            this.buttonReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // panelFinancesSubMenu
            // 
            this.panelFinancesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelFinancesSubMenu.Controls.Add(this.buttonGoals);
            this.panelFinancesSubMenu.Controls.Add(this.buttonExpenses);
            this.panelFinancesSubMenu.Controls.Add(this.buttonIncome);
            this.panelFinancesSubMenu.Controls.Add(this.buttonBudget);
            this.panelFinancesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFinancesSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelFinancesSubMenu.Name = "panelFinancesSubMenu";
            this.panelFinancesSubMenu.Size = new System.Drawing.Size(250, 161);
            this.panelFinancesSubMenu.TabIndex = 2;
            this.panelFinancesSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFinancesSubMenu_Paint);
            // 
            // buttonGoals
            // 
            this.buttonGoals.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGoals.FlatAppearance.BorderSize = 0;
            this.buttonGoals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGoals.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGoals.Location = new System.Drawing.Point(0, 120);
            this.buttonGoals.Name = "buttonGoals";
            this.buttonGoals.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonGoals.Size = new System.Drawing.Size(250, 40);
            this.buttonGoals.TabIndex = 0;
            this.buttonGoals.Text = "Goals";
            this.buttonGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoals.UseVisualStyleBackColor = true;
            this.buttonGoals.Click += new System.EventHandler(this.buttonGoals_Click);
            // 
            // buttonExpenses
            // 
            this.buttonExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExpenses.FlatAppearance.BorderSize = 0;
            this.buttonExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExpenses.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExpenses.Location = new System.Drawing.Point(0, 80);
            this.buttonExpenses.Name = "buttonExpenses";
            this.buttonExpenses.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonExpenses.Size = new System.Drawing.Size(250, 40);
            this.buttonExpenses.TabIndex = 0;
            this.buttonExpenses.Text = "Expenses";
            this.buttonExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExpenses.UseVisualStyleBackColor = true;
            this.buttonExpenses.Click += new System.EventHandler(this.buttonExpenses_Click);
            // 
            // buttonIncome
            // 
            this.buttonIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIncome.FlatAppearance.BorderSize = 0;
            this.buttonIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIncome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonIncome.Location = new System.Drawing.Point(0, 40);
            this.buttonIncome.Name = "buttonIncome";
            this.buttonIncome.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonIncome.Size = new System.Drawing.Size(250, 40);
            this.buttonIncome.TabIndex = 0;
            this.buttonIncome.Text = "Income";
            this.buttonIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIncome.UseVisualStyleBackColor = true;
            this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
            // 
            // buttonBudget
            // 
            this.buttonBudget.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBudget.FlatAppearance.BorderSize = 0;
            this.buttonBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBudget.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBudget.Location = new System.Drawing.Point(0, 0);
            this.buttonBudget.Name = "buttonBudget";
            this.buttonBudget.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonBudget.Size = new System.Drawing.Size(250, 40);
            this.buttonBudget.TabIndex = 0;
            this.buttonBudget.Text = "Budget";
            this.buttonBudget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBudget.UseVisualStyleBackColor = true;
            this.buttonBudget.Click += new System.EventHandler(this.buttonBudget_Click);
            // 
            // buttonFinances
            // 
            this.buttonFinances.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFinances.FlatAppearance.BorderSize = 0;
            this.buttonFinances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFinances.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFinances.Location = new System.Drawing.Point(0, 100);
            this.buttonFinances.Name = "buttonFinances";
            this.buttonFinances.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonFinances.Size = new System.Drawing.Size(250, 45);
            this.buttonFinances.TabIndex = 1;
            this.buttonFinances.Text = "Finances";
            this.buttonFinances.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFinances.UseVisualStyleBackColor = true;
            this.buttonFinances.Click += new System.EventHandler(this.buttonFinances_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1360, 735);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1378, 782);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelReportsSubMenu.ResumeLayout(false);
            this.panelFinancesSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelFinancesSubMenu;
        private System.Windows.Forms.Button buttonGoals;
        private System.Windows.Forms.Button buttonExpenses;
        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonBudget;
        private System.Windows.Forms.Button buttonFinances;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Panel panelReportsSubMenu;
        private System.Windows.Forms.Button buttonGoalReport;
        private System.Windows.Forms.Button buttonIncomevExpenses;
        private System.Windows.Forms.Button buttonNetWorth;
        private System.Windows.Forms.Button buttonSpending;
        private System.Windows.Forms.Button buttonReports;
    }
}

