using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ders5_AcilirListeKutusu
{
   public partial class TarayiciForm : Form
   {
      public TarayiciForm()
      {
         InitializeComponent();
      }

      private void TarayiciForm_Load(object sender, EventArgs e)
      {
         string strBelgelerKlasor =
            Environment.GetFolderPath(
               Environment.SpecialFolder.MyDocuments);

         UstKlasorSec(strBelgelerKlasor);
      }

      private void cbKlasorler_SelectedIndexChanged(object sender, EventArgs e)
      {
         DirectoryInfo seciliKlasor =
            cbKlasorler.SelectedItem as DirectoryInfo;
         UstKlasorSec(seciliKlasor.FullName);

         lbDosyalar.Items.Clear();
         lbDosyalar.Items.AddRange(
            seciliKlasor.GetFiles());
      }

      private void UstKlasorSec(string strKlasor)
      {
         cbKlasorler.Items.Clear();

         DirectoryInfo ustKlasor =
            new DirectoryInfo(strKlasor);

         DirectoryInfo[] altKlasorler =
            ustKlasor.GetDirectories();

         cbKlasorler.Items.AddRange(altKlasorler);
      }
   }
}
