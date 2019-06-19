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

namespace _13._06._4v
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Right_Click(object sender, RoutedEventArgs e)
    {
      var currentDomain = AppDomain.CurrentDomain;
      var DownloadFile = AppDomain.CreateDomain("Download File");
      var download = currentDomain.BaseDirectory + "Download File.exe";
      DownloadFile.ExecuteAssembly(download);
      AppDomain.Unload(DownloadFile);
    }

    private void Lift_Click(object sender, RoutedEventArgs e)
    {
      var currentDomain = AppDomain.CurrentDomain;
      var Сalculator = AppDomain.CreateDomain("Calculations");
      var CalculationsPath = currentDomain.BaseDirectory + "Calculations.exe";
      Сalculator.ExecuteAssembly(CalculationsPath);
      AppDomain.Unload(Сalculator);
    }
  }
}
