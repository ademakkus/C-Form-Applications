using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatis
{

  public class Koltuk
  {
    private int _koltukNo;

    public int KoltukNo { get => _koltukNo; set => _koltukNo = value; }   
    private decimal _fiyat;
    public decimal Fiyat { get => _fiyat; set => _fiyat = value; }
    public KoltukDurum Durum { get => durum; set => durum = value; }

    private KoltukDurum durum;
 
  }
}
