namespace ERP.Forms.Master
{
    partial class ItemWindow
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
            this.iconButtonItemTypes = new FontAwesome.Sharp.IconButton();
            this.iconButtonItemGroups = new FontAwesome.Sharp.IconButton();
            this.iconButtonColors = new FontAwesome.Sharp.IconButton();
            this.iconButtonItems = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // iconButtonItemTypes
            // 
            this.iconButtonItemTypes.IconChar = FontAwesome.Sharp.IconChar.Figma;
            this.iconButtonItemTypes.IconColor = System.Drawing.Color.Black;
            this.iconButtonItemTypes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonItemTypes.Location = new System.Drawing.Point(98, 52);
            this.iconButtonItemTypes.Name = "iconButtonItemTypes";
            this.iconButtonItemTypes.Size = new System.Drawing.Size(111, 97);
            this.iconButtonItemTypes.TabIndex = 2;
            this.iconButtonItemTypes.Text = "Item Types";
            this.iconButtonItemTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonItemTypes.UseVisualStyleBackColor = true;
            // 
            // iconButtonItemGroups
            // 
            this.iconButtonItemGroups.IconChar = FontAwesome.Sharp.IconChar.Figma;
            this.iconButtonItemGroups.IconColor = System.Drawing.Color.Black;
            this.iconButtonItemGroups.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonItemGroups.Location = new System.Drawing.Point(260, 52);
            this.iconButtonItemGroups.Name = "iconButtonItemGroups";
            this.iconButtonItemGroups.Size = new System.Drawing.Size(111, 97);
            this.iconButtonItemGroups.TabIndex = 3;
            this.iconButtonItemGroups.Text = "Item Groups";
            this.iconButtonItemGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonItemGroups.UseVisualStyleBackColor = true;
            // 
            // iconButtonColors
            // 
            this.iconButtonColors.IconChar = FontAwesome.Sharp.IconChar.Figma;
            this.iconButtonColors.IconColor = System.Drawing.Color.Black;
            this.iconButtonColors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonColors.Location = new System.Drawing.Point(420, 52);
            this.iconButtonColors.Name = "iconButtonColors";
            this.iconButtonColors.Size = new System.Drawing.Size(111, 97);
            this.iconButtonColors.TabIndex = 4;
            this.iconButtonColors.Text = "Colors";
            this.iconButtonColors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonColors.UseVisualStyleBackColor = true;
            // 
            // iconButtonItems
            // 
            this.iconButtonItems.IconChar = FontAwesome.Sharp.IconChar.Figma;
            this.iconButtonItems.IconColor = System.Drawing.Color.Black;
            this.iconButtonItems.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonItems.Location = new System.Drawing.Point(98, 209);
            this.iconButtonItems.Name = "iconButtonItems";
            this.iconButtonItems.Size = new System.Drawing.Size(111, 97);
            this.iconButtonItems.TabIndex = 5;
            this.iconButtonItems.Text = "Items";
            this.iconButtonItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonItems.UseVisualStyleBackColor = true;
            // 
            // ItemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButtonItems);
            this.Controls.Add(this.iconButtonColors);
            this.Controls.Add(this.iconButtonItemGroups);
            this.Controls.Add(this.iconButtonItemTypes);
            this.Name = "ItemWindow";
            this.Text = "Items";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonItemTypes;
        private FontAwesome.Sharp.IconButton iconButtonItemGroups;
        private FontAwesome.Sharp.IconButton iconButtonColors;
        private FontAwesome.Sharp.IconButton iconButtonItems;
    }
}