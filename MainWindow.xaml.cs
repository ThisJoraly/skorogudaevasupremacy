using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            combobox.ItemsSource = context.Book.ToList();
            combobox.DisplayMemberPath = "Book_Name";

        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            YetAnotherGrid.ItemsSource = context.Reader.ToList().Where(text => text.Last_Name.Contains(textbox.Text) ||
            text.First_Name.Contains(textbox.Text) || text.Middle_Name.Contains(textbox.Text));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
        }


        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            if (combobox.SelectedItem != null)
            {
                var selected = combobox.SelectedItem as Reader;
                YetAnotherGrid.ItemsSource = context.Book.ToList().Where(item => item.ID_Book == selected.Book_ID);
            }
        }
    }
}
