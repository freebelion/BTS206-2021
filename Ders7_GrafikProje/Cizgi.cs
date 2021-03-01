using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7_GrafikProje
{
   class Cizgi
   {
      private List<Point> noktalar = new List<Point>();

      public int NoktaSayisi
      {
         get { return noktalar.Count; }
      }
      public void Ekle(Point yeninokta)
      {
         noktalar.Add(yeninokta);
      }

      public Point this[int sirano]
      {
         get { return noktalar[sirano]; }
      }
   }
}
