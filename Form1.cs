using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Filters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        private Bitmap image;

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            string FileName = dialog.FileName;
            if (FileName != "")
            {
                image = new Bitmap(FileName);

                pictureBox1.Image = image;
                button1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
/// <summary>
/// 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inversion invfil = new Inversion();
            backgroundWorker1.RunWorkerAsync(invfil);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            string fileName = dialog.FileName + ".jpg";
            image.Save(fileName);
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters blurfilter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(blurfilter);

        }

        private void gaussianFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters gaussianfilter = new GaussianFilters();
            backgroundWorker1.RunWorkerAsync(gaussianfilter);

        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters grayScale = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(grayScale);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters sepia = new Sepia();
            backgroundWorker1.RunWorkerAsync(sepia);

        }

        private void intensityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters intensity = new Intensity();
            backgroundWorker1.RunWorkerAsync(intensity);

        }

        private void sharpnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters sharpness = new Sharpness();
            backgroundWorker1.RunWorkerAsync(sharpness);

        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Filters sobel = new Sobel();
            backgroundWorker1.RunWorkerAsync(sobel);

          
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            image = ((Filters)e.Argument).proccesImage(image, backgroundWorker1);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Image = image;
            pictureBox1.Refresh();
            progressBar1.Value = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void waveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters wave = new Wave();
            backgroundWorker1.RunWorkerAsync(wave);

        }

        private void glassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters glass = new Glass();
            backgroundWorker1.RunWorkerAsync(glass);

        }

        private void shiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters shift = new Shift();
            backgroundWorker1.RunWorkerAsync(shift);
        }

        private void rotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters rotation = new Rotation();
            backgroundWorker1.RunWorkerAsync(rotation);
        }

        private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Filters motionBlur = new MotionBlur();
            backgroundWorker1.RunWorkerAsync(motionBlur);
        }

        private void harshnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters harshness  = new Harshness();
            backgroundWorker1.RunWorkerAsync(harshness);
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Filters dilation = new Dilation();
            backgroundWorker1.RunWorkerAsync(dilation);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters erosion = new Erosion();
            backgroundWorker1.RunWorkerAsync(erosion);
        }
    }
}
