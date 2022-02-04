using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RHMDIL.Views
{
    /// <summary>
    /// Логика взаимодействия для OperationRoom1.xaml
    /// </summary>
    public partial class OperationRoom1 : UserControl
    {
        public OperationRoom1()
        {
            InitializeComponent();
            using (DB.ANGIODBContext db = new DB.ANGIODBContext())

            {

                List<OperationRoom1> list = DB.OperationRoom1.ToList();
                gridOperationRoom1.ItemsSource = list;

            }
        }
    }
}