namespace _2002807_Maeda_XtremeCinema8
{
    partial class Form1
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
            this.categoryList = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.Button();
            this.boxCategory = new System.Windows.Forms.GroupBox();
            this.labelAisle = new System.Windows.Forms.Label();
            this.locationOutput = new System.Windows.Forms.TextBox();
            this.boxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Action",
            "Sci-Fi",
            "Horror",
            "New Releases"});
            this.categoryList.Location = new System.Drawing.Point(6, 19);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(87, 95);
            this.categoryList.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(12, 158);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(120, 51);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // boxCategory
            // 
            this.boxCategory.Controls.Add(this.categoryList);
            this.boxCategory.Location = new System.Drawing.Point(12, 12);
            this.boxCategory.Name = "boxCategory";
            this.boxCategory.Size = new System.Drawing.Size(120, 140);
            this.boxCategory.TabIndex = 2;
            this.boxCategory.TabStop = false;
            this.boxCategory.Text = "Movie Categories";
            // 
            // labelAisle
            // 
            this.labelAisle.AutoSize = true;
            this.labelAisle.Location = new System.Drawing.Point(138, 22);
            this.labelAisle.Name = "labelAisle";
            this.labelAisle.Size = new System.Drawing.Size(93, 13);
            this.labelAisle.TabIndex = 3;
            this.labelAisle.Text = "Category Location";
            // 
            // locationOutput
            // 
            this.locationOutput.Location = new System.Drawing.Point(237, 19);
            this.locationOutput.Name = "locationOutput";
            this.locationOutput.Size = new System.Drawing.Size(100, 20);
            this.locationOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 221);
            this.Controls.Add(this.locationOutput);
            this.Controls.Add(this.labelAisle);
            this.Controls.Add(this.boxCategory);
            this.Controls.Add(this.search);
            this.Name = "Form1";
            this.Text = "Xtreme Cinema 8";
            this.boxCategory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox categoryList;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.GroupBox boxCategory;
        private System.Windows.Forms.Label labelAisle;
        private System.Windows.Forms.TextBox locationOutput;
    }
}

