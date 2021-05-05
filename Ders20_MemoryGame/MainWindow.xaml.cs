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
using System.Collections.ObjectModel;
using Microsoft.Win32;

namespace Ders20_MemoryGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Resimler { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Resimler = new ObservableCollection<string>();
            ResimleriTara();
            this.DataContext = this;
        }

        private void ResimleriTara()
        {
            OpenFileDialog resimTarayici = new OpenFileDialog();

            resimTarayici.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            resimTarayici.Multiselect = true;
            resimTarayici.Filter = "Resim dosyaları (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";

            if (resimTarayici.ShowDialog() == true)
            {
                foreach(string resim in resimTarayici.FileNames)
                {
                    Resimler.Add(resim);
                    Resimler.Add(resim);
                }
            }

            int i, j, n;
            string tmp;
            Random rnd = new Random();
            for(i = 0, n = Resimler.Count - 1; i < n; i++)
            {
                j = rnd.Next(i + 1, n);
                tmp = Resimler[i];
                Resimler[i] = Resimler[j];
                Resimler[j] = tmp;
            }
        }
    }
}
