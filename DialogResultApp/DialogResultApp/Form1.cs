using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogResultApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Form2 frm2 = new Form2();
      DialogResult result = frm2.ShowDialog();
      if(result==DialogResult.OK)
        MessageBox.Show("OK Tuşuna basıldı.","Basılan Tuş");
      else
        MessageBox.Show("Cancel tuşuna basıldı.", "Basılan Tuş");
    }
  }
}
