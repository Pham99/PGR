using System;
using System.Windows.Forms;

namespace PaintShop
{
    public partial class NewFileForm : Form
    {
        public int ImageWidth { get; private set; } = 600;
        public int ImageHeight { get; private set; } = 400;
        public event Action<int, int> CreateNewFile;
        public NewFileForm()
        {
            InitializeComponent();

            trackBar1.Value = ImageWidth;
            trackBar2.Value = ImageHeight;

            numericUpDown1.Value = ImageWidth;
            numericUpDown2.Value = ImageHeight;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ImageWidth = trackBar1.Value;
            numericUpDown1.Value = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            ImageHeight = trackBar2.Value;
            numericUpDown2.Value = trackBar2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ImageWidth = (int)numericUpDown1.Value;
            trackBar1.Value = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ImageHeight = (int)numericUpDown2.Value;
            trackBar2.Value = (int)numericUpDown2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewFile?.Invoke(ImageWidth, ImageHeight);
            this.Close();
        }
    }
}
