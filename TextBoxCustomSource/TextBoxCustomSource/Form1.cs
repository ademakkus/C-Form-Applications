using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxCustomSource
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_MouseDown(object sender, MouseEventArgs e)
    {
      switch (e.Button)
      {
        case MouseButtons.Left:
          MessageBox.Show("Sol tuş tıklandı.","Test");
          break;
        case MouseButtons.None: MessageBox.Show("Sol tuş tıklandı.","Test");
          break;
        case MouseButtons.Right: MessageBox.Show("Sağ tuş tıklandı.","Test");
          break;
        case MouseButtons.Middle: MessageBox.Show("Orta tuş tıklandı.","Test");
          break;
        case MouseButtons.XButton1: MessageBox.Show("X button tuş tıklandı.","Test");
          break;
        case MouseButtons.XButton2: MessageBox.Show("X2  tuş tıklandı.","Test");
          break;
        default:
          break;
      }
    }
  }
}
