using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompareImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnOpnFile1_Click(object sender, EventArgs e)
        {
            txtBoxOpnFile1.Clear();
            OpenFileDialog opnDlg = new OpenFileDialog();
            opnDlg.ShowDialog();
            string str = opnDlg.FileName;
            txtBoxOpnFile1.AppendText(str);

        }

        private void BtnOpnFile2_Click(object sender, EventArgs e)
        {
            txtBoxOpnFile2.Clear();
            OpenFileDialog opnDlg = new OpenFileDialog();
            opnDlg.ShowDialog();
            txtBoxOpnFile2.AppendText(opnDlg.FileName);
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            if((txtBoxOpnFile1.Text != null)&&(txtBoxOpnFile2.Text != null))
            {
                double entropySumFirst, entropySumSecond;
                entropySumFirst = EntropyCounting(txtBoxOpnFile1.Text);
                entropySumSecond = EntropyCounting(txtBoxOpnFile2.Text);
                Compare(entropySumFirst, entropySumSecond);
            }else
            {
                MessageBox.Show("Nie podano ścieżki do obrazu");
            }
        }

        private double EntropyCounting(string filePath)
        {
            Image img = Image.FromFile(filePath);
            double entropySum = 0; //selfexplaining - propably should be list too 
            List<int> pixelsArray = new List<int>(); //List of RGB Data
            int[] counter = new int[256]; //Count how many times specific number apear in 128-elements
            using (Bitmap bmp = new Bitmap(img))
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        //Adding RGB info to array
                        Color clr = bmp.GetPixel(x, y);
                        pixelsArray.Add(clr.R);
                        pixelsArray.Add(clr.G);
                        pixelsArray.Add(clr.B);
                    }
                }
            }
            //Counting Shannon's Entropy for every 128 
            int section = (int)pixelsArray.Count / 128;
            for (int j = 0; j < section; j++)
            {
                for (int i = (128 * j); i <= 127 + 128 * j; i++)
                {
                    //Counting amount of elements of specific number
                    int num = pixelsArray[i];
                    ++counter[num];
                }
                for (int i = 128 * j; i <= 127 + 128 * j; i++)
                {
                    if (counter[pixelsArray[i]] != 0)
                    {
                        entropySum += ((double)counter[pixelsArray[i]] / 128) * Math.Log(128 / counter[pixelsArray[i]], 2);
                    }
                }
                Array.Clear(counter, 0, counter.Length);

                
            }
            entropySum = entropySum / section;
            return entropySum;
        }
        private void Compare(double entropySumFirst, double entropySumSecond)
        {
            double result;
            if (entropySumFirst > entropySumSecond)
            {
                result = entropySumSecond / entropySumFirst * 100;
            }else
            {
                result = entropySumFirst / entropySumSecond * 100;
            }
            MessageBox.Show("Obrazy podobne w " + result.ToString() + "%");
        }
    }
}
