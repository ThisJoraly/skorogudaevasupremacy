using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using zhopaSArfoi.TownLibraryDataSetTableAdapters;

namespace zhopaSArfoi
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        ReaderTableAdapter reader = new ReaderTableAdapter();
        public Window1()
        {
            InitializeComponent();
            YetAnotherGrid.ItemsSource = reader.GetDataBy3();
        }

        private void YetAnotherGrid_Loaded(object sender, RoutedEventArgs e)
        {
            YetAnotherGrid.Columns[0].Visibility = Visibility.Collapsed;
            YetAnotherGrid.Columns[4].Visibility = Visibility.Collapsed;
            YetAnotherGrid.Columns[5].Visibility = Visibility.Collapsed;

        }
    }
}
