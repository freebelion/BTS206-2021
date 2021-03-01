using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders7_GrafikProje
{
   public partial class GrafikForm : Form
   {
      private int standartBoyut = 15;
      private Size standartSize;
      public GrafikForm()
      {
         InitializeComponent();
      }

      private void CizimPaneli_MouseDown(object sender, MouseEventArgs e)
      {
         Point tiklananNokta = e.Location;
         tiklananNokta.Offset(-standartBoyut / 2, -standartBoyut / 2);

         Graphics gr = CizimPaneli.CreateGraphics();
         Rectangle rect = new Rectangle(tiklananNokta, standartSize);
         gr.FillEllipse(Brushes.Black, rect);
      }

      private void rdKirikCizgi_CheckedChanged(object sender, EventArgs e)
      {
         if(rdKirikCizgi.Checked)
         {
            this.Text = "Kırık Çizgiler";
         }
      }

      private void rdSurekliCizgiler_CheckedChanged(object sender, EventArgs e)
      {
         if(rdSurekliCizgiler.Checked)
         {
            this.Text = "Sürekli Çizgiler";
         }
      }

      private void GrafikForm_Load(object sender, EventArgs e)
      {
         standartSize = new Size(standartBoyut, standartBoyut);
      }
   }
}
