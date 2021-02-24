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

namespace Ders6_AgacPanel
{
   public partial class TarayiciForm : Form
   {
      public TarayiciForm()
      {
         InitializeComponent();
      }

      private void TarayiciForm_Load(object sender, EventArgs e)
      {
         DirectoryInfo anaKlasor = new DirectoryInfo(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
         TreeNode ananod = new TreeNode(anaKlasor.Name);
         ananod.Tag = anaKlasor;
         KlasorPanel.Nodes.Add(ananod);
         KlasorPanelOlustur(anaKlasor, ananod);
      }

      private void KlasorPanelOlustur(DirectoryInfo anaKlasor, TreeNode ananod)
      {
         DirectoryInfo[] altKlasorler = anaKlasor.GetDirectories();

         foreach(DirectoryInfo altKlasor in altKlasorler)
         {
            TreeNode altnod = new TreeNode(altKlasor.Name);
            altnod.ImageIndex = 0;
            altnod.Tag = altKlasor;
            ananod.Nodes.Add(altnod);
            KlasorPanelOlustur(altKlasor, altnod);
         }
      }

      private void KlasorPanel_AfterSelect(object sender, TreeViewEventArgs e)
      {
         DosyaPanel.Items.Clear();

         DirectoryInfo seciliKlasor =
            KlasorPanel.SelectedNode.Tag as DirectoryInfo;

         FileInfo[] dosyalar = seciliKlasor.GetFiles();
         ListViewItem lvItem;
         foreach(FileInfo dosya in dosyalar)
         {
            lvItem = new ListViewItem(dosya.Name);
            lvItem.Tag = dosya;
            if(dosya.Extension == "txt")
            {

            }
            DosyaPanel.Items.Add(lvItem);
         }
      }
   }
}
