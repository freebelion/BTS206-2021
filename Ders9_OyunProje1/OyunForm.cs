using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders9_OyunProje1
{
   public partial class OyunForm : Form
   {
      private Graphics panelGrafik;
      private Properties.Settings ayarlar;

      private int hedefBoyutu = 10;
      private Brush hedefFirca;
      private Random rnd = new Random();
      
      public OyunForm()
      {
         InitializeComponent();
      }

      private void Zamanlayici_Tick(object sender, EventArgs e)
      {
         panelGrafik.Clear(ayarlar.BosRenk);

         int x = rnd.Next(OyunPanel.Width - hedefBoyutu);
         int y = rnd.Next(OyunPanel.Height - hedefBoyutu);

         panelGrafik.FillRectangle(hedefFirca, new Rectangle(x, y, hedefBoyutu, hedefBoyutu));
      }

      private void OyunForm_Load(object sender, EventArgs e)
      {
         ayarlar = new Properties.Settings();
         ayarlar.Reload();
         
         Zamanlayici.Interval = ayarlar.ZamanAralik;
         hedefFirca = new SolidBrush(ayarlar.HedefRengi);
         OyunPanel.BackColor = ayarlar.BosRenk;

         panelGrafik = OyunPanel.CreateGraphics();
      }

      private void btnBaslat_Click(object sender, EventArgs e)
      {
         Zamanlayici.Start();
      }

      private void tbZamanAralik_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            string str = tbZamanAralik.Text;
            try
            {
               int sayi = Convert.ToInt32(str);

               if (sayi >= ayarlar.MinimumAralik && sayi <= ayarlar.MaximumAralik)
               {
                  ayarlar.ZamanAralik = sayi;
                  Zamanlayici.Interval = ayarlar.ZamanAralik;
                  ayarlar.Save();
               }
            }
            catch { }
         }
      }
   }
}
