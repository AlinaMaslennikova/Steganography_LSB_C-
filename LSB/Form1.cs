using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSB
{
    public partial class Form1 : Form
    {
        class MyException : System.Exception { }
        Bitmap image1;
        Bitmap image2;
        
       // int len;
        public Form1()
        {
            InitializeComponent();
        }

        static int[] StrToBin(string str)
        {
            byte[] arr = System.Text.Encoding.Unicode.GetBytes(str);
            int len = arr.Length / 2;
            int[] arr2 = new int[len * 8];
            int c = 0;
            for (int i = 0; i < arr.Length; i += 2)
            {
                for (int j = 7; j >= 0; j--)
                {
                    arr2[c] = (int)((arr[i] & (1 << j)) >> j);
                    c++;
                }
            }
            return arr2;
        }
        static string BinToStr(int[] arr)
        {
            byte[] b = new byte[arr.Length * 8];
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                c = i / 8;
                b[c] = (byte)(b[c] | (arr[i] << (7 - (i % 8))));
            }
            return Encoding.UTF8.GetString(b);
        }

        private void GenPermutation(char[] Key, int m)
        {
            Random rng = new Random();
            for (int i = 0; i < m; i++)
            {
                Key[i] = Convert.ToChar(i);
            }
            for (int i = 0; i < 100; i++)
            {
                int a = rng.Next(m);
                int b = rng.Next(m);
                if (a != b)
                {
                    char c = Key[a];
                    Key[a] = Key[b];
                    Key[b] = c;
                }
            }
        }
        void Substitution(char[] Src, char[] Key, ref char[] Dst)
        {
            for (int i = 0; i < Src.Length; ++i)
            {
                if (Src[i] >= 128) {
                    Src[i] = Convert.ToChar(0);
                }
                Dst[i] = Convert.ToChar(Key[Src[i]]);
            }
        }
        void InvKey(char[] Key, char[] Key1, int m)
        {
            for (int i = 0; i < m; i++)
            {
                Key1[Key[i]] = Convert.ToChar(i);
            }
        }

        private void buttonIn_Click(System.Object sender, System.EventArgs e)
        {

            try
            {
                if (chooseMethod.SelectedIndex == -1) 
                {
                    throw new MyException();
                }
                image1 = new Bitmap(pictureBoxLeft.Image);
                string str = textBox1.Text;
                if (chooseMethod.SelectedIndex == 2)
                {
                    int len = str.Length;
                    char[] Key;
                    Key = new char[128];
                    char[] Dst = new char[len + 1];
                    GenPermutation(Key, 128);
                    Substitution(str.ToCharArray(), Key, ref Dst);
                    str = new String(Dst);
                    using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("KeyP.txt", false))
                    {
                        file.WriteLine(len);
                        for (int j = 0; j < Key.Length; j++)
                        {
                            file.Write(Key[j]);
                        }
                    }
                }
                int[] arr = StrToBin(str);
                int[] k = new int[arr.Length];
                Random rng = new Random();
                if (chooseMethod.SelectedIndex == 1)
                {
                    for (int j = 0; j < k.Length; j++)
                    {
                        k[j] = rng.Next(9) + 1;
                    }
                }
                else {
                    for (int j = 0; j < k.Length; j++)
                    {
                        k[j] = 1;
                    }
                }
                
                using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("Key.txt", false))
                {
                    for (int j = 0; j < k.Length; j++)
                    {
                        file.WriteLine(k[j]);
                    }
                }
               
                int x = 0, y = 0;
                int i = 0;
               
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; )
                    {
                        if (i == arr.Length)
                            break;
                        Color pixelColor = image1.GetPixel(x, y);
                        Color newColor;
                        if (arr[i] == 0)
                        {
                            newColor = Color.FromArgb(pixelColor.R, pixelColor.G, pixelColor.B & 0xFE);
                        }
                        else
                        {
                            newColor = Color.FromArgb(pixelColor.R, pixelColor.G, pixelColor.B | 1);
                        }
                        image1.SetPixel(x, y, newColor);
                        
                        y += k[i];
                        i++;
                    }
                }
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; )
                    {
                        if (i == arr.Length)
                            break;
                        Color pixelColor = image1.GetPixel(x, y);
                        Color newColor;
                        if (arr[i] == 0)
                        {
                            newColor = Color.FromArgb(pixelColor.R & 0xFE, pixelColor.G, pixelColor.B);
                        }
                        else
                        {
                            newColor = Color.FromArgb(pixelColor.R | 1, pixelColor.G, pixelColor.B);
                        }
                        image1.SetPixel(x, y, newColor);
                        
                        y += k[i];
                        i++;
                    }
                }
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; )
                    {
                        if (i == arr.Length)
                            break;
                        Color pixelColor = image1.GetPixel(x, y);
                        Color newColor;
                        if (arr[i] == 0)
                        {
                            newColor = Color.FromArgb(pixelColor.R, pixelColor.G & 0xFE, pixelColor.B);
                        }
                        else
                        {
                            newColor = Color.FromArgb(pixelColor.R, pixelColor.G | 1, pixelColor.B);
                        }
                        image1.SetPixel(x, y, newColor);
                        
                        y += k[i];
                        i++;
                    }
                }
                // Set the PictureBox to display the image.
                pictureBoxRight.Image = image1;

            }
            catch (MyException)
            {
                MessageBox.Show("Метод не выбран.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the file.");
            }
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            try
            {   
               
                image2 = (Bitmap)pictureBoxRight.Image ?? (Bitmap)pictureBoxLeft.Image;
                if (image2 == null) {
                    throw new ArgumentException();
                }
                int count = System.IO.File.ReadAllLines("Key.txt").Length;
                int[] k= new int[count];
                using (System.IO.StreamReader file =
            new System.IO.StreamReader("Key.txt", true))
                {
                    for (int j = 0; j < k.Length; j++)
                    {
                        k[j] = Convert.ToInt32(file.ReadLine());
                    }
                }
                
                int[] arr = new int[count];
                int x = 0, y = 0;
                int i=0;
                for (x = 0; x < image2.Width; x++)
                {
                    for (y = 0; y < image2.Height; )
                    {
                        if (i == arr.Length)
                            break;
                        Color pixelColor = image2.GetPixel(x, y);
                        arr[i] = pixelColor.B & 1;
                       
                        y += k[i];
                        i++;
                    }
                }
                for (x = 0; x < image2.Width; x++)
                {
                    for (y = 0; y < image2.Height; )
                    {
                        if (i == arr.Length)
                            break;
                        Color pixelColor = image2.GetPixel(x, y);
                        arr[i] = pixelColor.R & 1;
                        
                        y += k[i];
                        i++;
                    }
                }
                for (x = 0; x < image2.Width; x++)
                {
                    for (y = 0; y < image2.Height; )
                    {
                        if (i == arr.Length)
                            break;
                        Color pixelColor = image2.GetPixel(x, y);
                        arr[i] = pixelColor.G & 1;
                        
                        y += k[i];
                        i++;
                    }
                }
                string str=BinToStr(arr);
                if (chooseMethod.SelectedIndex == 2)
                {
                    char[] Key;
                    Key = new char[128];
                    int len=0;
                    using (System.IO.StreamReader file =
           new System.IO.StreamReader("KeyP.txt", true))
                    {
                        len = Convert.ToInt32(file.ReadLine());
                        file.Read(Key, 0, Key.Length);
                    }
                    char[] Key1 = new char[128];
                    char[] Dst = new char[str.Length + 1];
                    InvKey(Key, Key1, 128);
                    str = str.Remove(len);
                    Substitution(str.ToCharArray(), Key1, ref Dst);
                    str = new String(Dst);
                }
                labelOutputText.Text = "Распакованные данные: " + str;

            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error. " +
                    "Check the path to the file.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSaveText_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("WriteText.txt", true))
            {
                file.WriteLine(labelOutputText.Text.Substring(21));
            }
        }

        private void buttonSaveImg_Click(object sender, EventArgs e)
        {
            if (pictureBoxRight.Image != null)
            {
                string fileName = "myBitmap.bmp";
                System.IO.FileInfo fileInf = new System.IO.FileInfo(fileName);
                while (fileInf.Exists)
                {
                    fileName = "1" + fileName;
                    fileInf = new System.IO.FileInfo(fileName);
                }

                pictureBoxRight.Image.Save(fileName);
            }
        }

        private void buttonNewFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.bmp";
            openFileDialog1.Title = "Select a Image File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                pictureBoxLeft.Image = new Bitmap(openFileDialog1.OpenFile());
            }
        }
    }
}
