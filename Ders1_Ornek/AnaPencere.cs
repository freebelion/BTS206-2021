using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1_Ornek
{
   public partial class AnaPencere : Form
   {
      public AnaPencere()
      {
         InitializeComponent();
      }

      private void PencereYuklendi(object sender, EventArgs e)
      {
         
      }

      private void btnEkle_Click(object sender, EventArgs e)
      {
         lbListe.Items.Add(tbMetin.Text);
         tbMetin.Clear();
         tbMetin.Focus();
      }
   }
}
