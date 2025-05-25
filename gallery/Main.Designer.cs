namespace gallery
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            AddFolder = new Button();
            button1 = new Button();
            AlbumsPanel = new Panel();
            FoldPrpanel = new Panel();
            FolderPanel = new Panel();
            panel1 = new Panel();
            ExitBtn = new Button();
            AddPhoto = new Button();
            label2 = new Label();
            FolderPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(309, 54);
            label1.TabIndex = 0;
            label1.Text = "Your own album";
            // 
            // AddFolder
            // 
            AddFolder.BackColor = Color.FromArgb(185, 221, 255);
            AddFolder.BackgroundImageLayout = ImageLayout.None;
            AddFolder.FlatAppearance.BorderSize = 0;
            AddFolder.FlatStyle = FlatStyle.Flat;
            AddFolder.Font = new Font("Segoe UI", 30F);
            AddFolder.Location = new Point(483, 12);
            AddFolder.Name = "AddFolder";
            AddFolder.Size = new Size(305, 65);
            AddFolder.TabIndex = 1;
            AddFolder.Text = "Add Folder ";
            AddFolder.UseVisualStyleBackColor = false;
            AddFolder.Click += AddFolder_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(185, 221, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 88);
            button1.Name = "button1";
            button1.Size = new Size(272, 209);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // AlbumsPanel
            // 
            AlbumsPanel.BackColor = Color.FromArgb(185, 221, 255);
            AlbumsPanel.Location = new Point(12, 180);
            AlbumsPanel.Name = "AlbumsPanel";
            AlbumsPanel.Size = new Size(879, 251);
            AlbumsPanel.TabIndex = 3;
            // 
            // FoldPrpanel
            // 
            FoldPrpanel.BackColor = Color.Green;
            FoldPrpanel.Location = new Point(12, 12);
            FoldPrpanel.Name = "FoldPrpanel";
            FoldPrpanel.Size = new Size(0, 428);
            FoldPrpanel.TabIndex = 4;
            // 
            // FolderPanel
            // 
            FolderPanel.Anchor = AnchorStyles.None;
            FolderPanel.BackColor = Color.Yellow;
            FolderPanel.Controls.Add(panel1);
            FolderPanel.Location = new Point(12, 12);
            FolderPanel.Name = "FolderPanel";
            FolderPanel.Size = new Size(879, 428);
            FolderPanel.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(ExitBtn);
            panel1.Controls.Add(AddPhoto);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 51);
            panel1.TabIndex = 0;
            // 
            // ExitBtn
            // 
            ExitBtn.Font = new Font("Segoe UI", 20F);
            ExitBtn.Location = new Point(804, 0);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(72, 51);
            ExitBtn.TabIndex = 7;
            ExitBtn.Text = "X";
            ExitBtn.UseVisualStyleBackColor = true;
            // 
            // AddPhoto
            // 
            AddPhoto.FlatAppearance.BorderSize = 0;
            AddPhoto.FlatStyle = FlatStyle.Flat;
            AddPhoto.Font = new Font("Segoe UI", 12F);
            AddPhoto.Location = new Point(682, 3);
            AddPhoto.Name = "AddPhoto";
            AddPhoto.Size = new Size(116, 36);
            AddPhoto.TabIndex = 6;
            AddPhoto.Text = "Add Photo";
            AddPhoto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 15);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 0;
            label2.Text = "Album Name";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(185, 221, 255);
            ClientSize = new Size(903, 443);
            Controls.Add(FolderPanel);
            Controls.Add(FoldPrpanel);
            Controls.Add(AlbumsPanel);
            Controls.Add(button1);
            Controls.Add(AddFolder);
            Controls.Add(label1);
            Name = "Main";
            Text = "Form1";
            SizeChanged += Main_SizeChanged;
            FolderPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddFolder;
        private Button button1;
        private Panel AlbumsPanel;
        private Panel FoldPrpanel;
        private Panel FolderPanel;
        private Panel panel1;
        private Label label2;
        private Button AddPhoto;
        private Button ExitBtn;
    }
}
