using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseDown
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_MouseDown(object sender, MouseEventArgs e)
    {
      string tıklanan = " ";
      switch (e.Button)
      {
        case MouseButtons.Left: tıklanan = "Sol tuş ";   break;
        case MouseButtons.None: tıklanan = "Hiç bir tuş ";
          break;
        case MouseButtons.Right: tıklanan = "Sağ tuş ";
          break;
        case MouseButtons.Middle: tıklanan = "Orta tuş ";
          break;
        case MouseButtons.XButton1: tıklanan = "X tuş ";
          break;
        case MouseButtons.XButton2: tıklanan = "X2c tuş";
          break;
        default:
          tıklanan = " ";
          break;
      }
      textBox1.Text = tıklanan + " tıklandı";
      textBox2.Text = e.Clicks.ToString();
      textBox3.Text = e.Delta.ToString();
      textBox4.Text = e.Location.ToString();
      textBox5.Text = e.X.ToString();
      textBox6.Text = e.Y.ToString();

    }
  }
}
