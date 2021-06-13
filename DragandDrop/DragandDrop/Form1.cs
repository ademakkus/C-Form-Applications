using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragandDrop
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void textBox1_MouseDown(object sender, MouseEventArgs e)
    {
      textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
    }

    private void textBox2_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.Text))
      {
        e.Effect = DragDropEffects.Copy;
      }
    }

    private void textBox2_DragDrop(object sender, DragEventArgs e)
    {
      //textBox2.Text+= (string)e.Data.GetData(DataFormats.Text);
      textBox2.Text= (string)e.Data.GetData(DataFormats.Text);
    }
  }
}
