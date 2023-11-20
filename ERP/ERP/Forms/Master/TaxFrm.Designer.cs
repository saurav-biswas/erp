namespace ERP.Forms.Master
{
    partial class TaxFrm
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
            this.comboBoxActive = new System.Windows.Forms.ComboBox();
            this.labelActive = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TAXNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxPercentageCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTaxName = new System.Windows.Forms.Label();
            this.textBoxTaxName = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.labelItemPercentage = new System.Windows.Forms.Label();
            this.textBoxPercentage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxActive
            // 
            this.comboBoxActive.FormattingEnabled = true;
            this.comboBoxActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxActive.Location = new System.Drawing.Point(314, 87);
            this.comboBoxActive.Name = "comboBoxActive";
            this.comboBoxActive.Size = new System.Drawing.Size(156, 21);
            this.comboBoxActive.TabIndex = 66;
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Location = new System.Drawing.Point(271, 90);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(37, 13);
            this.labelActive.TabIndex = 65;
            this.labelActive.Text = "Active";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TAXNameCol,
            this.TaxPercentageCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 161);
            this.dataGridView1.TabIndex = 30;
            // 
            // TAXNameCol
            // 
            this.TAXNameCol.HeaderText = "TAX Name";
            this.TAXNameCol.Name = "TAXNameCol";
            this.TAXNameCol.ReadOnly = true;
            // 
            // TaxPercentageCol
            // 
            this.TaxPercentageCol.HeaderText = "TAX Percentage";
            this.TaxPercentageCol.Name = "TaxPercentageCol";
            this.TaxPercentageCol.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxActive);
            this.panel1.Controls.Add(this.labelActive);
            this.panel1.Controls.Add(this.labelTaxName);
            this.panel1.Controls.Add(this.textBoxTaxName);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.iconButtonSave);
            this.panel1.Controls.Add(this.labelItemPercentage);
            this.panel1.Controls.Add(this.textBoxPercentage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 289);
            this.panel1.TabIndex = 29;
            // 
            // labelTaxName
            // 
            this.labelTaxName.AutoSize = true;
            this.labelTaxName.Location = new System.Drawing.Point(12, 15);
            this.labelTaxName.Name = "labelTaxName";
            this.labelTaxName.Size = new System.Drawing.Size(56, 13);
            this.labelTaxName.TabIndex = 34;
            this.labelTaxName.Text = "Tax Name";
            // 
            // textBoxTaxName
            // 
            this.textBoxTaxName.Location = new System.Drawing.Point(80, 12);
            this.textBoxTaxName.Name = "textBoxTaxName";
            this.textBoxTaxName.Size = new System.Drawing.Size(319, 20);
            this.textBoxTaxName.TabIndex = 33;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(395, 114);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 45);
            this.iconButton1.TabIndex = 28;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButtonSave.IconColor = System.Drawing.Color.Black;
            this.iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave.IconSize = 30;
            this.iconButtonSave.Location = new System.Drawing.Point(314, 114);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(75, 45);
            this.iconButtonSave.TabIndex = 26;
            this.iconButtonSave.UseVisualStyleBackColor = true;
            // 
            // labelItemPercentage
            // 
            this.labelItemPercentage.AutoSize = true;
            this.labelItemPercentage.Location = new System.Drawing.Point(12, 41);
            this.labelItemPercentage.Name = "labelItemPercentage";
            this.labelItemPercentage.Size = new System.Drawing.Size(62, 13);
            this.labelItemPercentage.TabIndex = 20;
            this.labelItemPercentage.Text = "Percentage";
            // 
            // textBoxPercentage
            // 
            this.textBoxPercentage.Location = new System.Drawing.Point(80, 38);
            this.textBoxPercentage.Name = "textBoxPercentage";
            this.textBoxPercentage.Size = new System.Drawing.Size(390, 20);
            this.textBoxPercentage.TabIndex = 16;
            // 
            // Tax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tax";
            this.Text = "Tax";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxActive;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTaxName;
        private System.Windows.Forms.TextBox textBoxTaxName;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private System.Windows.Forms.Label labelItemPercentage;
        private System.Windows.Forms.TextBox textBoxPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAXNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxPercentageCol;
    }
}