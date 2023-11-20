namespace ERP.Forms.Master.ItemsWindow
{
    partial class ItemGroups
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.labelItemType = new System.Windows.Forms.Label();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.labelItemItemGroup = new System.Windows.Forms.Label();
            this.textBoxItemGroup = new System.Windows.Forms.TextBox();
            this.ItemGroupCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemGroupCol,
            this.ItemTypeCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 283);
            this.dataGridView1.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.iconButtonSave);
            this.panel1.Controls.Add(this.labelItemType);
            this.panel1.Controls.Add(this.comboBoxItemType);
            this.panel1.Controls.Add(this.labelItemItemGroup);
            this.panel1.Controls.Add(this.textBoxItemGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 139);
            this.panel1.TabIndex = 21;
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
            // labelItemType
            // 
            this.labelItemType.AutoSize = true;
            this.labelItemType.Location = new System.Drawing.Point(22, 67);
            this.labelItemType.Name = "labelItemType";
            this.labelItemType.Size = new System.Drawing.Size(54, 13);
            this.labelItemType.TabIndex = 25;
            this.labelItemType.Text = "Item Type";
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.AutoCompleteCustomSource.AddRange(new string[] {
            "N/A",
            "Area",
            "Length"});
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Location = new System.Drawing.Point(123, 59);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(161, 21);
            this.comboBoxItemType.TabIndex = 24;
            // 
            // labelItemItemGroup
            // 
            this.labelItemItemGroup.AutoSize = true;
            this.labelItemItemGroup.Location = new System.Drawing.Point(22, 22);
            this.labelItemItemGroup.Name = "labelItemItemGroup";
            this.labelItemItemGroup.Size = new System.Drawing.Size(59, 13);
            this.labelItemItemGroup.TabIndex = 20;
            this.labelItemItemGroup.Text = "Item Group";
            // 
            // textBoxItemGroup
            // 
            this.textBoxItemGroup.Location = new System.Drawing.Point(123, 22);
            this.textBoxItemGroup.Name = "textBoxItemGroup";
            this.textBoxItemGroup.Size = new System.Drawing.Size(161, 20);
            this.textBoxItemGroup.TabIndex = 16;
            // 
            // ItemGroupCol
            // 
            this.ItemGroupCol.HeaderText = "Item Group";
            this.ItemGroupCol.Name = "ItemGroupCol";
            this.ItemGroupCol.ReadOnly = true;
            // 
            // ItemTypeCol
            // 
            this.ItemTypeCol.HeaderText = "Item Type";
            this.ItemTypeCol.Name = "ItemTypeCol";
            this.ItemTypeCol.ReadOnly = true;
            // 
            // ItemGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ItemGroups";
            this.Text = "ItemGroups";
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
        private System.Windows.Forms.Label labelItemType;
        private System.Windows.Forms.ComboBox comboBoxItemType;
        private System.Windows.Forms.Label labelItemItemGroup;
        private System.Windows.Forms.TextBox textBoxItemGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGroupCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTypeCol;
    }
}