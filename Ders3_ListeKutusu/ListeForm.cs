using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders3_ListeKutusu
{
   public partial class AnaForm : Form
   {
      public AnaForm()
      {
         InitializeComponent();
      }

      private void lbListe_SelectedIndexChanged(object sender, EventArgs e)
      {
         tbMetin.Text = lbListe.Text;
      }

      private void ListeTusaBasildi(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Delete)
         {
            while (lbListe.SelectedIndices.Count > 0)
            {
               lbListe.Items.RemoveAt(lbListe.SelectedIndex);
            }
         }
      }
   }
}
