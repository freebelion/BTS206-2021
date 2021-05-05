using System;
using System.Collections.ObjectModel;

namespace Ders23_TreeView
{
    public class Eleman
    {
        public string Ad { get; set; }

        public Eleman(string strAd)
        {
            Ad = strAd;
        }
    }

    public class Sube
    {
        public string Ad { get; set; }

        public ObservableCollection<Eleman> Elemanlar { get; set; }

        public Sube(string strAd)
        {
            Ad = strAd;

            Elemanlar = new ObservableCollection<Eleman>();
        }
    }

    public class Bolge
    {
        public string Ad { get; set; }

        public ObservableCollection<Sube> Subeler { get; set; }

        public Bolge(string strAd)
        {
            Ad = strAd;

            Subeler = new ObservableCollection<Sube>();
        }
    }
}