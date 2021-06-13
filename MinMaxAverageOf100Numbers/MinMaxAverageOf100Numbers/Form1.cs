using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinMaxAverageOf100Numbers
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      listBox1.Items.Clear();
      Random random = new Random();
      int negativeNumbers = 0;
      int positiveNumbers = 0;
      int notrNumbers = 0;
      double average = 0.0;
      double sum = 0.0;
      int min, max;
      int[] numbers = new int[100];
      for (int i = 0; i <100; i++)
      {
        numbers[i] = random.Next(-1000,1000);
        
        sum += numbers[i];
      }
      min = numbers[0];
      max = numbers[99];
      for (int i=0; i <100;i ++)
      {
        if (numbers[i] < min)
          min = numbers[i];
        else if (numbers[i] > max)
          max = numbers[i];
        listBox1.Items.Add(numbers[i]);
   
      }
      for (int i = 0; i < 100; i++)
      {
        if (numbers[i] < 0)
          negativeNumbers++;
        else if (numbers[i] > 0)
          positiveNumbers++;
        else if (numbers[i] == 0)
          notrNumbers++;
      }
      average = sum / 100;
      label1.Text = "Numbers of positive numbers : " + positiveNumbers.ToString();
      label2.Text = "Numbers of negative  numbers : " + negativeNumbers.ToString();
      label3.Text = "Average is :" + average.ToString();
      label4.Text = "Sum of Numbers is: " + sum.ToString();
      label5.Text = "Numbers of notr  numbers :" + notrNumbers.ToString();
      
      label6.Text = "Max :"+max.ToString();
      label7.Text ="Min:" +min.ToString();
    }
  }
}
