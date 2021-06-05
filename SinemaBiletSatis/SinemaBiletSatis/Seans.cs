using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatis
{
  public class Seans
  {
    private string _seanSaati;
    private string _seansAdi;
    private string _filmAdi;
    private Koltuk[] _koltukListesi;
    public string SeanSaati { get => _seanSaati; set => _seanSaati = value; }
    public string SeansAdi { get => _seansAdi; set => _seansAdi = value; }
    public string FilmAdi { get => _filmAdi; set => _filmAdi = value; }
    public Koltuk[] KoltukListesi
    {
      get { return _koltukListesi; }
      set
      {
        for(int i = 0; i < value.Length; i++)
        {
          Koltuk bosKoltuk = new Koltuk();
          bosKoltuk.Durum = KoltukDurum.Bos;
          bosKoltuk.Fiyat = 10.00M;
          bosKoltuk.KoltukNo = i + 1;
          value[i] = bosKoltuk;
        }
        _koltukListesi = value;
      }
    
    }

    public Seans(string seansSaati, string seansAdi, string filmAdi)
    {
      this.SeanSaati = seansSaati;
      this.SeansAdi = seansAdi;
      this.FilmAdi = filmAdi;
    }

    public override string ToString()
    {
      string seansBilgisi = this.SeansAdi + " " + this.SeanSaati + " " + this.FilmAdi;
      return seansBilgisi;
    }
  }
}
