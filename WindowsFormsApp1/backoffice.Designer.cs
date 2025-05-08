namespace WindowsFormsApp1
{
    partial class backoffice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backoffice));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addChequeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalChequeValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.loginDetailsToolStripMenuItem,
            this.chequeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeItemsToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.retunToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // customizeItemsToolStripMenuItem
            // 
            this.customizeItemsToolStripMenuItem.Name = "customizeItemsToolStripMenuItem";
            this.customizeItemsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customizeItemsToolStripMenuItem.Text = "Customize Items";
            this.customizeItemsToolStripMenuItem.Click += new System.EventHandler(this.customizeItemsToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStockToolStripMenuItem,
            this.stockReportToolStripMenuItem,
            this.lowStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // addStockToolStripMenuItem
            // 
            this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            this.addStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addStockToolStripMenuItem.Text = "Add Stock";
            this.addStockToolStripMenuItem.Click += new System.EventHandler(this.addStockToolStripMenuItem_Click);
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockReportToolStripMenuItem.Text = "Stock Report";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salingReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salingReportToolStripMenuItem
            // 
            this.salingReportToolStripMenuItem.Name = "salingReportToolStripMenuItem";
            this.salingReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salingReportToolStripMenuItem.Text = "Saling Report";
            this.salingReportToolStripMenuItem.Click += new System.EventHandler(this.salingReportToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.changeAccountDetailsToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // changeAccountDetailsToolStripMenuItem
            // 
            this.changeAccountDetailsToolStripMenuItem.Name = "changeAccountDetailsToolStripMenuItem";
            this.changeAccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.changeAccountDetailsToolStripMenuItem.Text = "Change Account Details";
            this.changeAccountDetailsToolStripMenuItem.Click += new System.EventHandler(this.changeAccountDetailsToolStripMenuItem_Click);
            // 
            // loginDetailsToolStripMenuItem
            // 
            this.loginDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOffToolStripMenuItem,
            this.loginReportsToolStripMenuItem,
            this.logOffAccountsToolStripMenuItem});
            this.loginDetailsToolStripMenuItem.Name = "loginDetailsToolStripMenuItem";
            this.loginDetailsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.loginDetailsToolStripMenuItem.Text = "Login Details";
            // 
            // signOffToolStripMenuItem
            // 
            this.signOffToolStripMenuItem.Name = "signOffToolStripMenuItem";
            this.signOffToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.signOffToolStripMenuItem.Text = "Sign Off";
            this.signOffToolStripMenuItem.Click += new System.EventHandler(this.signOffToolStripMenuItem_Click);
            // 
            // loginReportsToolStripMenuItem
            // 
            this.loginReportsToolStripMenuItem.Name = "loginReportsToolStripMenuItem";
            this.loginReportsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.loginReportsToolStripMenuItem.Text = "Login Reports";
            this.loginReportsToolStripMenuItem.Click += new System.EventHandler(this.loginReportsToolStripMenuItem_Click);
            // 
            // logOffAccountsToolStripMenuItem
            // 
            this.logOffAccountsToolStripMenuItem.Name = "logOffAccountsToolStripMenuItem";
            this.logOffAccountsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.logOffAccountsToolStripMenuItem.Text = "LogOff Accounts";
            this.logOffAccountsToolStripMenuItem.Click += new System.EventHandler(this.logOffAccountsToolStripMenuItem_Click);
            // 
            // chequeToolStripMenuItem
            // 
            this.chequeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChequeToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.totalChequeValueToolStripMenuItem});
            this.chequeToolStripMenuItem.Name = "chequeToolStripMenuItem";
            this.chequeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.chequeToolStripMenuItem.Text = "Cheque";
            // 
            // addChequeToolStripMenuItem
            // 
            this.addChequeToolStripMenuItem.Name = "addChequeToolStripMenuItem";
            this.addChequeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addChequeToolStripMenuItem.Text = "Add Cheque";
            this.addChequeToolStripMenuItem.Click += new System.EventHandler(this.addChequeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // lowStockToolStripMenuItem
            // 
            this.lowStockToolStripMenuItem.Name = "lowStockToolStripMenuItem";
            this.lowStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lowStockToolStripMenuItem.Text = "Low Stock";
            this.lowStockToolStripMenuItem.Click += new System.EventHandler(this.lowStockToolStripMenuItem_Click);
            // 
            // totalChequeValueToolStripMenuItem
            // 
            this.totalChequeValueToolStripMenuItem.Name = "totalChequeValueToolStripMenuItem";
            this.totalChequeValueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.totalChequeValueToolStripMenuItem.Text = "Total Cheque Value";
            this.totalChequeValueToolStripMenuItem.Click += new System.EventHandler(this.totalChequeValueToolStripMenuItem_Click);
            // 
            // retunToolStripMenuItem
            // 
            this.retunToolStripMenuItem.Name = "retunToolStripMenuItem";
            this.retunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retunToolStripMenuItem.Text = "Return";
            this.retunToolStripMenuItem.Click += new System.EventHandler(this.retunToolStripMenuItem_Click);
            // 
            // backoffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(869, 564);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "backoffice";
            this.Text = "BackOffice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.backoffice_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAccountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addChequeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalChequeValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retunToolStripMenuItem;
    }
}