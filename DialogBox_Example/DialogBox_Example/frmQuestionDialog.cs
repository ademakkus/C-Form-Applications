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
  public partial class frmQuestionDialog : Form
  {
    public string MyAnswer
    {
      get
      {
        return txtAnswer.Text;
      }
    }
    public frmQuestionDialog()
    {
      InitializeComponent();
    }

    private void frmQuestionDialog_Load(object sender, EventArgs e)
    {
      Form1 ownerForm = (Form1)this.Owner;
      lblQuestion.Text = ownerForm.QuestionText;
    }
  }
}
