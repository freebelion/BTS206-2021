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

namespace Ders23_TreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Bolge> Bolgeler { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Bolgeler = new ObservableCollection<Bolge>();

            Bolge bolge = new Bolge("Marmara");

            Sube s = new Sube("Istanbul");
            s.Elemanlar.Add(new Eleman("Cilalı İbo"));
            s.Elemanlar.Add(new Eleman("Turist Ömer"));
            bolge.Subeler.Add(s);

            Bolgeler.Add(bolge);

            this.DataContext = this;
        }
    }
}
