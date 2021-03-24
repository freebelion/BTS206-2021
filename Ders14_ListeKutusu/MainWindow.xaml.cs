using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ders14_ListeKutusu
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private Random rnd = new Random();
      
      public ObservableCollection<Yuk> Yukler { get; set; }

      public MainWindow()
      {
         InitializeComponent();
      }

      private void yukAl(object sender, RoutedEventArgs e)
      {
         int yukSayisi = 1 + rnd.Next(10);

         Yuk yeniYuk;
         for(int i=0; i < yukSayisi; i++)
         {
            yeniYuk = new Yuk(10 * rnd.NextDouble());
            Yukler.Add(yeniYuk);
         }
      }

      private void yukGonder(object sender, RoutedEventArgs e)
      {
         int yukSayisi = 1 + rnd.Next(10);

         yukSayisi = Math.Min(Yukler.Count, yukSayisi);

         while(yukSayisi > 0)
         {
            Yukler.RemoveAt(0);
            yukSayisi--;
         }
      }

      private void Window_Loaded(object sender, RoutedEventArgs e)
      {
         Yukler = new ObservableCollection<Yuk>();
         this.DataContext = this;
      }
   }
}
