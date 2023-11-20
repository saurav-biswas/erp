namespace ERP
{
    partial class mainfrm
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
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.iconButtonSettings = new FontAwesome.Sharp.IconButton();
            this.iconButtonReports = new FontAwesome.Sharp.IconButton();
            this.iconButtonTransaction = new FontAwesome.Sharp.IconButton();
            this.iconButtonMaster = new FontAwesome.Sharp.IconButton();
            this.iconButtonDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelmain = new System.Windows.Forms.Panel();
            this.main_menu.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(1254, 24);
            this.main_menu.TabIndex = 1;
            this.main_menu.Text = "Main Menu";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.masterToolStripMenuItem.Text = "Masters";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionToolStripMenuItem.Text = "Transactions";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelmenu.Controls.Add(this.iconButtonSettings);
            this.panelmenu.Controls.Add(this.iconButtonReports);
            this.panelmenu.Controls.Add(this.iconButtonTransaction);
            this.panelmenu.Controls.Add(this.iconButtonMaster);
            this.panelmenu.Controls.Add(this.iconButtonDashboard);
            this.panelmenu.Controls.Add(this.panelLogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 24);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(220, 582);
            this.panelmenu.TabIndex = 3;
            // 
            // iconButtonSettings
            // 
            this.iconButtonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSettings.FlatAppearance.BorderSize = 0;
            this.iconButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSettings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.iconButtonSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSettings.Location = new System.Drawing.Point(0, 312);
            this.iconButtonSettings.Name = "iconButtonSettings";
            this.iconButtonSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonSettings.Size = new System.Drawing.Size(220, 60);
            this.iconButtonSettings.TabIndex = 6;
            this.iconButtonSettings.Text = "Settings";
            this.iconButtonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSettings.UseVisualStyleBackColor = true;
            // 
            // iconButtonReports
            // 
            this.iconButtonReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonReports.FlatAppearance.BorderSize = 0;
            this.iconButtonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonReports.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.iconButtonReports.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReports.Location = new System.Drawing.Point(0, 252);
            this.iconButtonReports.Name = "iconButtonReports";
            this.iconButtonReports.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonReports.Size = new System.Drawing.Size(220, 60);
            this.iconButtonReports.TabIndex = 5;
            this.iconButtonReports.Text = "Reports";
            this.iconButtonReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonReports.UseVisualStyleBackColor = true;
            // 
            // iconButtonTransaction
            // 
            this.iconButtonTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonTransaction.FlatAppearance.BorderSize = 0;
            this.iconButtonTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTransaction.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonTransaction.IconChar = FontAwesome.Sharp.IconChar.PersonDigging;
            this.iconButtonTransaction.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTransaction.Location = new System.Drawing.Point(0, 192);
            this.iconButtonTransaction.Name = "iconButtonTransaction";
            this.iconButtonTransaction.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonTransaction.Size = new System.Drawing.Size(220, 60);
            this.iconButtonTransaction.TabIndex = 4;
            this.iconButtonTransaction.Text = "Transaction";
            this.iconButtonTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTransaction.UseVisualStyleBackColor = true;
            // 
            // iconButtonMaster
            // 
            this.iconButtonMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMaster.FlatAppearance.BorderSize = 0;
            this.iconButtonMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMaster.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMaster.IconChar = FontAwesome.Sharp.IconChar.Meteor;
            this.iconButtonMaster.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMaster.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMaster.Location = new System.Drawing.Point(0, 132);
            this.iconButtonMaster.Name = "iconButtonMaster";
            this.iconButtonMaster.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMaster.Size = new System.Drawing.Size(220, 60);
            this.iconButtonMaster.TabIndex = 3;
            this.iconButtonMaster.Text = "Master";
            this.iconButtonMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMaster.UseVisualStyleBackColor = true;
            // 
            // iconButtonDashboard
            // 
            this.iconButtonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDashboard.FlatAppearance.BorderSize = 0;
            this.iconButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButtonDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboard.Location = new System.Drawing.Point(0, 72);
            this.iconButtonDashboard.Name = "iconButtonDashboard";
            this.iconButtonDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonDashboard.Size = new System.Drawing.Size(220, 60);
            this.iconButtonDashboard.TabIndex = 2;
            this.iconButtonDashboard.Text = "Dashboard";
            this.iconButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDashboard.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 72);
            this.panelLogo.TabIndex = 0;
            // 
            // panelmain
            // 
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(220, 24);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1034, 582);
            this.panelmain.TabIndex = 4;
            // 
            // mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 606);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.main_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.main_menu;
            this.Name = "mainfrm";
            this.ShowIcon = false;
            this.Text = "Welcome to ERP";
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.panelmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonDashboard;
        private FontAwesome.Sharp.IconButton iconButtonReports;
        private FontAwesome.Sharp.IconButton iconButtonTransaction;
        private FontAwesome.Sharp.IconButton iconButtonMaster;
        private FontAwesome.Sharp.IconButton iconButtonSettings;
        private System.Windows.Forms.Panel panelmain;
    }
}

