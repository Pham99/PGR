using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace PaintShop
{
    internal class Filters
    {
        private Random random = new Random();
        int bytesPerPixel;
        int stride;
        public Bitmap IncreaseBrightness2(int brightness, Image image)
        {

            Bitmap bmp = new Bitmap(image);

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            int bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            int byteCount = bmpData.Stride * bmp.Height;

            byte[] pixels = new byte[byteCount];

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    int index = y * bmpData.Stride + x * bytesPerPixel;

                    byte red = pixels[index];
                    byte green = pixels[index + 1];
                    byte blue = pixels[index + 2];

                    red = ClampByte(red + brightness);
                    green = ClampByte(green + brightness);
                    blue = ClampByte(blue + brightness);

                    pixels[index] = red;
                    pixels[index + 1] = green;
                    pixels[index + 2] = blue;
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);

            bmp.UnlockBits(bmpData);
            return bmp;
        }
        public Bitmap InvertImage(Image image, int intensity)
        {

            Bitmap bmp = new Bitmap(image);

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            int bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            int byteCount = bmpData.Stride * bmp.Height;

            byte[] pixels = new byte[byteCount];

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    int index = y * bmpData.Stride + x * bytesPerPixel;

                    pixels[index] = (byte)Math.Abs(pixels[index] - intensity);
                    pixels[index + 1] = (byte)Math.Abs(pixels[index + 1] - intensity);
                    pixels[index + 2] = (byte)Math.Abs(pixels[index + 2] - intensity);
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);

            bmp.UnlockBits(bmpData);

            return bmp;
        }
        public Bitmap Noise(Image image, int intensity)
        {

            Bitmap bmp = new Bitmap(image);

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            stride = bmpData.Stride;
            int byteCount = bmpData.Stride * bmp.Height;

            byte[] pixels = new byte[byteCount];

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    int index = y * bmpData.Stride + x * bytesPerPixel;

                    pixels[index] = ClampByte(pixels[index] + random.Next(-intensity, intensity));
                    pixels[index + 1] = ClampByte(pixels[index + 1] + random.Next(-intensity, intensity));
                    pixels[index + 2] = ClampByte(pixels[index + 2] + random.Next(-intensity, intensity));
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);

            bmp.UnlockBits(bmpData);

            return bmp;
        }
        public Bitmap Contrast(Image image, int intensity)
        {
            Bitmap bmp = new Bitmap(image);

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            int byteCount = bmpData.Stride * bmp.Height;

            byte[] pixels = new byte[byteCount];

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount);

            //float contrastFactor = (259 * (intensity + 255)) / (255 * (259 - intensity));
            float contrastFactor = (float)(intensity + 100) / 100.0f;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    int index = y * bmpData.Stride + x * bytesPerPixel;

                    pixels[index] = ClampByte(((pixels[index] - 128) * contrastFactor) + 128);
                    pixels[index + 1] = ClampByte(((pixels[index + 1] - 128) * contrastFactor) + 128);
                    pixels[index + 2] = ClampByte(((pixels[index + 2] - 128) * contrastFactor) + 128);
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);

            bmp.UnlockBits(bmpData);

            return bmp;
        }

        public Bitmap FloodFill(Image image, int ex, int ey, Color color)
        {
            Bitmap bmp = new Bitmap(image);

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            stride = bmpData.Stride;
            int byteCount = bmpData.Stride * bmp.Height;

            byte[] pixels = new byte[byteCount];

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount);

            int selected = ey * bmpData.Stride + ex * bytesPerPixel;
            byte B = pixels[selected];
            byte G = pixels[selected + 1];
            byte R = pixels[selected + 2];
            Color selectedColor = Color.FromArgb(R, G, B);

            if (R == color.R && G == color.G && B == color.B)
            {
                System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);
                bmp.UnlockBits(bmpData);
                return bmp;
            }
            DFS(pixels, selected, color, selectedColor);

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);

            bmp.UnlockBits(bmpData);

            return bmp;
        }
        public void DFS(byte[] pixels, int index, Color color, Color selectedColor)
        {
            if (index < 0 || index >= pixels.Length)
            {
                return;
            }
            if (pixels[index] == color.R && pixels[index + 1] == color.G && pixels[index + 2] == color.B)
            {
                return;
            }
            if (pixels[index] == selectedColor.B && pixels[index + 1] == selectedColor.G && pixels[index + 2] == selectedColor.R)
            {
                pixels[index] = color.B;
                pixels[index + 1] = color.G;
                pixels[index + 2] = color.R;

                DFS(pixels, index - stride, color, selectedColor);
                DFS(pixels, index + stride, color, selectedColor);
                DFS(pixels, index - bytesPerPixel, color, selectedColor);
                DFS(pixels, index + bytesPerPixel, color, selectedColor);
            }

        }
        public Bitmap FloodFillQueue(Image image, int ex, int ey, Color color)
        {
            Bitmap bmp = new Bitmap(image);

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            stride = bmpData.Stride;
            int byteCount = bmpData.Stride * bmp.Height;

            byte[] pixels = new byte[byteCount];

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount);

            int selected = ey * bmpData.Stride + ex * bytesPerPixel;
            byte B = pixels[selected];
            byte G = pixels[selected + 1];
            byte R = pixels[selected + 2];
            Color selectedColor = Color.FromArgb(R, G, B);

            if (R == color.R && G == color.G && B == color.B)
            {
                System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);
                bmp.UnlockBits(bmpData);
                return bmp;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(selected);
            while (queue.Count > 0)
            {
                int index = queue.Dequeue();
                if (index < 0 || index >= pixels.Length)
                {
                    continue;
                }
                if (pixels[index] == color.B && pixels[index + 1] == color.G && pixels[index + 2] == color.R)
                {
                    continue;
                }
                if (pixels[index] == selectedColor.B && pixels[index + 1] == selectedColor.G && pixels[index + 2] == selectedColor.R)
                {
                    pixels[index] = color.B;
                    pixels[index + 1] = color.G;
                    pixels[index + 2] = color.R;

                    queue.Enqueue(index - stride);
                    queue.Enqueue(index + stride);
                    queue.Enqueue(index - bytesPerPixel);
                    queue.Enqueue(index + bytesPerPixel);
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);

            bmp.UnlockBits(bmpData);

            return bmp;
        }
        public Bitmap Greyscale(Image image)
        {
            Bitmap bmp = new Bitmap(image);

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            int byteCount = bmpData.Stride * bmp.Height;

            byte[] pixels = new byte[byteCount];

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    int index = y * bmpData.Stride + x * bytesPerPixel;
                    int grey = (int)(0.299 * pixels[index + 2] + 0.587 * pixels[index + 1] + 0.114 * pixels[index]);

                    pixels[index] = (byte)grey;
                    pixels[index + 1] = (byte)grey;
                    pixels[index + 2] = (byte)grey;
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);

            bmp.UnlockBits(bmpData);

            return bmp;
        }
        public Bitmap Quantize(Image image, int numColors)
        {
            byte[] reducedColors = LinspaceByte(numColors);

            Bitmap bmp = new Bitmap(image);

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            int byteCount = bmpData.Stride * bmp.Height;

            byte[] pixels = new byte[byteCount];

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    int index = y * bmpData.Stride + x * bytesPerPixel;

                    pixels[index] = QuantizeDynamic(pixels[index], reducedColors);
                    pixels[index + 1] = QuantizeDynamic(pixels[index + 1], reducedColors);
                    pixels[index + 2] = QuantizeDynamic(pixels[index + 2], reducedColors);
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);

            bmp.UnlockBits(bmpData);

            return bmp;
        }
        private byte QuantizeDynamic(byte value, byte[] targetColors)
        {
            byte closest = targetColors[0];
            int minDifference = Math.Abs(value - closest);

            foreach (byte target in targetColors)
            {
                int difference = Math.Abs(value - target);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    closest = target;
                }
            }

            return closest;
        }
        public Bitmap DitherMatrix(Image image, byte[,] matrix)
        {
            int lenx = matrix.GetLength(0);
            int leny = matrix.GetLength(1);

            int cells = lenx * leny;

            Bitmap bmp = new Bitmap(image);

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            int byteCount = bmpData.Stride * bmp.Height;

            byte[] pixels = new byte[byteCount];

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    int index = y * bmpData.Stride + x * bytesPerPixel;

                    pixels[index] = pixels[index] / 255f * cells > matrix[x % lenx, y % leny] ? (byte)255 : (byte)0;
                    pixels[index + 1] = pixels[index + 1] / 255f * cells > matrix[x % lenx, y % leny] ? (byte)255 : (byte)0;
                    pixels[index + 2] = pixels[index + 2] / 255f * cells > matrix[x % lenx, y % leny] ? (byte)255 : (byte)0;
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);

            bmp.UnlockBits(bmpData);

            return bmp;
        }
        public Bitmap Convolution(Image image, int[,] matrix, int normalize)
        {
            int lenx = matrix.GetLength(0);
            int leny = matrix.GetLength(1);

            int cells = lenx * leny;

            Bitmap bmp = new Bitmap(image);

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            stride = bmpData.Stride;
            int byteCount = bmpData.Stride * bmp.Height;

            byte[] pixels = new byte[byteCount];

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount);
            byte[] pixelsCopy = pixels.Clone() as byte[];

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    int index = y * bmpData.Stride + x * bytesPerPixel;

                    pixels[index] = ApplyMask(index, matrix, pixelsCopy, normalize);
                    pixels[index + 1] = ApplyMask(index + 1, matrix, pixelsCopy, normalize);
                    pixels[index + 2] = ApplyMask(index + 2, matrix, pixelsCopy, normalize);
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);

            bmp.UnlockBits(bmpData);

            return bmp;
        }
        private byte ApplyMask(int index, int[,] mask, byte[] pixels, int normalise)
        {
            int newValue = (TryGetPixel(index - stride - bytesPerPixel, pixels) * mask[0, 0] +
                           TryGetPixel(index - stride, pixels) * mask[0, 1] +
                           TryGetPixel(index - stride + bytesPerPixel, pixels) * mask[0, 2] +
                           TryGetPixel(index - bytesPerPixel, pixels) * mask[1, 0] +
                           TryGetPixel(index, pixels) * mask[1, 1] +
                           TryGetPixel(index + bytesPerPixel, pixels) * mask[1, 2] +
                           TryGetPixel(index + stride - bytesPerPixel, pixels) * mask[2, 0] +
                           TryGetPixel(index + stride, pixels) * mask[2, 1] +
                           TryGetPixel(index + stride + bytesPerPixel, pixels) * mask[2, 2]) /
                           normalise;
            return ClampByte(newValue);
        }
        public Bitmap DLA(int iterations)
        {

            Bitmap bmp = new Bitmap(150, 100, PixelFormat.Format24bppRgb);

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            stride = bmpData.Stride;
            int byteCount = bmpData.Stride * bmp.Height;

            byte[] pixels = new byte[byteCount];

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount);

            int h = bmp.Height / 2;
            int w = bmp.Width / 2;

            // set seed
            for (int y = h - 5; y < h + 5; y++)
            {
                int index = y * bmpData.Stride + w * bytesPerPixel;
                pixels[index] = 255;
                pixels[index + 1] = 255;
                pixels[index + 2] = 255;
            }
            for (int x = w - 5; x < w + 5; x++)
            {
                int index = h * bmpData.Stride + x * bytesPerPixel;
                pixels[index] = 255;
                pixels[index + 1] = 255;
                pixels[index + 2] = 255;
            }

            for (int i = 0; i < iterations; i++)
            {
                int x = random.Next(0, bmp.Width - 1);
                int y = random.Next(0, bmp.Height - 1);
                int index = 0;
                while (true)
                {
                    RandomWalk(ref x, ref y);
                    index = y * bmpData.Stride + x * bytesPerPixel;
                    if (CheckNeighbours(index, pixels) != 0)
                    {
                        index = y * bmpData.Stride + x * bytesPerPixel;
                        pixels[index] = 255;
                        pixels[index + 1] = 255;
                        pixels[index + 2] = 255;
                        break;
                    }
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);

            bmp.UnlockBits(bmpData);

            return bmp;
        }
        private void RandomWalk(ref int x, ref int y)
        {
            int randomNum = random.Next(0, 4);
            switch (randomNum)
            {
                case 0:
                    y--;
                    break;
                case 1:
                    x++;
                    break;
                case 2:
                    y++;
                    break;
                case 3:
                    x--;
                    break;
            }
        }
        private int CheckNeighbours(int index, byte[] pixels)
        {
            int newValue = TryGetPixel(index - stride, pixels) +
                           TryGetPixel(index - bytesPerPixel, pixels) +
                           TryGetPixel(index + bytesPerPixel, pixels) +
                           TryGetPixel(index + stride, pixels);
            return newValue;
        }
        public Bitmap Midpoint(Image image, string mode)
        {
            int size = (int)Math.Pow(2, 8) + 1;
            int[,] heightMap = new int[size, size];

            // init corners
            heightMap[0, 0] = random.Next(0, 256);
            heightMap[0, size - 1] = random.Next(0, 256);
            heightMap[size - 1, 0] = random.Next(0, 256);
            heightMap[size - 1, size - 1] = random.Next(0, 256);

            int chunk = size - 1;
            int roughness = 255;

            while (chunk > 1)
            {
                int half = chunk / 2;
                for (int y = 0; y < size - 1; y += chunk)
                {
                    for (int x = 0; x < size - 1; x += chunk)
                    {
                        heightMap[x + half, y + half] = ((heightMap[x, y] +
                                                         heightMap[x + chunk, y] +
                                                         heightMap[x, y + chunk] +
                                                         heightMap[x + chunk, y + chunk])
                                                         / 4) + random.Next(-roughness, roughness);
                    }
                }
                for (int y = 0; y < size; y += half)
                {
                    for (int x = (y + half) % chunk; x < size; x += chunk)
                    {
                        heightMap[x, y] = ((TryGet(x, y + half, heightMap) +
                                          TryGet(x, y - half, heightMap) +
                                          TryGet(x + half, y, heightMap) +
                                          TryGet(x - half, y, heightMap)) / 4)
                                          + random.Next(-roughness, roughness);
                    }
                }
                chunk /= 2;
                roughness /= 2;
            }

            Bitmap bmp = new Bitmap(size, size, PixelFormat.Format24bppRgb);

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            int byteCount = bmpData.Stride * bmp.Height;

            byte[] pixels = new byte[byteCount];

            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, byteCount);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    int index = y * bmpData.Stride + x * bytesPerPixel;

                    int value = heightMap[x, y];
                    Color color;

                    if (mode == "land")
                    {
                        color = PaintLand(value);
                    }
                    else
                    {
                        color = PaintClouds(value);
                    }

                    pixels[index] = color.B;
                    pixels[index + 1] = color.G;
                    pixels[index + 2] = color.R;
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, byteCount);

            bmp.UnlockBits(bmpData);

            return bmp;
        }
        private Color PaintClouds(int value)
        {
            value = ClampByte(value);
            if (value < 128)
            {
                return Color.Blue;
            }
            else
            {
                return Color.FromArgb(255, value, value, 255);
            }
        }
        private Color PaintLand(int value)
        {
            Color color;
            if (value < 35)
            {
                color = Color.Blue;
            }
            else if (value < 45)
            {
                color = Color.Beige;
            }
            else if (value < 85)
            {
                color = Color.Green;
            }
            else if (value < 128)
            {
                color = Color.DarkGreen;
            }
            else if (value < 178)
            {
                color = Color.Gray;
            }
            else if (value < 221)
            {
                color = Color.LightGray;
            }
            else
            {
                color = Color.White;
            }
            return color;
        }
        private int TryGet(int x, int y, int[,] heightMap)
        {
            int size = heightMap.GetLength(0);
            if (x >= 0 && x < size && y >= 0 && y < size)
            {
                return heightMap[x, y];
            }
            else
            {
                return 128;
            }
        }
        private byte TryGetPixel(int index, byte[] pixels)
        {
            if (index > 0 && index < pixels.Length)
            {
                return pixels[index];
            }
            else
            {
                return 0;
            }
        }
        private byte ClampByte(int value)
        {
            if (value > 255)
            {
                return byte.MaxValue;
            }
            else if (value < 0)
            {
                return byte.MinValue;
            }
            else
            {
                return (byte)value;
            }
        }
        private byte ClampByte(float value)
        {
            if (value > 255)
            {
                return byte.MaxValue;
            }
            else if (value < 0)
            {
                return byte.MinValue;
            }
            else
            {
                return (byte)value;
            }
        }
        private byte[] LinspaceByte(int numLevels)
        {
            if (numLevels < 2)
            {
                throw new ArgumentException("numLevels must be at least 2");
            }

            byte[] result = new byte[numLevels];
            float step = 255f / (numLevels - 1);

            for (int i = 0; i < numLevels; i++)
            {
                result[i] = (byte)Math.Round(i * step);
            }

            return result;
        }
    }
}
