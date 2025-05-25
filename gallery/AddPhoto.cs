using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gallery
{
    public partial class AddPhoto : Form
    {
        public AddPhoto()
        {
            InitializeComponent();
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var date = e.Data.GetData(DataFormats.FileDrop);
            if (date != null)
            {
                var fielsNames = date as string[];
                if (fielsNames != null)
                {
                    pictureBox1.Image = Image.FromFile(fielsNames[0]);
                    pictureBox1.BackgroundImage = null;  // usuwamy tło
                }
            }
        }

        private void AddPhoto_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        //Gdzieś to musisz zrobić zapisywanie w JSON, żeby potem można było to odczytać i wyświetlić w Main.cs
    }
}
