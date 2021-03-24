using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders14_ListeKutusu
{
   public class Yuk
   {
      private double yukAgirlik;

      public Yuk(double ilkAgirlik)
      {
         yukAgirlik = ilkAgirlik;
      }

      public double Agirlik
      {
         get { return yukAgirlik; }
      }

      public override string ToString()
      {
         return yukAgirlik.ToString("0.000");
      }
   }
}
