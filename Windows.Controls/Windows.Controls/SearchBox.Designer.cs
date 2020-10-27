namespace Windows.Controls
{
    partial class SearchBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxSearchButton = new System.Windows.Forms.PictureBox();
            this.editControlSearch = new Windows.Controls.EditControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSearchButton
            // 
            this.pictureBoxSearchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxSearchButton.Image = global::Windows.Controls.Properties.Resources.Search_16x;
            this.pictureBoxSearchButton.Location = new System.Drawing.Point(82, 0);
            this.pictureBoxSearchButton.Name = "pictureBoxSearchButton";
            this.pictureBoxSearchButton.Size = new System.Drawing.Size(16, 18);
            this.pictureBoxSearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSearchButton.TabIndex = 1;
            this.pictureBoxSearchButton.TabStop = false;
            this.pictureBoxSearchButton.Click += new System.EventHandler(this.pictureBoxSearchButton_Click);
            // 
            // editControlSearch
            // 
            this.editControlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editControlSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editControlSearch.CueBanner = "";
            this.editControlSearch.Location = new System.Drawing.Point(3, 3);
            this.editControlSearch.Name = "editControlSearch";
            this.editControlSearch.ShowCueOnFocus = false;
            this.editControlSearch.Size = new System.Drawing.Size(79, 13);
            this.editControlSearch.TabIndex = 0;
            this.editControlSearch.Click += new System.EventHandler(this.EditControlSearch_Click);
            this.editControlSearch.TextChanged += new System.EventHandler(this.EditControlSearch_TextChanged);
            this.editControlSearch.DoubleClick += new System.EventHandler(this.EditControlSearch_DoubleClick);
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.editControlSearch);
            this.Controls.Add(this.pictureBoxSearchButton);
            this.MinimumSize = new System.Drawing.Size(100, 20);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(98, 18);
            this.FontChanged += new System.EventHandler(this.SearchBox_FontChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EditControl editControlSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearchButton;
    }
}
