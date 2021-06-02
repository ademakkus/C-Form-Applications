using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrint
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnFirst_Click(object sender, EventArgs e)
    {
      lvProducts.Items[0].Selected = true;
      lvProducts.Focus();
      getLocation();
    }
    private void getLocation()
    {
      lblLocation.Text = (lvProducts.SelectedIndices[0] +1).ToString ()+ "/" + lvProducts.Items.Count.ToString();
    }

    private void btnPrevious_Click(object sender, EventArgs e)
    {
      if (lvProducts.SelectedIndices[0] > 0)
        lvProducts.Items[lvProducts.SelectedIndices[0] - 1].Selected = true;
      lvProducts.Focus();
      getLocation();
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
      if (lvProducts.SelectedIndices[0] < lvProducts.Items.Count - 1)
      {
        lvProducts.Items[lvProducts.SelectedIndices[0] + 1].Selected = true;
        lvProducts.Focus();
        getLocation();
      }
    }

    private void btnLast_Click(object sender, EventArgs e)
    {
      lvProducts.Items[lvProducts.Items.Count-1].Selected = true;
      lvProducts.Focus();
      getLocation();
    }

    private void lvProducts_MouseClick(object sender, MouseEventArgs e)
    {
      getLocation();
    }

    private void lvProducts_KeyDown(object sender, KeyEventArgs e)
    {
      getLocation();
    }

    private void lvProducts_KeyUp(object sender, KeyEventArgs e)
    {
      getLocation();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      lvProducts.Items[0].Selected = true;
      getLocation();
      GetSum();

    }
    private void GetSum()
    {
      decimal sum = 0;
      for (int i = 0; i < lvProducts.Items.Count; i++)
      {
        sum += Convert.ToDecimal(lvProducts.Items[i].SubItems[2].Text)*Convert.ToDecimal(lvProducts.Items[i].SubItems[1].Text);
      }
      txtSum.Text = sum.ToString("#,###.00 TL");
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnPageSetup_Click(object sender, EventArgs e)
    {
      pageSetupDialog1.ShowDialog();
    }

    private void btnPreview_Click(object sender, EventArgs e)
    {
      printPreviewDialog1.ShowDialog();
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
      DialogResult result = printDialog1.ShowDialog();
      if (result == DialogResult.OK)
      {
        printDocument1.Print();
      }
    }

    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      Font myFont = new Font("Verdan", 36);
      SolidBrush brush = new SolidBrush(Color.Red);
      Pen pen = new Pen(Brushes.Blue);
      e.Graphics.DrawLine(pen, 100, 100, 700, 100);
      e.Graphics.DrawLine(pen, 100, 160, 700, 160);
      e.Graphics.DrawString("SİPARİŞ FROMU", myFont, brush,180,100);
      e.Graphics.DrawLine(pen, 100, 300, 700, 300);
      myFont = new Font("Verdana", 10, FontStyle.Bold);
        e.Graphics.DrawImage(Properties.Resources.logo, 0, 0);
         e.Graphics.DrawString("Ürün Adı", myFont, brush, 100, 308);
      e.Graphics.DrawString("Adet", myFont, brush, 300, 308);
      e.Graphics.DrawString("Birim Fiyatı", myFont, brush, 400, 308);
      e.Graphics.DrawString("Toplam Fiyat", myFont, brush, 560, 308);

      e.Graphics.DrawLine(pen, 100, 330, 700, 330);
      int y = 340;
      StringFormat sf = new StringFormat();
      sf.Alignment = StringAlignment.Far;
      foreach (ListViewItem li  in lvProducts.Items)
      {
     
        e.Graphics.DrawString(li.Text, myFont, brush, 100, y);
        e.Graphics.DrawString(li.SubItems[1].Text, myFont, brush, 300, y, sf);
        decimal birimFiyat = Convert.ToDecimal(li.SubItems[2].Text);
        decimal fiyat = Convert.ToDecimal(li.SubItems[1].Text)*Convert.ToDecimal(li.SubItems[2].Text);
        e.Graphics.DrawString(birimFiyat.ToString("c"), myFont, brush, 400,y,sf);
        e.Graphics.DrawString(fiyat.ToString("c"), myFont, brush, 560, y, sf);

        y += 20;

      }
    }

    private void printPreviewDialog1_Load(object sender, EventArgs e)
    {
    
    }
  }
}
