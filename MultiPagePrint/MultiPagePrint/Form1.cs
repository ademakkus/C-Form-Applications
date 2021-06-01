using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPagePrint
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    int x, y;
    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      e.Graphics.FillEllipse(Brushes.Blue, 
        new Rectangle(
                                       -e.PageBounds.Width*x,-e.PageBounds.Height*y,
                                       e.PageBounds.Width*2,
                                      e.PageBounds.Height*6)
                                     );
      y++;
      if(y==6 & x == 0)
      {
        y = 0;
        x++;
        e.HasMorePages = true; //printDocument1_PrintPage tekrar çalışır
      }
      else if(y==6 & x == 1)
      {
        e.HasMorePages = false;   //yazdırılacak sayfa kalmadı, yazdırma işlemini bitir
      }
      else
      {
        e.HasMorePages = true;        //yazdırılacak sayfalar var
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      printPreviewDialog1.ShowDialog();
    }
  }
}
