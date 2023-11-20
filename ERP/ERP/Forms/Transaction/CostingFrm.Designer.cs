namespace ERP.Forms.Transaction
{
    partial class CostingFrm
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
            this.ItemCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonCopy = new FontAwesome.Sharp.IconButton();
            this.iconButtonExport = new FontAwesome.Sharp.IconButton();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.iconButtonEdit = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCodeCol,
            this.ItemNameCol,
            this.ColorCol,
            this.ValueCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 389);
            this.dataGridView1.TabIndex = 28;
            // 
            // ItemCodeCol
            // 
            this.ItemCodeCol.HeaderText = "Item Code";
            this.ItemCodeCol.Name = "ItemCodeCol";
            this.ItemCodeCol.ReadOnly = true;
            // 
            // ItemNameCol
            // 
            this.ItemNameCol.HeaderText = "Item Name";
            this.ItemNameCol.Name = "ItemNameCol";
            this.ItemNameCol.ReadOnly = true;
            // 
            // ColorCol
            // 
            this.ColorCol.HeaderText = "Color";
            this.ColorCol.Name = "ColorCol";
            this.ColorCol.ReadOnly = true;
            // 
            // ValueCol
            // 
            this.ValueCol.HeaderText = "Value";
            this.ValueCol.Name = "ValueCol";
            this.ValueCol.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonClose);
            this.panel1.Controls.Add(this.iconButtonCopy);
            this.panel1.Controls.Add(this.iconButtonExport);
            this.panel1.Controls.Add(this.iconButtonDelete);
            this.panel1.Controls.Add(this.iconButtonEdit);
            this.panel1.Controls.Add(this.iconButtonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 27;
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButtonClose.IconColor = System.Drawing.Color.Black;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 30;
            this.iconButtonClose.Location = new System.Drawing.Point(534, 12);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(75, 45);
            this.iconButtonClose.TabIndex = 5;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            // 
            // iconButtonCopy
            // 
            this.iconButtonCopy.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.iconButtonCopy.IconColor = System.Drawing.Color.Black;
            this.iconButtonCopy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCopy.IconSize = 30;
            this.iconButtonCopy.Location = new System.Drawing.Point(326, 12);
            this.iconButtonCopy.Name = "iconButtonCopy";
            this.iconButtonCopy.Size = new System.Drawing.Size(75, 45);
            this.iconButtonCopy.TabIndex = 4;
            this.iconButtonCopy.UseVisualStyleBackColor = true;
            // 
            // iconButtonExport
            // 
            this.iconButtonExport.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.iconButtonExport.IconColor = System.Drawing.Color.Black;
            this.iconButtonExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExport.IconSize = 30;
            this.iconButtonExport.Location = new System.Drawing.Point(427, 12);
            this.iconButtonExport.Name = "iconButtonExport";
            this.iconButtonExport.Size = new System.Drawing.Size(75, 45);
            this.iconButtonExport.TabIndex = 3;
            this.iconButtonExport.UseVisualStyleBackColor = true;
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonDelete.IconColor = System.Drawing.Color.Black;
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.IconSize = 30;
            this.iconButtonDelete.Location = new System.Drawing.Point(223, 12);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(75, 45);
            this.iconButtonDelete.TabIndex = 2;
            this.iconButtonDelete.UseVisualStyleBackColor = true;
            // 
            // iconButtonEdit
            // 
            this.iconButtonEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonEdit.IconColor = System.Drawing.Color.Black;
            this.iconButtonEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEdit.IconSize = 30;
            this.iconButtonEdit.Location = new System.Drawing.Point(120, 12);
            this.iconButtonEdit.Name = "iconButtonEdit";
            this.iconButtonEdit.Size = new System.Drawing.Size(75, 45);
            this.iconButtonEdit.TabIndex = 1;
            this.iconButtonEdit.UseVisualStyleBackColor = true;
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButtonAdd.IconColor = System.Drawing.Color.Black;
            this.iconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdd.IconSize = 30;
            this.iconButtonAdd.Location = new System.Drawing.Point(22, 12);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Size = new System.Drawing.Size(75, 45);
            this.iconButtonAdd.TabIndex = 0;
            this.iconButtonAdd.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 450);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Costing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Costing";
            this.Text = "Costing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton iconButtonCopy;
        private FontAwesome.Sharp.IconButton iconButtonExport;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private FontAwesome.Sharp.IconButton iconButtonEdit;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueCol;
    }
}