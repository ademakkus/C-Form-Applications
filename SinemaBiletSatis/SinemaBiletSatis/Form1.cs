using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletSatis
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Seans birinciSeans = new Seans("13:00", "1.Seans", "Terminatör");
      Seans ikinciSeans = new Seans("14:00", "2.Seans", "Esaretin Bedeli");
      Seans ucuncuSeans = new Seans("15:00", "3.Seans", "Yeşil Yol");
      Seans dorduncuSeans = new Seans("16:00", "4.Seans", "Bir zamanlar");
      Seans[] seanslar = new Seans[4];
      seanslar[0] =birinciSeans ;
      seanslar[1] =ikinciSeans ;
      seanslar[2] =ucuncuSeans ;
      seanslar[3] = dorduncuSeans;
      Koltuk[] birinciSeansKoltuklari = new Koltuk[70];
      Koltuk[] ikinciSeansKoltuklari = new Koltuk[100];
      Koltuk[] ucuncuSeansKoltuklari = new Koltuk[150];
      Koltuk[] dorduncuSeansKoltuklari = new Koltuk[300];
      birinciSeans.KoltukListesi = birinciSeansKoltuklari;
      ikinciSeans.KoltukListesi = ikinciSeansKoltuklari;
      ucuncuSeans.KoltukListesi = ucuncuSeansKoltuklari;
      dorduncuSeans.KoltukListesi = dorduncuSeansKoltuklari;
      cmbSeans.DataSource = seanslar;
    }
    public Seans SeciliSeans
    {
      get
      {
        return cmbSeans.SelectedItem as Seans;
      }
    }
    private void cmbSeans_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (SeciliSeans != null)
      {
        KoltukDoldur(SeciliSeans);
        SatisBilgileriHesapla(SeciliSeans);
      }
    }

    private void SatisBilgileriHesapla(Seans seciliSeans)
    {
      int satilanKoltukSayisi = 0;
      int rezerveKoltukSayisi = 0;
      int bosKoltukSayisi = 0;
      decimal satisTutari = 0.00M;
      foreach (Koltuk koltuk in SeciliSeans.KoltukListesi)
      {
        switch (koltuk.Durum)
        {
          case KoltukDurum.Bos:
            bosKoltukSayisi++;
            
            break;
          case KoltukDurum.Satilmis:
            satilanKoltukSayisi++;
            satisTutari += koltuk.Fiyat;
            break;
          case KoltukDurum.Rezerve:
            rezerveKoltukSayisi++;
            break;
          default:
            break;
        }
      }
      lblBos.Text = bosKoltukSayisi.ToString();
      lblSatilmis.Text = satilanKoltukSayisi.ToString();
      lblSatisTutari.Text = satisTutari.ToString("#,###.00 TL");
      lblRezerve.Text = rezerveKoltukSayisi.ToString();

    }

    private void KoltukDoldur(Seans seciliSeans)
    {
      flpSalon.Controls.Clear();
      for (int i = 0; i < SeciliSeans.KoltukListesi.Length; i++)
      {
        Koltuk koltuk = seciliSeans.KoltukListesi[i];
        Button btnKoltuk = new Button();
        btnKoltuk.Text = koltuk.KoltukNo.ToString();
        btnKoltuk.Size = new Size(33, 33);
        btnKoltuk.Font = new Font("Arial", 8, FontStyle.Bold);
        btnKoltuk.MouseDown += new MouseEventHandler(btnKoltuk_MosueDown);
        KoltukRenkAyarla(ref btnKoltuk, koltuk.Durum);
        flpSalon.Controls.Add(btnKoltuk);
      }
    }

    private void KoltukRenkAyarla(ref Button btnKoltuk, KoltukDurum durum)
    {
      switch (durum)
      {
        case KoltukDurum.Bos:
          btnKoltuk.BackColor = Color.White;
          break;
        case KoltukDurum.Satilmis:
          btnKoltuk.BackColor = Color.Navy;
          break;
        case KoltukDurum.Rezerve:
          btnKoltuk.BackColor = Color.Yellow;
          break;
        default:
          break;
      }
    }

    private void btnKoltuk_MosueDown(object sender, MouseEventArgs e)
    {
      Button btnTiklanan = sender as Button;
      if (btnTiklanan != null)
      {
        int koltukNo;
        if (int.TryParse(btnTiklanan.Text, out koltukNo))
        {
          if (e.Button == MouseButtons.Right)
          {
            if (SeciliSeans.KoltukListesi[koltukNo - 1].Durum == KoltukDurum.Rezerve)
            {
              SeciliSeans.KoltukListesi[koltukNo - 1].Durum = KoltukDurum.Bos;
            }
            else if(SeciliSeans.KoltukListesi[koltukNo - 1].Durum == KoltukDurum.Bos)
            {
              SeciliSeans.KoltukListesi[koltukNo - 1].Durum = KoltukDurum.Rezerve;
            }
           
          }
          else
          {
            SeciliSeans.KoltukListesi[koltukNo - 1].Durum = KoltukDurum.Satilmis;
          }
          KoltukRenkAyarla(ref btnTiklanan, SeciliSeans.KoltukListesi[koltukNo - 1].Durum);
          SatisBilgileriHesapla(SeciliSeans);
        }
      }
    }

    private void label3_Click(object sender, EventArgs e)
    {

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
      Font font = new Font("Verdana",36);
      SolidBrush brush = new SolidBrush(Color.Red);
      Pen pen = new Pen(Color.Red);
      e.Graphics.DrawLine(pen, 100, 100, 700, 100);
      e.Graphics.DrawString("SEANS SATIŞ FORMU", font, brush, 140, 140);
      e.Graphics.DrawLine(pen, 100, 210, 700, 210);

      font = new Font("Verdana", 16, FontStyle.Bold);
      e.Graphics.DrawString("Boş Koltuk Sayısı:", font, brush, 120, 308);
      e.Graphics.DrawString(lblBos.Text, font, brush, 600, 308);
      e.Graphics.DrawString("Rezerze Koltuk Sayısı:", font, brush, 120, 348);
      e.Graphics.DrawString(lblRezerve.Text, font, brush, 600, 348);
      e.Graphics.DrawString("Satılmış Koltuk Sayısı:", font, brush, 120, 388);
      e.Graphics.DrawString(lblSatilmis.Text, font, brush, 600, 388);
      e.Graphics.DrawLine(pen, 100, 300, 700, 300);
      e.Graphics.DrawLine(pen, 100, 450, 700, 450);
      e.Graphics.DrawString("Satış Tutarı:", font, brush, 120, 460);
      e.Graphics.DrawString(lblSatisTutari.Text, font, brush, 600, 460);
      brush = new SolidBrush(Color.DarkGreen);
      //brush.Color=
      e.Graphics.DrawString(cmbSeans.Text, font, brush, 100, 250);
      //StringFormat stringFormat = new StringFormat();
      //stringFormat.Alignment = StringAlignment.Center;
      //stringFormat.LineAlignment = StringAlignment.Center;
      //Rectangle rectangle = new Rectangle(10, 10, 130, 140);
      //e.Graphics.DrawString("hello world", font, brush, rectangle,stringFormat);
    }
  }
}
