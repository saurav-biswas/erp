namespace ERP.Forms.Master
{
    partial class ProcessFrm
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
            this.textBoxProcessName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProcessPrefix = new System.Windows.Forms.Label();
            this.textBoxProcessPrefix = new System.Windows.Forms.TextBox();
            this.comboBoxProcessLevel = new System.Windows.Forms.ComboBox();
            this.labelProcessLevel = new System.Windows.Forms.Label();
            this.labelItemProcessName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProcessNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessLevelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrefixCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProcessName
            // 
            this.textBoxProcessName.Location = new System.Drawing.Point(104, 19);
            this.textBoxProcessName.Name = "textBoxProcessName";
            this.textBoxProcessName.Size = new System.Drawing.Size(161, 20);
            this.textBoxProcessName.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelProcessPrefix);
            this.panel1.Controls.Add(this.textBoxProcessPrefix);
            this.panel1.Controls.Add(this.comboBoxProcessLevel);
            this.panel1.Controls.Add(this.labelProcessLevel);
            this.panel1.Controls.Add(this.labelItemProcessName);
            this.panel1.Controls.Add(this.textBoxProcessName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 112);
            this.panel1.TabIndex = 17;
            // 
            // labelProcessPrefix
            // 
            this.labelProcessPrefix.AutoSize = true;
            this.labelProcessPrefix.Location = new System.Drawing.Point(22, 77);
            this.labelProcessPrefix.Name = "labelProcessPrefix";
            this.labelProcessPrefix.Size = new System.Drawing.Size(74, 13);
            this.labelProcessPrefix.TabIndex = 24;
            this.labelProcessPrefix.Text = "Process Prefix";
            // 
            // textBoxProcessPrefix
            // 
            this.textBoxProcessPrefix.Location = new System.Drawing.Point(104, 74);
            this.textBoxProcessPrefix.Name = "textBoxProcessPrefix";
            this.textBoxProcessPrefix.Size = new System.Drawing.Size(161, 20);
            this.textBoxProcessPrefix.TabIndex = 23;
            // 
            // comboBoxProcessLevel
            // 
            this.comboBoxProcessLevel.FormattingEnabled = true;
            this.comboBoxProcessLevel.Location = new System.Drawing.Point(104, 46);
            this.comboBoxProcessLevel.Name = "comboBoxProcessLevel";
            this.comboBoxProcessLevel.Size = new System.Drawing.Size(161, 21);
            this.comboBoxProcessLevel.TabIndex = 22;
            // 
            // labelProcessLevel
            // 
            this.labelProcessLevel.AutoSize = true;
            this.labelProcessLevel.Location = new System.Drawing.Point(22, 54);
            this.labelProcessLevel.Name = "labelProcessLevel";
            this.labelProcessLevel.Size = new System.Drawing.Size(74, 13);
            this.labelProcessLevel.TabIndex = 21;
            this.labelProcessLevel.Text = "Process Level";
            // 
            // labelItemProcessName
            // 
            this.labelItemProcessName.AutoSize = true;
            this.labelItemProcessName.Location = new System.Drawing.Point(22, 22);
            this.labelItemProcessName.Name = "labelItemProcessName";
            this.labelItemProcessName.Size = new System.Drawing.Size(76, 13);
            this.labelItemProcessName.TabIndex = 20;
            this.labelItemProcessName.Text = "Process Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessNameCol,
            this.ProcessLevelCol,
            this.PrefixCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 338);
            this.dataGridView1.TabIndex = 25;
            // 
            // ProcessNameCol
            // 
            this.ProcessNameCol.HeaderText = "Process Name";
            this.ProcessNameCol.Name = "ProcessNameCol";
            this.ProcessNameCol.ReadOnly = true;
            // 
            // ProcessLevelCol
            // 
            this.ProcessLevelCol.HeaderText = "Process Level";
            this.ProcessLevelCol.Name = "ProcessLevelCol";
            this.ProcessLevelCol.ReadOnly = true;
            // 
            // PrefixCol
            // 
            this.PrefixCol.HeaderText = "Prefix";
            this.PrefixCol.Name = "PrefixCol";
            this.PrefixCol.ReadOnly = true;
            // 
            // Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Process";
            this.Text = "Process";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxProcessName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelItemProcessName;
        private System.Windows.Forms.Label labelProcessLevel;
        private System.Windows.Forms.ComboBox comboBoxProcessLevel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessLevelCol;
        private System.Windows.Forms.Label labelProcessPrefix;
        private System.Windows.Forms.TextBox textBoxProcessPrefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrefixCol;
    }
}