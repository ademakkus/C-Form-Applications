using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDISample_2
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
    frmLogin login = new frmLogin();
      this.Visible = false;
      login.ShowDialog();
      DialogResult loginResult = login.ShowDialog();
      if (loginResult == DialogResult.OK)
      {
        this.Visible = true;
      }
      else
      {
        this.Visible = false;
      }
    }

    private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      if (e.Node.Tag == "YeniMusteri")
      {
        MusteriKartGoster();
      }
    }
    private void MusteriKartGoster()
    {
      frmCustomer customer = new frmCustomer();
      customer.MdiParent = this;
      customer.Show();
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MusteriKartGoster();
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      MusteriKartGoster();
    }
  }
}
