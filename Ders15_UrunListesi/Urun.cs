using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders15_UrunListesi
{
    public class Urun
    {
        private string urunAdi;
        private double urunFiyati;

        public Urun(string uad, double ufiyat)
        {
            urunAdi = uad;
            Fiyat = ufiyat;
        }

        public double Fiyat
        {
            get { return urunFiyati; }
            set
            {
                if(value > 0)
                { urunFiyati = value; }
            }
        }

        public string Ad
        {
            get { return urunAdi; }
        }
    }
}
