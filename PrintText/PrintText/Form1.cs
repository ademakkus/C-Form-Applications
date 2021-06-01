using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintText
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      pageSetupDialog1.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      printPreviewDialog1.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      printPreviewDialog1.ShowDialog();
      
    }

    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      Font myFont = new Font("Verdana", 14, FontStyle.Regular, GraphicsUnit.Pixel);
      string lorem = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
      e.Graphics.DrawString(lorem, myFont, Brushes.Red, 20,20);
    }
  }
}
