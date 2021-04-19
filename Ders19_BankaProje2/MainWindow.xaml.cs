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

namespace Ders19_BankaProje2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ParaEkle_Click(object sender, RoutedEventArgs e)
        {
            Hesap aktifHesap = (sender as Button).Tag as Hesap;
            aktifHesap.ParaEkle(10);
        }

        private void ParaCek_Click(object sender, RoutedEventArgs e)
        {
            // AktifHesap.ParaCek(10);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for(int i=0; i < 5; i++)
            {
                Hesaplar.Add(new Hesap());
            }
        }
    }
}
