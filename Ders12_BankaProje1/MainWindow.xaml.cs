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

namespace Ders12_BankaProje1
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private decimal bakiye = 0;
      public MainWindow()
      {
         InitializeComponent();
      }

      private void btn10TLYatir_Click(object sender, RoutedEventArgs e)
      {
         bakiye += 10;
         tbBakiye.Text = bakiye.ToString("C");
      }

      private void Window_Loaded(object sender, RoutedEventArgs e)
      {
         tbBakiye.Text = bakiye.ToString("C");
      }
   }
}
