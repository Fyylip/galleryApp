using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace gallery
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.SizeChanged += Main_SizeChanged;
        }

        //To ¿eby by³o responsywne
        public void Main_SizeChanged(object sender, EventArgs e)
        {
            float width = 0.9f;
            float height = 0.7f;

            AlbumsPanel.Width = (int)(this.Width * width);
            AlbumsPanel.Height = (int)(this.Height * height);
            AlbumsPanel.Location = new Point(
                (int)(this.Width * (1 - width) / 2),
                (int)(this.Height * (1 - height) / 2)
            );
            FolderPanel.Width = (int)(this.Width * width);
            FolderPanel.Height = (int)(this.Height * height);
            FolderPanel.Location = new Point(
                (int)(this.Width * (1 - width) / 2),
                (int)(this.Height * (1 - height) / 2)
            );

            RearrangePictures();
        }
        //To dodaje foldery mo¿esz tego u¿yæ do dodawania zdjêæ
        private void AddFolder_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("Vega-Album/Folder.png");

            string AlbumName = Interaction.InputBox(
                    "Podaj nazwe folderu"
                );

            PictureBox pb = new PictureBox();
            pb.Image = img;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Width = 100;
            pb.Height = 100;
            pb.Margin = new Padding(0);

            Label lbl = new Label();
            lbl.Text = AlbumName;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Width = pb.Width;
            lbl.Height = 20;

            Panel container = new Panel();
            container.Width = pb.Width;
            container.Height = pb.Height + lbl.Height;
            container.Margin = new Padding(0);
            container.Name = "Folder" + AlbumsPanel.Controls.Count;

            pb.Location = new Point(0, 0);
            lbl.Location = new Point(0, pb.Height);

            container.Click += Container_Click;
            pb.Click += Container_Click;
            lbl.Click += Container_Click;

            container.Controls.Add(pb);
            container.Controls.Add(lbl);
            AlbumsPanel.Controls.Add(container);

            RearrangePictures();
        }
        // To odpala Folder i tam musz¹ byæ dodawane zdjêcia trzba napisaæ jakiegoœ if, ¿e jak klikniesz w folder 1 to poka¿e jego zawartoœæ dlatego jakoœ trzeba to zapisywaæ z nazw¹ foderu albo nadawaæ im id
        private void Container_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            Panel parentPanel = clickedControl.Parent as Panel;

            string folderName = parentPanel?.Name ?? "Nieznany";

            MessageBox.Show("Klikniêto folder: " + folderName);
            float width = 0.9f;
            float height = 0.7f;
            FolderPanel.Width = (int)(this.Width * width);
            FolderPanel.Height = (int)(this.Height * height);
            FolderPanel.Location = new Point(
                (int)(this.Width * (1 - width) / 2),
                (int)(this.Height * (1 - height) / 2)
            );

            

            //Panel FolderPanel = new Panel
            //{
            //    Width = 800,
            //    Height = 600,
            //    Location = new Point(
            //        (int)(this.Width * (1 - 0.4f) / 2),
            //        (int)(this.Height * (1 - 0.6f) / 2)
            //    ),
            //    BackColor = Color.Black,
            //    Dock = DockStyle.Fill
            //};

            //this.Controls.Add(FolderPanel);
            //FolderPanel.BringToFront();
        }
        // to w sumie nie wiem co robi ale chyba ustawia label pod zdjêciami
        private void RearrangePictures()
        {
            int spacing = 5;
            int itemWidth = 100;
            int itemHeight = 120; // uwzglêdniaj¹c label

            int maxPerRow = Math.Max(1, (AlbumsPanel.Width + spacing) / (itemWidth + spacing));

            for (int i = 0; i < AlbumsPanel.Controls.Count; i++)
            {
                Control control = AlbumsPanel.Controls[i];

                int row = i / maxPerRow;
                int col = i % maxPerRow;

                int left = col * (itemWidth + spacing);
                int top = row * (itemHeight + spacing);

                control.Left = left;
                control.Top = top;
            }
        }
    }
}
