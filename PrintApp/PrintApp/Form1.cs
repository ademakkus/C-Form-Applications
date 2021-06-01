using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace PrintApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
      DialogResult dialog;
      dialog = printDialog1.ShowDialog();
      if (dialog == DialogResult.OK)
      {
        printDocument1.Print();
      }
    }

    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      e.Graphics.DrawEllipse(Pens.Red, e.MarginBounds);
      GraphicsPath myPath = new GraphicsPath();
      myPath.AddRectangle(new Rectangle(33, 44, 200, 150));
      e.Graphics.DrawPath(Pens.Blue, myPath);


      e.HasMorePages = false;   //son sayfada yazılmalıdır. diğer sayfalarda    e.HasMorePages = true; 
   ///   e.Cancel = true; //yazdırmayı iptal et
   ///   
    }

    private void btnPageSetup_Click(object sender, EventArgs e)
    {
      pageSetupDialog1.ShowDialog();
    }

    private void btnPrintPreview_Click(object sender, EventArgs e)
    {
      DialogResult previewResult;
      previewResult = printPreviewDialog1.ShowDialog();
      if (previewResult == DialogResult.OK)
        printDocument1.Print();
    }

    private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
      MessageBox.Show("Print işlemi bitene kadar bekleyiniz.","Print işlemi",MessageBoxButtons.OK,MessageBoxIcon.Information);
    }

    private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
      MessageBox.Show("Print işlemi bitti.", "Print işlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
