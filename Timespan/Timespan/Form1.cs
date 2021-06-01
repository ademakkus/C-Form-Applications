using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timespan
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnFarkHesapla_Click(object sender, EventArgs e)
    {
      string nesne;
      TimeSpan fark = dateTimePicker2.Value.Subtract(dateTimePicker1.Value);
      nesne = fark.Days.ToString() + " gün " + fark.Hours + " saat " + fark.Minutes + " dakika " + fark.Seconds + " saniye";
      MessageBox.Show(nesne,"İki Tarih arasındaki fark");
    
    }
  }
}
