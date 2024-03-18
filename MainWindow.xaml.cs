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

namespace zhopaSArfoi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TownLibraryEntities context = new TownLibraryEntities();

        public MainWindow()
        {
            InitializeComponent();
            YetAnotherGrid.ItemsSource = context.Reader.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
        }
    }
}
