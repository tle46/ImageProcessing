using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bitmapImage;
        Color[,] ImageArray = new Color[320, 240];
        Color[,] Origimage = new Color[320, 240];
        int[,] AverageArray = new int[320, 240];

        long calccounter = 0;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                Stream myStream = null;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Title = "Image Browser";


                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        Image newImage = Image.FromStream(myStream);
                        bitmapImage = new Bitmap(newImage, 320, 240);
                        picImage.Image = bitmapImage;
                        myStream.Close();
                    }
                }

                SetArrayFromBitmap();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void SetBitmapFromArray()
        {
            for (int row = 0; row < 320; row++)
            {
                for (int col = 0; col < 240; col++)
                {
                    bitmapImage.SetPixel(row, col, ImageArray[row, col]);
                }
            }
        }

        private void SetArrayFromBitmap()
        {
            for (int row = 0; row < 320; row++)
            {
                for (int col = 0; col < 240; col++)
                {
                    ImageArray[row, col] = bitmapImage.GetPixel(row, col);
                    Origimage[row, col] = bitmapImage.GetPixel(row, col);
                }
            }  
        }

        private void btnRedfilter_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            Byte Red;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R;

                    //Assign color to array without other colors
                    Color newColor = Color.FromArgb(255, Red, 0, 0);
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnGreenfilter_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            Byte Green;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Green = col.G;

                    //Assign color to array without other colors
                    Color newColor = Color.FromArgb(255, 0, Green, 0);
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnBluefilter_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            Byte Blue;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Blue = col.B;

                    //Assign color to array without other colors
                    Color newColor = Color.FromArgb(255, 0, 0, Blue);
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            Byte Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    //Assign reversed color to array
                    Color newColor = Color.FromArgb(255, 255 - Red, 255 - Green, 255 - Blue);
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnLighten_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            Byte Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    //Lighten the colors
                    Red = (byte)Math.Min((Red + 10), 255);
                    Green = (byte)Math.Min((Green + 10), 255);
                    Blue = (byte)Math.Min((Blue + 10), 255);

                    //Assign lightened colors to array
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnDarken_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            Byte Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    //Darken colors
                    Red = (byte)Math.Max((Red - 10), 0);
                    Green = (byte)Math.Max((Green - 10), 0);
                    Blue = (byte)Math.Max((Blue - 10), 0);

                    //Assign darkened colors to array
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnSunset_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            Byte Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    //Brighten red and darken blue
                    Red = (byte)Math.Min((Red + 50), 255);
                    Blue = (byte)Math.Max((Blue - 50), 0);

                    //Assign colors to array
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            Byte Red, Green, Blue, Average;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    //Get average of colors
                    Average = (byte)((Red + Green + Blue) / 3);

                    //Assign all colors in array with the same average value
                    Color newColor = Color.FromArgb(255, Average, Average, Average);
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnPolarize_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            Byte Red, Green, Blue;
            int AveRed = 0;
            int AveGreen = 0;
            int AveBlue = 0;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    //Get total culmulative value of each color
                    AveRed = AveRed + Red;
                    AveGreen = AveGreen + Green;
                    AveBlue = AveBlue + Blue;
                }
            }

            //Get average of each color in entire picture
            AveRed = AveRed / 76800;
            AveGreen = AveGreen / 76800;
            AveBlue = AveBlue / 76800;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    //Compare color in pixel to average of colors in entire original picture and assign polarized color
                    if (Red > AveRed)
                    {
                        Red = 255;
                    }
                    else
                    {
                        Red = 0;
                    }

                    if (Green > AveGreen)
                    {
                        Green = 255;
                    }
                    else
                    {
                        Green = 0;
                    }

                    if (Blue > AveBlue)
                    {
                        Blue = 255;
                    }
                    else
                    {
                        Blue = 0;
                    }

                    //Assign color to array
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        public void FlipHor()
        {
            if (bitmapImage == null)
            {
                return;
            }

            int iWidth = 320;
            int iHeight = 240;

            //Switch pixels on left with corresponding opposite pixels on right
            for (int i = 0; i < iWidth / 2; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    //Save left pixels
                    Color newColor = ImageArray[i, j];

                    //Change left pixels
                    ImageArray[i, j] = ImageArray[iWidth - 1 - i, j];
                    //Assign right pixels
                    ImageArray[iWidth - 1 - i, j] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        public void FlipVer()
        {
            if (bitmapImage == null)
            {
                return;
            }

            int iWidth = 320;
            int iHeight = 240;

            //Switch pixels on top with corresponding opposite pixels on bottom
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight / 2; j++)
                {
                    //Save top pixels
                    Color newColor = ImageArray[i, j];

                    //Assign top pixels
                    ImageArray[i, j] = ImageArray[i, iHeight - 1 - j];
                    //Assign bottom pixels
                    ImageArray[i, iHeight - 1 - j] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipHor_Click(object sender, EventArgs e)
        {
            FlipHor();
        }

        private void btnFlipVer_Click(object sender, EventArgs e)
        {
            FlipVer();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            int iWidth = 320;
            int iHeight = 240;

            //Switch top left with bottom right
            for (int i = 0; i < iWidth / 2; i++)
            {
                for (int j = 0; j < iHeight / 2; j++)
                {
                    //Save top left
                    Color newColor = ImageArray[i, j];

                    //Assign top left
                    ImageArray[i, j] = ImageArray[i + iWidth/2, j + iHeight/2];
                    //Assign bottom right
                    ImageArray[i + iWidth / 2, j + iHeight / 2] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            //Flips horizontally then vertically
            FlipHor();
            FlipVer();
        }

        private void btnPixel4_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            int iWidth = 320;
            int iHeight = 240;

            //Cycle through 4x4 pixel groups
            for (int i = 0; i < iWidth; i = i + 4)
            {
                for (int j = 0; j < iHeight; j = j + 4)
                {
                    //Assign same color to each pixel in group
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            ImageArray[i + k, j + l] = ImageArray[i, j];
                        }
                    }
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        //Get average of red around pixel
        public byte GetAveRed(int x, int y)
        {
            int Average;

            int iWidth = 320;
            int iHeight = 240;

            //Top left
            if (x == 0 && y == 0)
            {
                Average = (ImageArray[x + 1, y].R + ImageArray[x + 1, y + 1].R + ImageArray[x, y + 1].R) / 3;
            }
            //Top right
            else if (x == iWidth - 1 && y == 0)
            {
                Average = (ImageArray[x - 1, y].R + ImageArray[x - 1, y + 1].R + ImageArray[x, y + 1].R) / 3;
            }
            //Bottom left
            else if (x == 0 && y == iHeight - 1)
            {
                Average = (ImageArray[x + 1, y].R + ImageArray[x + 1, y - 1].R + ImageArray[x, y - 1].R) / 3;
            }
            //Bottom right
            else if (x == iWidth - 1 && y == iHeight - 1)
            {
                Average = (ImageArray[x - 1, y].R + ImageArray[x - 1, y - 1].R + ImageArray[x, y - 1].R) / 3;
            }
            //Left col
            else if (x == 0)
            {
                Average = (ImageArray[x, y + 1].R + ImageArray[x + 1, y].R + ImageArray[x, y - 1].R) / 3;
            }
            //Right col
            else if (x == iWidth - 1)
            {
                Average = (ImageArray[x, y + 1].R + ImageArray[x - 1, y].R + ImageArray[x, y - 1].R) / 3;
            }
            //Top row
            else if (y == 0)
            {
                Average = (ImageArray[x - 1, y].R + ImageArray[x , y + 1].R + ImageArray[x + 1, y].R) / 3;
            }
            //Bottom row
            else if (y == iHeight - 1)
            {
                Average = (ImageArray[x - 1, y].R + ImageArray[x, y - 1].R + ImageArray[x + 1, y].R) / 3;
            }
            else
            {
                Average = (ImageArray[x - 1, y].R + ImageArray[x, y + 1].R + ImageArray[x + 1, y].R + ImageArray[x, y - 1].R) / 4;
            }

            return (byte)Average;
        }

        //Get average of green around pixel
        public byte GetAveGreen(int x, int y)
        {
            int Average;

            int iWidth = 320;
            int iHeight = 240;

            //Top left
            if (x == 0 && y == 0)
            {
                Average = (ImageArray[x + 1, y].G + ImageArray[x + 1, y + 1].G + ImageArray[x, y + 1].G) / 3;
            }
            //Top right
            else if (x == iWidth - 1 && y == 0)
            {
                Average = (ImageArray[x - 1, y].G + ImageArray[x - 1, y + 1].G + ImageArray[x, y + 1].G) / 3;
            }
            //Bottom left
            else if (x == 0 && y == iHeight - 1)
            {
                Average = (ImageArray[x + 1, y].G + ImageArray[x + 1, y - 1].G + ImageArray[x, y - 1].G) / 3;
            }
            //Bottom right
            else if (x == iWidth - 1 && y == iHeight - 1)
            {
                Average = (ImageArray[x - 1, y].G + ImageArray[x - 1, y - 1].G + ImageArray[x, y - 1].G) / 3;
            }
            //Left col
            else if (x == 0)
            {
                Average = (ImageArray[x, y + 1].G + ImageArray[x + 1, y].G + ImageArray[x, y - 1].G) / 3;
            }
            //Right col
            else if (x == iWidth - 1)
            {
                Average = (ImageArray[x, y + 1].G + ImageArray[x - 1, y].G + ImageArray[x, y - 1].G) / 3;
            }
            //Top row
            else if (y == 0)
            {
                Average = (ImageArray[x - 1, y].G + ImageArray[x, y + 1].G + ImageArray[x + 1, y].G) / 3;
            }
            //Bottom row
            else if (y == iHeight - 1)
            {
                Average = (ImageArray[x - 1, y].G + ImageArray[x, y - 1].G + ImageArray[x + 1, y].G) / 3;
            }
            else
            {
                Average = (ImageArray[x - 1, y].G + ImageArray[x, y + 1].G + ImageArray[x + 1, y].G + ImageArray[x, y - 1].G) / 4;
            }

            return (byte)Average;
        }

        //Get average of blue around pixel
        public byte GetAveBlue(int x, int y)
        {
            int Average;

            int iWidth = 320;
            int iHeight = 240;

            //Top left
            if (x == 0 && y == 0)
            {
                Average = (ImageArray[x + 1, y].B + ImageArray[x + 1, y + 1].B + ImageArray[x, y + 1].B) / 3;
            }
            //Top right
            else if (x == iWidth - 1 && y == 0)
            {
                Average = (ImageArray[x - 1, y].B + ImageArray[x - 1, y + 1].B + ImageArray[x, y + 1].B) / 3;
            }
            //Bottom left
            else if (x == 0 && y == iHeight - 1)
            {
                Average = (ImageArray[x + 1, y].B + ImageArray[x + 1, y - 1].B + ImageArray[x, y - 1].B) / 3;
            }
            //Bottom right
            else if (x == iWidth - 1 && y == iHeight - 1)
            {
                Average = (ImageArray[x - 1, y].B + ImageArray[x - 1, y - 1].B + ImageArray[x, y - 1].B) / 3;
            }
            //Left col
            else if (x == 0)
            {
                Average = (ImageArray[x, y + 1].B + ImageArray[x + 1, y].B + ImageArray[x, y - 1].B) / 3;
            }
            //Right col
            else if (x == iWidth - 1)
            {
                Average = (ImageArray[x, y + 1].B + ImageArray[x - 1, y].B + ImageArray[x, y - 1].B) / 3;
            }
            //Top row
            else if (y == 0)
            {
                Average = (ImageArray[x - 1, y].B + ImageArray[x, y + 1].B + ImageArray[x + 1, y].B) / 3;
            }
            //Bottom row
            else if (y == iHeight - 1)
            {
                Average = (ImageArray[x - 1, y].B + ImageArray[x, y - 1].B + ImageArray[x + 1, y].B) / 3;
            }
            else
            {
                Average = (ImageArray[x - 1, y].B + ImageArray[x, y + 1].B + ImageArray[x + 1, y].B + ImageArray[x, y - 1].B) / 4;
            }

            return (byte)Average;
        }

        public void Blur()
        {
            Color[,] NewImageArray = new Color[320, 240];

            int iWidth = 320;
            int iHeight = 240;

            //Cycles through all pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    //Assigns average of colors surrounding each pixel to temporary array
                    Color newColor = Color.FromArgb(255, GetAveRed(i, j), GetAveGreen(i, j), GetAveBlue(i, j));
                    NewImageArray[i, j] = newColor;
                }
            }

            //Assigns values from temporary array to official array
            ImageArray = NewImageArray;
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            Blur();

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        public void Average()
        {
            int iWidth = 320;
            int iHeight = 240;

            //For each pixel get average of all colors to get brightness
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    int average = (ImageArray[i, j].R + ImageArray[i, j].G + ImageArray[i, j].B) / 3;
                    AverageArray[i, j] = average;
                }
            }
        }

        public void quicksort(int row, int high, int low)
        {
            //Checks if partition is correct
            if (low < high)
            {
                //Gets index of correct partition and calls quicksort on surrounding numbers
                int index = partition(row, high, low);
                quicksort(row, index - 1, low);
                quicksort(row, high, index + 1);
            }
        }

        public int partition(int row, int high, int low)
        {
            //Pivot is assigned as high of array
            int pivot = AverageArray[high, row];

            //Lowest index that is greater than the pivot
            int ilow = low;

            for (int checkpoint = low; checkpoint < high; checkpoint++)
            {
                calccounter++;

                // Checks if the checkpoint is smaller than pivot number
                if (AverageArray[checkpoint, row] < pivot)
                {
                    // Swap if not in right place 
                    int temp = AverageArray[ilow, row];
                    AverageArray[ilow, row] = AverageArray[checkpoint, row];
                    AverageArray[checkpoint, row] = temp;

                    //Swaps corresponding pixels
                    Color newColor = ImageArray[ilow, row];
                    ImageArray[ilow, row] = ImageArray[checkpoint, row];
                    ImageArray[checkpoint, row] = newColor;

                    ilow++;
                }
            }

            //Swap high/pivot with ilow (partition)
            int temp1 = AverageArray[ilow, row];
            AverageArray[ilow, row] = AverageArray[high, row];
            AverageArray[high, row] = temp1;

            //Swaps corresponding pixels
            Color newColor1 = ImageArray[ilow, row];
            ImageArray[ilow, row] = ImageArray[high, row];
            ImageArray[high, row] = newColor1;

            //Returns the partition, which is the index of the previously used pivot
            return (ilow);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            calccounter = 0;

            int iWidth = 320;
            int iHeight = 240;

            //Generates averagearray from imagearray
            Average();

            //Quicksorts each row
            for (int i = 0; i < iHeight - 1; i++)
            {
                quicksort(i, iWidth - 1, 0);
            }

            /*
            //Insertion sort
            for (int row = 0; row < iHeight; row++)
            {
                for (int i = 1; i < iWidth; i++)
                {
                    int key = AverageArray[i, row];
                    Color newcolor = ImageArray[i, row];
                    int j = i - 1;

                    while (j >= 0 && AverageArray[j, row] > key)
                    {
                        AverageArray[j + 1, row] = AverageArray[j, row];
                        ImageArray[j + 1, row] = ImageArray[j, row];
                        j = j - 1;

                        calccounter++;
                    }
                    AverageArray[j + 1, row] = key;
                    ImageArray[j + 1, row] = newcolor;
                }
            }
            
            //Bubble sort

            bool isSorted;

            for (int y = 0; y < iHeight; y++)
            {
                for (int counter = 0; counter < iWidth - 1; counter++)
                {
                    isSorted = true;

                    for (int x = 0; x < iWidth - 1; x++)
                    {
                        int Ave1, Ave2;

                        //Get average of adjacent numbers
                        Ave1 = (ImageArray[x, y].R + ImageArray[x, y].G + ImageArray[x, y].B) / 3;
                        Ave2 = (ImageArray[x + 1, y].R + ImageArray[x + 1, y].G + ImageArray[x + 1, y].B) / 3;

                        calccounter++;

                        //Switches adjacent numbers if needed
                        if (Ave1 > Ave2)
                        {
                            Color newcolor = ImageArray[x, y];
                            ImageArray[x, y] = ImageArray[x + 1, y];
                            ImageArray[x + 1, y] = newcolor;
                            isSorted = false;
                        }
                    }

                    //If array is already sorted break to next row
                    if (isSorted == true)
                    {
                        break;
                    }
                    
                }
            }
            */

            //textBox1.Text = calccounter.ToString();

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        public bool isEdge(int row, int col)
        {
            //Edge detection WITHOUT COLOR
            int colorCheck = AverageArray[row, col];

            //Sensitivity
            int sens = 15;

            //Detects changes in brightness
            if (Math.Abs(AverageArray[row - 1, col - 1] - colorCheck) > sens ||
                Math.Abs(AverageArray[row - 1, col] - colorCheck) > sens ||
                Math.Abs(AverageArray[row - 1, col + 1] - colorCheck) > sens ||
                Math.Abs(AverageArray[row , col - 1] - colorCheck) > sens ||
                Math.Abs(AverageArray[row , col + 1] - colorCheck) > sens ||
                Math.Abs(AverageArray[row + 1, col - 1] - colorCheck) > sens ||
                Math.Abs(AverageArray[row + 1, col] - colorCheck) > sens ||
                Math.Abs(AverageArray[row + 1, col - 1] - colorCheck) > sens)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnEdge_Click(object sender, EventArgs e)
        {
            int iWidth = 320;
            int iHeight = 240;

            //If noise reduction is checked blur image
            if(cbNoise.Checked == true)
            {
                Blur();
            }

            //Update average array
            Average();

            //Makes edges white and non edges black
            for (int i = 1; i < iWidth - 2; i++)
            {
                for (int j = 1; j < iHeight - 2; j++)
                {
                    if (isEdge(i, j) == true)
                    {
                        ImageArray[i, j] = Color.FromArgb(255, 255, 255, 255);
                    }
                    else
                    {
                        ImageArray[i, j] = Color.FromArgb(255, 0, 0, 0);
                    }
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int iWidth = 320;
            int iHeight = 240;

            //Sets resets main imagearray to original image array
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    ImageArray[i, j] = Origimage[i, j];
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Saves file as .bmp
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images *.BMP;*.JPG;*.GIF|*.BMP;*.JPG;*.GIF|All files (.)|.";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bitmapImage.Save(sfd.FileName);
                    MessageBox.Show("File successfully saved");
                }
            }
            catch
            {
                MessageBox.Show("An error has occurred");
            }
        }
    }
}