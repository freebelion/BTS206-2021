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
      private int standartBoyut = 10;
      private Size standartSize;
      private Cizgi aktifCizgi;
      Graphics panelGrafik;
      bool cizgiCiziyor = false;
      Pen kalem = new Pen(Color.Blue, 2);
      public GrafikForm()
      {
         InitializeComponent();
      }

      private void CizimPaneli_MouseDown(object sender, MouseEventArgs e)
      {
         Point tiklananNokta = e.Location;
         
         if (rdKirikCizgi.Checked)
         {
            tiklananNokta.Offset(-standartBoyut / 2, -standartBoyut / 2);
            aktifCizgi.Ekle(tiklananNokta);
            if (aktifCizgi.NoktaSayisi > 1)
            {
               panelGrafik.DrawLine(kalem, aktifCizgi.Son(), aktifCizgi.Son(1));
            }
         }
         else if(rdSurekliCizgiler.Checked)
         {
            cizgiCiziyor = true;
            aktifCizgi.Ekle(tiklananNokta);
         }
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
         aktifCizgi = new Cizgi();
         panelGrafik = CizimPaneli.CreateGraphics();
      }

      private void CizimPaneli_MouseMove(object sender, MouseEventArgs e)
      {
         if (rdSurekliCizgiler.Checked && cizgiCiziyor)
         {
            aktifCizgi.Ekle(e.Location);

            if (aktifCizgi.NoktaSayisi > 1)
            {
               panelGrafik.DrawLine(kalem, aktifCizgi.Son(), aktifCizgi.Son(1));
            }
         }
      }

      private void CizimPaneli_MouseUp(object sender, MouseEventArgs e)
      {
         if (cizgiCiziyor) cizgiCiziyor = false;
      }

      private void CizimPaneli_Paint(object sender, PaintEventArgs e)
      {
         panelGrafik = CizimPaneli.CreateGraphics();
         for(int i=1; i < aktifCizgi.NoktaSayisi; i++)
         {
            panelGrafik.DrawLine(kalem, aktifCizgi[i], aktifCizgi[i - 1]);
         }
      }
   }
}
