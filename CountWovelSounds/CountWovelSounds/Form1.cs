using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountWovelSounds
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int vowels = 0;
      int consonants = 0;
      string text = textBox1.Text.ToLower();
      for (int i = 0; i < text.Length; i++)
      {
        switch (text[i])
        {
          case 'a':
            vowels++;
            break;
          case 'e':
            vowels++;
            break;
          case 'ı':
            vowels++;
            break;
          case 'i':
            vowels++;
            break;
          case 'o':
            vowels++;
            break;
          case 'ö':
            vowels++;
            break;
          case 'u':
            vowels++;
            break;
          case 'ü':
            vowels++;
            break;
          default:
            consonants++;
            break;
        }
      }
      consonantslabel.Text = "Number of consonants: " + consonants.ToString();
      vowelslabel.Text = "Numbers of vowels: " + vowels.ToString();
    }
  }
}
