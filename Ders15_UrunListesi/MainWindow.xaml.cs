using System;
using System.Collections.Generic;
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
using System.IO;

namespace Ders15_UrunListesi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Urun> urunler;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            urunler = new List<Urun>();

            StreamReader okuyucu = new StreamReader("Urunler.txt");
            string satir;
            string[] bilgiler;
            char[] ayiraclar = new char[] { ' ' };

            Urun yeniUrun;
            while (!okuyucu.EndOfStream)
            {
                satir = okuyucu.ReadLine();
                bilgiler = satir.Split(ayiraclar);
                yeniUrun = new Urun(bilgiler[0], Convert.ToDouble(bilgiler[1]));
                urunler.Add(yeniUrun);
            }

            lbUrunler.ItemsSource = urunler;
            lbUrunler.DisplayMemberPath = "Ad";
        }

        private void lbUrunler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Urun secilenUrun = lbUrunler.SelectedItem as Urun;
            // tbUrun.Text = secilenUrun.Fiyat.ToString("C2");
        }
    }
}
