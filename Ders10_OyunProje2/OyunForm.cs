using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders10_OyunProje2
{
   public partial class OyunForm : Form
   {
      Properties.Settings ayarlar;
      PictureBox[,] resimler;
      Random rnd;
      PictureBox kaynakKutu;
      PictureBox hedefKutu;
      public OyunForm()
      {
         InitializeComponent();
      }

      private void OyunForm_Load(object sender, EventArgs e)
      {
         rnd = new Random((int)DateTime.Now.Ticks);
         ayarlar = new Properties.Settings();
         numMatrisBoyutu.Value = ayarlar.MatrisBoyutu;

         OyunPaneliDuzenle();
      }

      private void OyunPaneliDuzenle()
      {
         oyunPaneli.SuspendLayout();
         ayarlar.Reload();
         int N = ayarlar.MatrisBoyutu;
         resimler = new PictureBox[N, N];
         int boyut = Math.Min(oyunPaneli.Width, oyunPaneli.Height) / N;

         PictureBox kutu;
         for(int i = 0; i < N; i++)
         {
            for(int j = 0; j < N; j++)
            {
               resimler[i, j] = kutu = new PictureBox();
               kutu.Left = j * boyut;
               kutu.Top = i * boyut;
               kutu.Width = boyut;
               kutu.Height = boyut;
               kutu.SizeMode = PictureBoxSizeMode.Zoom;
               kutu.AllowDrop = true;
               kutu.MouseDown += Kutu_MouseDown;
               kutu.DragEnter += Kutu_DragEnter;
               kutu.DragDrop += Kutu_DragDrop;
               kutu.Image = resimListe.Images[rnd.Next(resimListe.Images.Count)];
               oyunPaneli.Controls.Add(kutu);
            }
         }
         oyunPaneli.ResumeLayout();
      }

      private void Kutu_DragDrop(object sender, DragEventArgs e)
      {
         hedefKutu = sender as PictureBox;
         kaynakKutu = e.Data.GetData(typeof(PictureBox)) as PictureBox;

         Image tmp = hedefKutu.Image;
         hedefKutu.Image = kaynakKutu.Image;
         kaynakKutu.Image = tmp;
      }

      private void Kutu_DragEnter(object sender, DragEventArgs e)
      {
         if(e.Data.GetDataPresent(typeof(PictureBox)))
         { e.Effect = DragDropEffects.Move; }
         else { e.Effect = DragDropEffects.None; }
      }

      private void Kutu_MouseDown(object sender, MouseEventArgs e)
      {
         kaynakKutu = sender as PictureBox;
         kaynakKutu.DoDragDrop(kaynakKutu, DragDropEffects.Move);
      }

      private void numMatrisBoyutu_ValueChanged(object sender, EventArgs e)
      {
         ayarlar.MatrisBoyutu = (int) numMatrisBoyutu.Value;
         ayarlar.Save();
         oyunPaneli.Controls.Clear();
         OyunPaneliDuzenle();
      }
   }
}
