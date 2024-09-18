using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintShop
{
    public partial class Form1 : Form
    {
        private const float ZoomFactor = 1.1f;
        private float currentZoom = 1.0f;

        private bool isMiddleClickHeldDown;
        private bool isLeftClickHeldDown;

        private Image tempImage;

        private int lastMousePosX;
        private int lastMousePosY;

        private SelectedDrawingTool tool;
        private Color color = Color.Black;
        private int thickness = 1;

        private List<PointF> points = new List<PointF>();

        private Filters filters = new Filters();
        private List<TableLayoutPanel> filterPanels = new List<TableLayoutPanel>();
        public Form1()
        {
            InitializeComponent();
            pictureBoxPanel.MouseWheel += panel1_MouseWheel;
            pictureBox.MouseWheel += panel1_MouseWheel;

            pictureBox.Image = new Bitmap(600, 400, PixelFormat.Format24bppRgb);
            using ( Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                g.Clear(Color.White);
            }
            pictureBox.Width = (int)(pictureBox.Image.Width * currentZoom);
            pictureBox.Height = (int)(pictureBox.Image.Height * currentZoom);
            tempImage = pictureBox.Image.Clone() as Image;

            filterPanels.Add(brightnessPanel);
            filterPanels.Add(invertPanel);
            filterPanels.Add(noisePanel);
            filterPanels.Add(contrastPanel);
            filterPanels.Add(greyscalePanel);
            filterPanels.Add(quantizePanel);
            filterPanels.Add(ditherPanel);
            filterPanels.Add(convolutionPanel);
            filterPanels.Add(procgenPanel);

            this.DoubleBuffered = true;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFileForm newFileForm = new NewFileForm();
            newFileForm.CreateNewFile += OnCreateImage;
            newFileForm.ShowDialog();

        }
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tif";
            openFileDialog1.Title = "Open an Image File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog1.FileName);
                pictureBox.Image = image;
                tempImage = image.Clone() as Image;
                pictureBox.Width = (int)(pictureBox.Image.Width * currentZoom);
                pictureBox.Height = (int)(pictureBox.Image.Height * currentZoom);
                pictureBox.Location = new Point(0, 0);
            }
        }
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                saveFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif|TIFF Files (*.tif)|*.tif";
                saveFileDialog1.Title = "Save an Image File";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFileDialog1.FileName;
                    try
                    {
                        pictureBox.Image.Save(filename);
                        MessageBox.Show($"Image saved as {filename}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void OnCreateImage(int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            pictureBox.Image = bitmap;
            tempImage = pictureBox.Image.Clone() as Image;
            currentZoom = 1.0f;
            pictureBox.Width = (int)(pictureBox.Image.Width * currentZoom);
            pictureBox.Height = (int)(pictureBox.Image.Height * currentZoom);
            pictureBox.Location = new Point(0, 0);

        }
        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image != null)
            {
                // Zoom in
                if (e.Delta > 0)
                {
                    currentZoom *= ZoomFactor;
                    if (currentZoom > 20.0f)
                    {
                        currentZoom = 20.0f;
                    }
                }
                // Zoom out
                else if (e.Delta < 0)
                {
                    currentZoom /= ZoomFactor;
                    if (currentZoom < 0.1f)
                    {
                        currentZoom = 0.1f;
                    }
                }
                pictureBox.Width = (int)(pictureBox.Image.Width * currentZoom);
                pictureBox.Height = (int)(pictureBox.Image.Height * currentZoom);
            }
            zoomLabel.Text = $"Zoom: {currentZoom}";
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                isMiddleClickHeldDown = true;
            }
            if (e.Button == MouseButtons.Left)
            {
                isLeftClickHeldDown = true;
            }

            lastMousePosX = e.X;
            lastMousePosY = e.Y;
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMiddleClickHeldDown)
            {
                int dx = e.X - lastMousePosX;
                int dy = e.Y - lastMousePosY;
                Point newpos = pictureBox.Location;
                newpos.X += dx;
                newpos.Y += dy;
                pictureBox.Location = newpos;
            }

            coordsLabel.Text = $"X: {e.X}, Y: {e.Y}";

            if (isLeftClickHeldDown)
            {
                if (pictureBox.Image != null)
                {
                    float x = (e.X / currentZoom);
                    float y = (e.Y / currentZoom);
                    float lastX = (lastMousePosX / currentZoom);
                    float lastY = (lastMousePosY / currentZoom);

                    Bitmap bmp = new Bitmap(tempImage);

                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        using (Pen pen = new Pen(color, thickness))
                        {
                            switch (tool)
                            {
                                case SelectedDrawingTool.Rectangle:
                                    if (x < lastX)
                                    {
                                        g.DrawRectangle(pen, x, lastY, lastX - x, y - lastY);
                                    }
                                    if (y < lastY)
                                    {
                                        g.DrawRectangle(pen, lastX, y, x - lastX, lastY - y);
                                    }
                                    if (x < lastX && y < lastY)
                                    {
                                        g.DrawRectangle(pen, x, y, lastX - x, lastY - y);
                                    }
                                    g.DrawRectangle(pen, lastX, lastY, x - lastX, y - lastY);
                                    break;

                                case SelectedDrawingTool.Ellipse:
                                    g.DrawEllipse(pen, lastX, lastY, x - lastX, y - lastY);
                                    break;

                                case SelectedDrawingTool.Line:
                                    g.DrawLine(pen, lastX, lastY, x, y);
                                    break;

                                case SelectedDrawingTool.Pen:
                                    g.DrawLine(pen, lastX, lastY, x, y);
                                    lastMousePosX = e.X;
                                    lastMousePosY = e.Y;
                                    tempImage = bmp;
                                    break;
                            }
                        }
                    }
                    pictureBox.Image = bmp;
                }
                else
                {
                    MessageBox.Show("No image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isLeftClickHeldDown)
            {
                tempImage = pictureBox.Image.Clone() as Image;
            }

            isMiddleClickHeldDown = false;
            isLeftClickHeldDown = false;
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            brightnessTrackBarLabel.Text = brightnessTrackBar.Value.ToString();
            if (pictureBox.Image != null)
            {
                pictureBox.Image = filters.IncreaseBrightness2(brightnessTrackBar.Value, tempImage);
            }   
            else
            {
                MessageBox.Show("No image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void SaveImageToTemp_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                tempImage = pictureBox.Image.Clone() as Image;
            }
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            float x = me.X / currentZoom;
            float y = me.Y / currentZoom;

            Bitmap bmp = new Bitmap(tempImage);
            if (isLeftClickHeldDown)
            {
                switch (tool)
                {
                    case SelectedDrawingTool.Bucket:
                        pictureBox.Image = filters.FloodFillQueue(bmp, (int)(x), (int)(y), color);
                        break;
                }
            }
        }
        private void colorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            colorBtn.BackColor = colorDialog1.Color;
            color = colorDialog1.Color;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            thickness = trackBar2.Value;
        }

        private void rectangleBtn_Click(object sender, EventArgs e)
        {
            tool = SelectedDrawingTool.Rectangle;
        }

        private void ellipseBtn_Click(object sender, EventArgs e)
        {
            tool = SelectedDrawingTool.Ellipse;
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            tool = SelectedDrawingTool.Line;
        }

        private void penBtn_Click(object sender, EventArgs e)
        {
            tool = SelectedDrawingTool.Pen;
        }

        private void polygonBtn_Click(object sender, EventArgs e)
        {
            tool = SelectedDrawingTool.Polygon;
        }

        private void noiseTrackBar_Scroll(object sender, EventArgs e)
        {
            pictureBox.Image = filters.Noise(tempImage, noiseTrackBar.Value);
            noiseLabel.Text = noiseTrackBar.Value.ToString();
        }

        private void contrastTrackbar_Scroll(object sender, EventArgs e)
        {
            pictureBox.Image = filters.Contrast(tempImage, contrastTrackbar.Value);
            contrastTrackBarLabel.Text = contrastTrackbar.Value.ToString();
        }

        private void bucketBtn_Click(object sender, EventArgs e)
        {
            tool = SelectedDrawingTool.Bucket;
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterPanels.ForEach(x => x.Visible = false);
            brightnessPanel.Visible = true;
        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterPanels.ForEach((x) => x.Visible = false);
            invertPanel.Visible = true;
        }
        private void noiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterPanels.ForEach(x => x.Visible = false);
            noisePanel.Visible = true;
        }
        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterPanels.ForEach(x => x.Visible = false);
            contrastPanel.Visible = true;
        }

        private void invertTrackBar_Scroll(object sender, EventArgs e)
        {
            invertTrackBarLabel.Text = invertTrackBar.Value.ToString();
            pictureBox.Image = filters.InvertImage(tempImage, invertTrackBar.Value);
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
        }
        private void greyscaleBtn_Click(object sender, EventArgs e)
        {
            pictureBox.Image = filters.Greyscale(tempImage);
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterPanels.ForEach((x) => x.Visible = false);
            greyscalePanel.Visible = true;
        }

        private void quantizeTrackBar_Scroll(object sender, EventArgs e)
        {
            quantizeTrackBarLabel.Text = quantizeTrackBar.Value.ToString();
            pictureBox.Image = filters.Quantize(tempImage, quantizeTrackBar.Value);
        }

        private void quantizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterPanels.ForEach((x) => x.Visible = false);
            quantizePanel.Visible = true;
        }

        private void ditherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterPanels.ForEach((x) => x.Visible = false);
            ditherPanel.Visible = true;
        }

        private void ditherBtn2x2_Click(object sender, EventArgs e)
        {
            dither2x2Panel.Visible = true;
            dither4x4Panel.Visible = false;
        }

        private void ditherBtn4x4_Click(object sender, EventArgs e)
        {
            dither2x2Panel.Visible = false;
            dither4x4Panel.Visible = true;
        }

        private void ditherBtn_Click(object sender, EventArgs e)
        {
            byte[,] matrix;
            if (dither2x2Panel.Visible == true)
            {
                matrix = new byte[,] { {(byte)dither2x2_0x0.Value, (byte)dither2x2_0x1.Value }, {(byte)dither2x2_1x0.Value, (byte)dither2x2_1x1.Value } };
            }
            else if (dither4x4Panel.Visible == true) 
            {
                matrix = new byte[,] { { (byte)dither4x4_0x0.Value, (byte)dither4x4_0x1.Value, (byte)dither4x4_0x2.Value, (byte)dither4x4_0x3.Value }, 
                                               { (byte)dither4x4_1x0.Value, (byte)dither4x4_1x1.Value, (byte)dither4x4_1x2.Value, (byte)dither4x4_1x3.Value },
                                               { (byte)dither4x4_2x0.Value, (byte)dither4x4_2x1.Value, (byte)dither4x4_2x2.Value, (byte)dither4x4_2x3.Value },
                                               { (byte)dither4x4_3x0.Value, (byte)dither4x4_3x1.Value, (byte)dither4x4_3x2.Value, (byte)dither4x4_3x3.Value } };
            }
            else
            {
                throw new Exception("No dithering method selected.");
            }
            pictureBox.Image = filters.DitherMatrix(tempImage, matrix);
        }

        private void convolutionBtn_Click(object sender, EventArgs e)
        {
            int[,] kernel = new int[,] { { (int)convolution0x0.Value, (int)convolution0x1.Value, (int)convolution0x2.Value },
                                            { (int)convolution1x0.Value, (int)convolution1x1.Value, (int)convolution1x2.Value },
                                            { (int)convolution2x0.Value, (int)convolution2x1.Value, (int)convolution2x2.Value } };
            pictureBox.Image = filters.Convolution(tempImage, kernel, (int)convolutionNormalize.Value);
        }

        private void convolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterPanels.ForEach((x) => x.Visible = false);
            convolutionPanel.Visible = true;
        }

        private void proceduralGenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterPanels.ForEach((x) => x.Visible = false);
            procgenPanel.Visible = true;
        }

        private void procgenLandBtn_Click(object sender, EventArgs e)
        {
            pictureBox.Image = filters.Midpoint(tempImage, "land");
            tempImage = pictureBox.Image.Clone() as Image;
            pictureBox.Width = (int)(pictureBox.Image.Width * currentZoom);
            pictureBox.Height = (int)(pictureBox.Image.Height * currentZoom);
        }

        private void procgenSky_Click(object sender, EventArgs e)
        {
            pictureBox.Image = filters.Midpoint(tempImage, "sky");
            tempImage = pictureBox.Image.Clone() as Image;
            pictureBox.Width = (int)(pictureBox.Image.Width * currentZoom);
            pictureBox.Height = (int)(pictureBox.Image.Height * currentZoom);
        }
    }
}
