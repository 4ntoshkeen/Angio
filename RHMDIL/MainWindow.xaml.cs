using RHMDIL.DB;
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

namespace RHMDIL
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (ANGIODBContext db = new ANGIODBContext())
            {

            }
        }

        private void btnOperationRoom1_Click(object sender, RoutedEventArgs e)
        {
            lblWindowName.Content = "PHILIPS AZURION";
            DataContext = new ViewModels.OperationRoom1ViewModel();

        }
    }
}
