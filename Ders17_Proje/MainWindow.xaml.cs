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
using Microsoft.Win32;

namespace Ders17_Proje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> ResimDosyalari { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;
            ResimDosyalari = new ObservableCollection<string>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDLG = new OpenFileDialog();
            openDLG.Multiselect = false;
            openDLG.Filter = "Resim dosyaları (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";

            if(openDLG.ShowDialog() == true)
            {
                ResimDosyalari.Add(openDLG.FileName);
            }
        }
    }
}
