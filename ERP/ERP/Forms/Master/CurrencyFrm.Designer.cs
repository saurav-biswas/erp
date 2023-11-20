namespace ERP.Forms.Master
{
    partial class CurrencyFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CurrencyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyRateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelExchangeRate = new System.Windows.Forms.Label();
            this.textBoxExchangeRate = new System.Windows.Forms.TextBox();
            this.labelCurrencyRate = new System.Windows.Forms.Label();
            this.textBoxCurrencyRate = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.labelItemCurrency = new System.Windows.Forms.Label();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrencyCol,
            this.CurrencyRateCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 311);
            this.dataGridView1.TabIndex = 26;
            // 
            // CurrencyCol
            // 
            this.CurrencyCol.HeaderText = "Currency";
            this.CurrencyCol.Name = "CurrencyCol";
            this.CurrencyCol.ReadOnly = true;
            // 
            // CurrencyRateCol
            // 
            this.CurrencyRateCol.HeaderText = "Currency Rate";
            this.CurrencyRateCol.Name = "CurrencyRateCol";
            this.CurrencyRateCol.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelExchangeRate);
            this.panel1.Controls.Add(this.textBoxExchangeRate);
            this.panel1.Controls.Add(this.labelCurrencyRate);
            this.panel1.Controls.Add(this.textBoxCurrencyRate);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.iconButtonSave);
            this.panel1.Controls.Add(this.labelItemCurrency);
            this.panel1.Controls.Add(this.textBoxCurrency);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 139);
            this.panel1.TabIndex = 25;
            // 
            // labelExchangeRate
            // 
            this.labelExchangeRate.AutoSize = true;
            this.labelExchangeRate.Location = new System.Drawing.Point(22, 95);
            this.labelExchangeRate.Name = "labelExchangeRate";
            this.labelExchangeRate.Size = new System.Drawing.Size(81, 13);
            this.labelExchangeRate.TabIndex = 32;
            this.labelExchangeRate.Text = "Exchange Rate";
            // 
            // textBoxExchangeRate
            // 
            this.textBoxExchangeRate.Location = new System.Drawing.Point(123, 92);
            this.textBoxExchangeRate.Name = "textBoxExchangeRate";
            this.textBoxExchangeRate.ReadOnly = true;
            this.textBoxExchangeRate.Size = new System.Drawing.Size(161, 20);
            this.textBoxExchangeRate.TabIndex = 31;
            // 
            // labelCurrencyRate
            // 
            this.labelCurrencyRate.AutoSize = true;
            this.labelCurrencyRate.Location = new System.Drawing.Point(22, 57);
            this.labelCurrencyRate.Name = "labelCurrencyRate";
            this.labelCurrencyRate.Size = new System.Drawing.Size(75, 13);
            this.labelCurrencyRate.TabIndex = 30;
            this.labelCurrencyRate.Text = "Currency Rate";
            // 
            // textBoxCurrencyRate
            // 
            this.textBoxCurrencyRate.Location = new System.Drawing.Point(123, 54);
            this.textBoxCurrencyRate.Name = "textBoxCurrencyRate";
            this.textBoxCurrencyRate.Size = new System.Drawing.Size(161, 20);
            this.textBoxCurrencyRate.TabIndex = 29;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(500, 67);
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
            this.iconButtonSave.Location = new System.Drawing.Point(500, 11);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(75, 45);
            this.iconButtonSave.TabIndex = 26;
            this.iconButtonSave.UseVisualStyleBackColor = true;
            // 
            // labelItemCurrency
            // 
            this.labelItemCurrency.AutoSize = true;
            this.labelItemCurrency.Location = new System.Drawing.Point(22, 22);
            this.labelItemCurrency.Name = "labelItemCurrency";
            this.labelItemCurrency.Size = new System.Drawing.Size(49, 13);
            this.labelItemCurrency.TabIndex = 20;
            this.labelItemCurrency.Text = "Currency";
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.Location = new System.Drawing.Point(123, 22);
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.Size = new System.Drawing.Size(161, 20);
            this.textBoxCurrency.TabIndex = 16;
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Currency";
            this.Text = "Currency";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private System.Windows.Forms.Label labelItemCurrency;
        private System.Windows.Forms.TextBox textBoxCurrency;
        private System.Windows.Forms.Label labelExchangeRate;
        private System.Windows.Forms.TextBox textBoxExchangeRate;
        private System.Windows.Forms.Label labelCurrencyRate;
        private System.Windows.Forms.TextBox textBoxCurrencyRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyRateCol;
    }
}