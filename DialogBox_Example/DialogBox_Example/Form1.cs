using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogBox_Example
{
  public partial class Form1 : Form
  {
    private string questionText;
    public Form1()
    {
      InitializeComponent();
    }

    public string QuestionText { get => questionText; set => questionText = value; }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnName_Click(object sender, EventArgs e)
    {
      QuestionText = "Enter your name:";
      string answer =SetText().Trim();
      if (answer!="")
      {
        txtName.Text = answer; 

      }
    }
    private string SetText()
    {
      frmQuestionDialog questionDialog=new frmQuestionDialog();
      DialogResult myResult = questionDialog.ShowDialog(this);
      if (myResult == DialogResult.OK)
        return questionDialog.MyAnswer;
      else
        return "";

    }

    private void btnSurname_Click(object sender, EventArgs e)
    {
      QuestionText = "Enter your name:";
      string answer = SetText().Trim();
      if (answer != "")
      {
        txtSurname.Text = answer;

      }
    }

    private void btnAdNewCity_Click(object sender, EventArgs e)
    {
      QuestionText = "Enter your name:";
      string answer = SetText().Trim();
      if (answer != "")
      {
        lstCity.Items.Add(answer);

      }
    }
  }
}
