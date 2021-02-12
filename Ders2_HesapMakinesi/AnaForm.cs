using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders2_HesapMakinesi
{
   public partial class AnaForm : Form
   {
      private const int bosluk = 5;
      private TextBox tbEkran;
      public AnaForm()
      {
         InitializeComponent();

         this.Load += AnaForm_Load;
         this.SizeChanged += AnaForm_BoyutDegisti;
      }

      private void AnaForm_Load(object sender, EventArgs e)
      {
         this.tbEkran = new TextBox();
         this.Controls.Add(tbEkran);
         this.MinimumSize = new Size(200, 250);

         FormuDuzenle();
      }

      private void AnaForm_BoyutDegisti(object sender, EventArgs e)
      {
         FormuDuzenle();
      }

      private void FormuDuzenle()
      {
         this.tbEkran.Left = bosluk;
         this.tbEkran.Top = bosluk;
         tbEkran.Width = this.ClientRectangle.Width - 2 * bosluk;
      }
   }
}
