using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    Bitmap image;
    private void btnResimAc_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      if (ofd.ShowDialog ()== DialogResult.OK)
      {
        pictureBox1.ImageLocation = ofd.FileName;
        image = new Bitmap(ofd.FileName);
        pictureBox1.Width = image.Width;
        pictureBox2.Height = image.Height;
  
      }
    }

    private void btnResimDonustur_Click(object sender, EventArgs e)
    {
      int valueR, valueG, valueB;
      Bitmap newImage = new Bitmap(image.Width, image.Height);
      for (int i = 0; i < image.Width; i++)
      {
        for (int j = 0; j < image.Height; j++)
        {
          valueR = 255 - image.GetPixel(i, j).R;
          valueG = 255 - image.GetPixel(i, j).G;
          valueB = 255 - image.GetPixel(i, j).B;
          newImage.SetPixel(i, j, Color.FromArgb(valueR, valueG, valueB));

        }
        pictureBox2.Image = newImage;
        pictureBox2.Width = newImage.Width;
        pictureBox2.Height = newImage.Height;
     
      }
    }
  }
}
