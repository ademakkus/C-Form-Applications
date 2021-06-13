using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombinationAndPermutationCOunt
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      numericUpDown1.Minimum = 1;
      numericUpDown1.Maximum = 20;
      numericUpDown2.Minimum = 1;
      numericUpDown2.Maximum = 20;

    }
    private int Factorial(int number)
    {
      int result = 1;
      for (int i = 1; i <=number; i++)
      {
        result *= i;
        if (result > int.MaxValue||result<1)
      {
        MessageBox.Show($"faktöriyel sonucu int en büyük değeri {int.MaxValue} büüyk", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return 0;
         // break;
      }
      }
            
        return result;
    }

    private void btnBirinci_Click(object sender, EventArgs e)
    {
    
       int number = Convert.ToInt32(numericUpDown1.Value);
      int factorialResult = Factorial(number);
        listBox1.Items.Add(number.ToString() + " faktöriyeli : " + factorialResult.ToString());
    }

    private void btnIkinci_Click(object sender, EventArgs e)
    {
  int number = Convert.ToInt32(numericUpDown2.Value);
      int factorialResult = Factorial(number);
        listBox1.Items.Add(number.ToString() + " faktöriyeli : " + factorialResult.ToString());
    }

    private void btnPermutation_Click(object sender, EventArgs e)
    {
      int number1 = Convert.ToInt32(numericUpDown1.Value);
      int number2 = Convert.ToInt32(numericUpDown2.Value);
      double permutation = Factorial(number1) / Factorial(number1 - number2);
      listBox1.Items.Add(number1.ToString() + " ile " +number2.ToString() + " permutasyonu : " + permutation.ToString()); 
    }

    private void btnCombination_Click(object sender, EventArgs e)
    {
      int number1 = Convert.ToInt32(numericUpDown1.Value);
      int number2 = Convert.ToInt32(numericUpDown2.Value);
      double permutation = Factorial(number1) /( Factorial(number1 - number2)*Factorial(number2));
      listBox1.Items.Add(number1.ToString() + " ile " + number2.ToString() + "  kombinasyonu : " + permutation.ToString());
    }
  }
}
