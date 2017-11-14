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
            this.SelectFolderBtn = new MetroFramework.Controls.MetroTile();
            this.ShowDevicesBtn = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImageList = new MetroFramework.Controls.MetroListView();
            this.ExitBtn = new MetroFramework.Controls.MetroTile();
            this.SendLinkBtn = new MetroFramework.Controls.MetroTile();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CastBtn = new MetroFramework.Controls.MetroTile();
            this.NextBtn = new MetroFramework.Controls.MetroTile();
            this.PrevBtn = new MetroFramework.Controls.MetroTile();
            this.ImagesLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.metroLabel1);
            this.mainPanel.Controls.Add(this.ImagesLabel);
            this.mainPanel.Controls.Add(this.NextBtn);
            this.mainPanel.Controls.Add(this.PrevBtn);
            this.mainPanel.Controls.Add(this.CastBtn);
            this.mainPanel.Controls.Add(this.SelectFolderBtn);
            this.mainPanel.Controls.Add(this.ShowDevicesBtn);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.ImageList);
            this.mainPanel.Controls.Add(this.ExitBtn);
            this.mainPanel.Controls.Add(this.SendLinkBtn);
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(16, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(710, 464);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // SelectFolderBtn
            // 
            this.SelectFolderBtn.ActiveControl = null;
            this.SelectFolderBtn.Location = new System.Drawing.Point(7, 3);
            this.SelectFolderBtn.Name = "SelectFolderBtn";
            this.SelectFolderBtn.Size = new System.Drawing.Size(178, 55);
            this.SelectFolderBtn.TabIndex = 9;
            this.SelectFolderBtn.Text = "Select Folder";
            this.SelectFolderBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SelectFolderBtn.UseSelectable = true;
            // 
            // ShowDevicesBtn
            // 
            this.ShowDevicesBtn.ActiveControl = null;
            this.ShowDevicesBtn.Location = new System.Drawing.Point(191, 3);
            this.ShowDevicesBtn.Name = "ShowDevicesBtn";
            this.ShowDevicesBtn.Size = new System.Drawing.Size(178, 55);
            this.ShowDevicesBtn.TabIndex = 8;
            this.ShowDevicesBtn.Text = "Show Devices";
            this.ShowDevicesBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ShowDevicesBtn.UseSelectable = true;
            this.ShowDevicesBtn.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ImageList
            // 
            this.ImageList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ImageList.FullRowSelect = true;
            this.ImageList.Location = new System.Drawing.Point(7, 87);
            this.ImageList.Name = "ImageList";
            this.ImageList.OwnerDraw = true;
            this.ImageList.Size = new System.Drawing.Size(178, 374);
            this.ImageList.TabIndex = 6;
            this.ImageList.UseCompatibleStateImageBehavior = false;
            this.ImageList.UseSelectable = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.ActiveControl = null;
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.Location = new System.Drawing.Point(559, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(148, 55);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ExitBtn.UseSelectable = true;
            // 
            // SendLinkBtn
            // 
            this.SendLinkBtn.ActiveControl = null;
            this.SendLinkBtn.Location = new System.Drawing.Point(375, 3);
            this.SendLinkBtn.Name = "SendLinkBtn";
            this.SendLinkBtn.Size = new System.Drawing.Size(178, 55);
            this.SendLinkBtn.TabIndex = 4;
            this.SendLinkBtn.Text = "Send Link";
            this.SendLinkBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SendLinkBtn.UseSelectable = true;
            this.SendLinkBtn.Click += new System.EventHandler(this.SendVideo_Click);
            // 
            // CastBtn
            // 
            this.CastBtn.ActiveControl = null;
            this.CastBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CastBtn.Location = new System.Drawing.Point(399, 411);
            this.CastBtn.Name = "CastBtn";
            this.CastBtn.Size = new System.Drawing.Size(110, 50);
            this.CastBtn.TabIndex = 10;
            this.CastBtn.Text = "Cast";
            this.CastBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CastBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.CastBtn.UseSelectable = true;
            // 
            // NextBtn
            // 
            this.NextBtn.ActiveControl = null;
            this.NextBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextBtn.Location = new System.Drawing.Point(515, 411);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(110, 50);
            this.NextBtn.TabIndex = 12;
            this.NextBtn.Text = "Next";
            this.NextBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NextBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.NextBtn.UseSelectable = true;
            // 
            // PrevBtn
            // 
            this.PrevBtn.ActiveControl = null;
            this.PrevBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PrevBtn.Location = new System.Drawing.Point(283, 411);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(110, 50);
            this.PrevBtn.TabIndex = 11;
            this.PrevBtn.Text = "Previous";
            this.PrevBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrevBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.PrevBtn.UseSelectable = true;
            this.PrevBtn.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // ImagesLabel
            // 
            this.ImagesLabel.AutoSize = true;
            this.ImagesLabel.Location = new System.Drawing.Point(3, 65);
            this.ImagesLabel.Name = "ImagesLabel";
            this.ImagesLabel.Size = new System.Drawing.Size(51, 19);
            this.ImagesLabel.TabIndex = 13;
            this.ImagesLabel.Text = "Images";
            this.ImagesLabel.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(191, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Image Preview";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click_1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroTile ExitBtn;
        private MetroFramework.Controls.MetroTile SendLinkBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroListView ImageList;
        private MetroFramework.Controls.MetroTile SelectFolderBtn;
        private MetroFramework.Controls.MetroTile ShowDevicesBtn;
        private MetroFramework.Controls.MetroTile NextBtn;
        private MetroFramework.Controls.MetroTile CastBtn;
        private MetroFramework.Controls.MetroTile PrevBtn;
        private MetroFramework.Controls.MetroLabel ImagesLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

