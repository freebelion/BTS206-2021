using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Ders19_BankaProje2
{
    public class Hesap : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OzellikDegisti(string ozellikAdi)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(ozellikAdi));
            }
        }

        private decimal m_bakiye;

        public decimal Bakiye
        {
            get { return m_bakiye; }
        }

        public void ParaEkle(decimal tutar)
        {
            m_bakiye += tutar;
            OzellikDegisti("Bakiye");
        }

        public void ParaCek(decimal tutar)
        {
            if(m_bakiye >= tutar)
            {
                m_bakiye -= tutar;
                OzellikDegisti("Bakiye");
            }
        }
    }

    public class HesapListe : ObservableCollection<Hesap> { }

}
