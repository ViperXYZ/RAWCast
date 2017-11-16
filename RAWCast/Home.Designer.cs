namespace RAWCast
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.FolderLocation = new MetroFramework.Controls.MetroLabel();
            this.ImageListBox = new System.Windows.Forms.ListBox();
            this.PrevBtn = new MetroFramework.Controls.MetroTile();
            this.NextBtn = new MetroFramework.Controls.MetroTile();
            this.CastBtn = new MetroFramework.Controls.MetroTile();
            this.ExitBtn = new MetroFramework.Controls.MetroTile();
            this.SendLinkBtn = new MetroFramework.Controls.MetroTile();
            this.ShowDevicesBtn = new MetroFramework.Controls.MetroTile();
            this.SelectFolderBtn = new MetroFramework.Controls.MetroTile();
            this.ImagePreviewBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.FolderLocation);
            this.mainPanel.Controls.Add(this.ImageListBox);
            this.mainPanel.Controls.Add(this.PrevBtn);
            this.mainPanel.Controls.Add(this.NextBtn);
            this.mainPanel.Controls.Add(this.CastBtn);
            this.mainPanel.Controls.Add(this.ExitBtn);
            this.mainPanel.Controls.Add(this.SendLinkBtn);
            this.mainPanel.Controls.Add(this.ShowDevicesBtn);
            this.mainPanel.Controls.Add(this.SelectFolderBtn);
            this.mainPanel.Controls.Add(this.ImagePreviewBox);
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(16, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(710, 472);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // FolderLocation
            // 
            this.FolderLocation.AutoSize = true;
            this.FolderLocation.Location = new System.Drawing.Point(3, 65);
            this.FolderLocation.Name = "FolderLocation";
            this.FolderLocation.Size = new System.Drawing.Size(0, 0);
            this.FolderLocation.TabIndex = 17;
            this.FolderLocation.Click += new System.EventHandler(this.FolderLocation_Click);
            // 
            // ImageListBox
            // 
            this.ImageListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageListBox.FormattingEnabled = true;
            this.ImageListBox.Location = new System.Drawing.Point(7, 96);
            this.ImageListBox.Name = "ImageListBox";
            this.ImageListBox.Size = new System.Drawing.Size(178, 368);
            this.ImageListBox.TabIndex = 16;
            this.ImageListBox.SelectedIndexChanged += new System.EventHandler(this.ImageListBox_SelectedIndexChanged);
            // 
            // PrevBtn
            // 
            this.PrevBtn.ActiveControl = null;
            this.PrevBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PrevBtn.Location = new System.Drawing.Point(299, 419);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(94, 45);
            this.PrevBtn.TabIndex = 15;
            this.PrevBtn.Text = "Previous";
            this.PrevBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrevBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PrevBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.PrevBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.PrevBtn.UseSelectable = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.ActiveControl = null;
            this.NextBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextBtn.Location = new System.Drawing.Point(499, 419);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(94, 45);
            this.NextBtn.TabIndex = 14;
            this.NextBtn.Text = "Next";
            this.NextBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NextBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NextBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.NextBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.NextBtn.UseSelectable = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // CastBtn
            // 
            this.CastBtn.ActiveControl = null;
            this.CastBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CastBtn.Location = new System.Drawing.Point(399, 419);
            this.CastBtn.Name = "CastBtn";
            this.CastBtn.Size = new System.Drawing.Size(94, 45);
            this.CastBtn.TabIndex = 13;
            this.CastBtn.Text = "Cast";
            this.CastBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CastBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CastBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.CastBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.CastBtn.UseSelectable = true;
            this.CastBtn.Click += new System.EventHandler(this.CastBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.ActiveControl = null;
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.Location = new System.Drawing.Point(563, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(144, 55);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ExitBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ExitBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ExitBtn.UseSelectable = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SendLinkBtn
            // 
            this.SendLinkBtn.ActiveControl = null;
            this.SendLinkBtn.Location = new System.Drawing.Point(375, 3);
            this.SendLinkBtn.Name = "SendLinkBtn";
            this.SendLinkBtn.Size = new System.Drawing.Size(178, 55);
            this.SendLinkBtn.TabIndex = 11;
            this.SendLinkBtn.Text = "Send Link";
            this.SendLinkBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SendLinkBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SendLinkBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.SendLinkBtn.UseSelectable = true;
            this.SendLinkBtn.Click += new System.EventHandler(this.SendLinkBtn_Click);
            // 
            // ShowDevicesBtn
            // 
            this.ShowDevicesBtn.ActiveControl = null;
            this.ShowDevicesBtn.Location = new System.Drawing.Point(191, 3);
            this.ShowDevicesBtn.Name = "ShowDevicesBtn";
            this.ShowDevicesBtn.Size = new System.Drawing.Size(178, 55);
            this.ShowDevicesBtn.TabIndex = 10;
            this.ShowDevicesBtn.Text = "Show Devices";
            this.ShowDevicesBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ShowDevicesBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ShowDevicesBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ShowDevicesBtn.UseSelectable = true;
            this.ShowDevicesBtn.Click += new System.EventHandler(this.ShowDevicesBtn_Click);
            // 
            // SelectFolderBtn
            // 
            this.SelectFolderBtn.ActiveControl = null;
            this.SelectFolderBtn.Location = new System.Drawing.Point(7, 3);
            this.SelectFolderBtn.Name = "SelectFolderBtn";
            this.SelectFolderBtn.Size = new System.Drawing.Size(178, 55);
            this.SelectFolderBtn.TabIndex = 9;
            this.SelectFolderBtn.Text = "Select Folder";
            this.SelectFolderBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SelectFolderBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SelectFolderBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.SelectFolderBtn.UseSelectable = true;
            this.SelectFolderBtn.Click += new System.EventHandler(this.SelectFolderBtn_Click);
            // 
            // ImagePreviewBox
            // 
            this.ImagePreviewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePreviewBox.ErrorImage = null;
            this.ImagePreviewBox.Image = ((System.Drawing.Image)(resources.GetObject("ImagePreviewBox.Image")));
            this.ImagePreviewBox.InitialImage = null;
            this.ImagePreviewBox.Location = new System.Drawing.Point(191, 96);
            this.ImagePreviewBox.Name = "ImagePreviewBox";
            this.ImagePreviewBox.Size = new System.Drawing.Size(516, 317);
            this.ImagePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePreviewBox.TabIndex = 7;
            this.ImagePreviewBox.TabStop = false;
            this.ImagePreviewBox.Click += new System.EventHandler(this.ImagePreviewBox_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.mainPanel);
            this.Name = "Home";
            this.Resizable = false;
            this.Text = "RAWCast";
            this.Load += new System.EventHandler(this.Home_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox ImagePreviewBox;
        private MetroFramework.Controls.MetroTile SelectFolderBtn;
        private MetroFramework.Controls.MetroTile ExitBtn;
        private MetroFramework.Controls.MetroTile SendLinkBtn;
        private MetroFramework.Controls.MetroTile ShowDevicesBtn;
        private MetroFramework.Controls.MetroTile CastBtn;
        private MetroFramework.Controls.MetroTile NextBtn;
        private MetroFramework.Controls.MetroTile PrevBtn;
        private System.Windows.Forms.ListBox ImageListBox;
        private MetroFramework.Controls.MetroLabel FolderLocation;
    }
}

