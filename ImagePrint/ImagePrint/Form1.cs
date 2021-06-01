using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagePrint
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

    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      e.Graphics.DrawImage(Properties.Resources.Sketchpad,
        new Point(10,10)
        );
    }

    private void button1_Click(object sender, EventArgs e)
    {
      pageSetupDialog1.ShowDialog();
      printPreviewDialog1.ShowDialog();
      printDialog1.ShowDialog();
    }
  }
}
