using ns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animation2d_splite_helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            InitializeComponent();
        }

        public List<string> files = new List<string>();
        public string folder = null;
        public int perimage_x = 0;
        public int perimage_y = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SelectFolderBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folder = folderBrowserDialog1.SelectedPath;
                folderpathlabel.Text = folderBrowserDialog1.SelectedPath;
                iterate_folder();
            }
        }

        public void iterate_folder() {
            string[] fileEntries = Directory.GetFiles(folder);
            NumericComparer ns = new NumericComparer();
            Array.Sort(fileEntries, ns);

            foreach (string fileName in fileEntries)
            {
                Console.WriteLine(fileName);
                if(Path.GetExtension(fileName) == ".png" || Path.GetExtension(fileName) == ".jpg")
                {
                    files.Add(fileName);
                }
            }
            
            itext1.Text = "Find "+files.Count+" image can be splite to \nAnimation 2d Sprite.";
        }

        public static Bitmap MergeTwoImages(Image firstImage, Image secondImage)
        {
            if (firstImage == null)
            {
                throw new ArgumentNullException("firstImage");
            }

            if (secondImage == null)
            {
                throw new ArgumentNullException("secondImage");
            }

            int outputImageWidth = firstImage.Width + secondImage.Width;
            int outputImageHeight = firstImage.Height > secondImage.Height ? firstImage.Height : secondImage.Height;

            //int outputImageWidth = firstImage.Width > secondImage.Width ? firstImage.Width : secondImage.Width;
            //int outputImageHeight = firstImage.Height + secondImage.Height + 1;

            Bitmap outputImage = new Bitmap(outputImageWidth, outputImageHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            /*using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                graphics.DrawImage(firstImage, new Rectangle(new Point(), firstImage.Size),
                    new Rectangle(new Point(), firstImage.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(secondImage, new Rectangle(new Point(0, firstImage.Height + 1), secondImage.Size),
                    new Rectangle(new Point(), secondImage.Size), GraphicsUnit.Pixel);
            }*/

            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                graphics.DrawImage(firstImage, new Rectangle(new Point(), firstImage.Size),
                    new Rectangle(new Point(), firstImage.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(secondImage, new Rectangle(new Point(firstImage.Width + 1, 0), secondImage.Size),
                    new Rectangle(new Point(), secondImage.Size), GraphicsUnit.Pixel);
            }

            return outputImage;
        }

        public float nowProgress = 0;
        private void processing_Click(object sender, EventArgs e)
        {
            Image mergeImage;
            mergeImage = Image.FromFile(files[1]);

            float percentUnit = 100 / files.Count;
            nowProgress = percentUnit;
            progressBar1.Value = (int)nowProgress;

            for (int i = 1; i < files.Count; i++)
            {
                mergeImage = MergeTwoImages(mergeImage, Image.FromFile(files[i]));

                nowProgress += percentUnit;
                progressBar1.Value = (int)nowProgress;
            }

            saveFileDialog1.Filter = "Portable Network Graphics Image (*.png)|*.png";
            saveFileDialog1.Title = "Save an Image File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                mergeImage.Save(saveFileDialog1.FileName);
                MessageBox.Show("File saved!");
            }
        }
    }
}
