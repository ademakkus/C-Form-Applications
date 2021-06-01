using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintFile
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void toolStripTextBox1_Click(object sender, EventArgs e)
    {

    }

    private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      pageSetupDialog1.ShowDialog();
    }
    string str;
    string[] rows;
    private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult openFileDialogResult;
      openFileDialogResult = openFileDialog1.ShowDialog();
      if (openFileDialogResult == DialogResult.OK)
      {
        StreamReader reader = new StreamReader(openFileDialog1.FileName);
        str = reader.ReadToEnd();
        reader.Close();
        rows = str.Split('\n');
      }
    }

    private void printToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult result = printDialog1.ShowDialog();
      if (result == DialogResult.OK)
      {
        arrayCounter = 0;
        printDocument1.Print();
      }
    }

    private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
    {
      arrayCounter = 0;
      printPreviewDialog1.ShowDialog();
    }
    int arrayCounter = 0;
    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      float leftMargin = e.MarginBounds.Left;
      float topMargin = e.MarginBounds.Top;
      float myLines = 0;
      float yPosition = 0;
      int counter = 0;
      string currentLine;
      myLines=e.MarginBounds.Height/this.Font.GetHeight(e.Graphics);
      while (counter < myLines && arrayCounter <= rows.Length - 1)
      {
        currentLine = rows[arrayCounter];
        yPosition = topMargin + counter * this.Font.GetHeight(e.Graphics);
        e.Graphics.DrawString(currentLine, this.Font, Brushes.Red, leftMargin, yPosition, new StringFormat());
        counter++;
        arrayCounter++;
        if (!(arrayCounter >= rows.GetLength(0) - 1)){
          e.HasMorePages = true;
        }
        else
        {
          e.HasMorePages = false;
        }
      }

    }
  }
}
