using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image image;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "";
            Dlg.Title = "GET THE IMAGE!";
            if(Dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Dlg.ShowDialog().ToString());
               image = Image.FromFile(Dlg.FileName);
                LoadImage();
                //kl;kl;
               

            }

        }

        private void LoadImage()
        {
            // Set pocturebox size accoding to image, we can get image and height with the help of Image.Width and Image.Height properties
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;

            pictureBox1.Image = image;
            Size OriginalImageSize = new Size(image.Width, image.Height);

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            MessageBox.Show(FileList[0]);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
           string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            image = Image.FromFile(files[0]);
            pictureBox1.Image = image;
            
            //foreach (string item in files)
            //{
            //    MessageBox.Show(item);
            //}
        }
    }
}
