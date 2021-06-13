using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentencesCount
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string text = richTextBox1.Text;
      char[] charArray = richTextBox1.Text.ToCharArray();
      int counter = 0;
      for (int i = 0; i < text.Length; i++)
      {
        if (text[i] == '!' || text[i] == '?' || text[i] == '.' )
          counter++;
      }

      MessageBox.Show("There are " + counter.ToString()+" sentences.", "Sentences Count");
    }
  }
}
