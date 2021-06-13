using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
  
  public partial class Form1 : Form
  {
   
    public Form1()
    {
     
      InitializeComponent();
    }
    int attempt=3;
    private void enterButton_Click(object sender, EventArgs e)
    {
      while (attempt > 0)
      {
        if (userNameTextBox.Text=="admin" && passwordTextBox.Text == "123456")
        {
          Form2 form2 = new Form2(userNameTextBox.Text, passwordTextBox.Text);
          form2.ShowDialog();
          break;
        }
        else

        {
          MessageBox.Show("Inavlid username or passsword","Wrong Attempt",MessageBoxButtons.OK,MessageBoxIcon.Error);
          attempt--;
          Clear();
          break;
        }
      
      }
      if (attempt == 0)
      {
        MessageBox.Show("You have entered incorrectly 3 times.", "Wrong Attempt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Application.Exit();
      }
      {

      }
    }
    private void Clear()
    {
      userNameTextBox.Text = "";
      passwordTextBox.Text = "";
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      Clear();
    }
  }
}
