namespace QuickDemo
{
    partial class FormMain
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
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.chkHasTail = new System.Windows.Forms.CheckBox();
            this.chkFilterTail = new System.Windows.Forms.CheckBox();
            this.lvAnimals = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHasTail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(411, 12);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(75, 23);
            this.btnResetFilter.TabIndex = 0;
            this.btnResetFilter.Text = "Reset";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(284, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(12, 12);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 2;
            // 
            // chkHasTail
            // 
            this.chkHasTail.AutoSize = true;
            this.chkHasTail.Location = new System.Drawing.Point(139, 16);
            this.chkHasTail.Name = "chkHasTail";
            this.chkHasTail.Size = new System.Drawing.Size(65, 17);
            this.chkHasTail.TabIndex = 3;
            this.chkHasTail.Text = "Has Tail";
            this.chkHasTail.UseVisualStyleBackColor = true;
            this.chkHasTail.CheckedChanged += new System.EventHandler(this.chkHasTail_CheckedChanged);
            // 
            // chkFilterTail
            // 
            this.chkFilterTail.AutoSize = true;
            this.chkFilterTail.Checked = true;
            this.chkFilterTail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilterTail.Location = new System.Drawing.Point(210, 16);
            this.chkFilterTail.Name = "chkFilterTail";
            this.chkFilterTail.Size = new System.Drawing.Size(68, 17);
            this.chkFilterTail.TabIndex = 4;
            this.chkFilterTail.Text = "Filter Tail";
            this.chkFilterTail.UseVisualStyleBackColor = true;
            this.chkFilterTail.CheckedChanged += new System.EventHandler(this.chkFilterTail_CheckedChanged);
            // 
            // lvAnimals
            // 
            this.lvAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCategory,
            this.colHasTail});
            this.lvAnimals.Location = new System.Drawing.Point(12, 41);
            this.lvAnimals.Name = "lvAnimals";
            this.lvAnimals.Size = new System.Drawing.Size(474, 322);
            this.lvAnimals.TabIndex = 5;
            this.lvAnimals.UseCompatibleStateImageBehavior = false;
            this.lvAnimals.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            // 
            // colHasTail
            // 
            this.colHasTail.Text = "Has Tail";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 375);
            this.Controls.Add(this.lvAnimals);
            this.Controls.Add(this.chkFilterTail);
            this.Controls.Add(this.chkHasTail);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnResetFilter);
            this.Name = "FormMain";
            this.Text = "Animal Classification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.CheckBox chkHasTail;
        private System.Windows.Forms.CheckBox chkFilterTail;
        private System.Windows.Forms.ListView lvAnimals;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colHasTail;
    }
}

