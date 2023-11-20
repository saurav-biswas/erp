namespace ERP.Forms.Master.Items
{
    partial class ItemType
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.labelMeasurementType = new System.Windows.Forms.Label();
            this.comboBoxMeasurementType = new System.Windows.Forms.ComboBox();
            this.labelItemItemType = new System.Windows.Forms.Label();
            this.textBoxItemType = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.iconButtonSave);
            this.panel1.Controls.Add(this.labelMeasurementType);
            this.panel1.Controls.Add(this.comboBoxMeasurementType);
            this.panel1.Controls.Add(this.labelItemItemType);
            this.panel1.Controls.Add(this.textBoxItemType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 139);
            this.panel1.TabIndex = 18;
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
            // labelMeasurementType
            // 
            this.labelMeasurementType.AutoSize = true;
            this.labelMeasurementType.Location = new System.Drawing.Point(22, 67);
            this.labelMeasurementType.Name = "labelMeasurementType";
            this.labelMeasurementType.Size = new System.Drawing.Size(98, 13);
            this.labelMeasurementType.TabIndex = 25;
            this.labelMeasurementType.Text = "Measurement Type";
            // 
            // comboBoxMeasurementType
            // 
            this.comboBoxMeasurementType.AutoCompleteCustomSource.AddRange(new string[] {
            "N/A",
            "Area",
            "Length"});
            this.comboBoxMeasurementType.FormattingEnabled = true;
            this.comboBoxMeasurementType.Location = new System.Drawing.Point(123, 59);
            this.comboBoxMeasurementType.Name = "comboBoxMeasurementType";
            this.comboBoxMeasurementType.Size = new System.Drawing.Size(161, 21);
            this.comboBoxMeasurementType.TabIndex = 24;
            // 
            // labelItemItemType
            // 
            this.labelItemItemType.AutoSize = true;
            this.labelItemItemType.Location = new System.Drawing.Point(22, 22);
            this.labelItemItemType.Name = "labelItemItemType";
            this.labelItemItemType.Size = new System.Drawing.Size(54, 13);
            this.labelItemItemType.TabIndex = 20;
            this.labelItemItemType.Text = "Item Type";
            // 
            // textBoxItemType
            // 
            this.textBoxItemType.Location = new System.Drawing.Point(123, 22);
            this.textBoxItemType.Name = "textBoxItemType";
            this.textBoxItemType.Size = new System.Drawing.Size(161, 20);
            this.textBoxItemType.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemTypeCol,
            this.MeasurementTypeCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 283);
            this.dataGridView1.TabIndex = 20;
            // 
            // ItemTypeCol
            // 
            this.ItemTypeCol.HeaderText = "Item Type";
            this.ItemTypeCol.Name = "ItemTypeCol";
            this.ItemTypeCol.ReadOnly = true;
            // 
            // MeasurementTypeCol
            // 
            this.MeasurementTypeCol.HeaderText = "Measurement Type";
            this.MeasurementTypeCol.Name = "MeasurementTypeCol";
            this.MeasurementTypeCol.ReadOnly = true;
            // 
            // ItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ItemType";
            this.Text = "ItemType";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelItemItemType;
        private System.Windows.Forms.TextBox textBoxItemType;
        private System.Windows.Forms.Label labelMeasurementType;
        private System.Windows.Forms.ComboBox comboBoxMeasurementType;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementTypeCol;
    }
}