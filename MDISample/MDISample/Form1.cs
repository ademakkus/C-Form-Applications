using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDISample
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void müşteriBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form2 frmChild = new Form2();
      frmChild.MdiParent = this;
      frmChild.Show();
    }

    private void aktifFormToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form myActiveForm = this.ActiveMdiChild;
      if (myActiveForm != null)
      {
    //    MessageBox.Show(myActiveForm.Text,"Test");
    if(myActiveForm.ActiveControl is TextBox)
        {
          TextBox myActiveTexBox = (TextBox)myActiveForm.ActiveControl;
          IDataObject data = Clipboard.GetDataObject();
          if (data.GetDataPresent(DataFormats.Text))
          {
            myActiveTexBox.Text = data.GetData(DataFormats.Text).ToString();
          }
        }
      }
    }

    private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.Cascade);
    }

    private void yatayHizalaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void dikeyHizalaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.TileVertical);
    }

    private void arrangeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.ArrangeIcons);
    }
  }
}
