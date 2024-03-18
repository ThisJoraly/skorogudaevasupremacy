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
            YetAnotherGrid.ItemsSource = context.Book.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // окно 2 (DataSet)
        {
            new Window1().Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // добавление
        {
            Book buch = new Book();
            buch.Book_Name = Name.Text;
            buch.Book_Author = Author.Text;
            buch.Book_Year = Convert.ToInt32(Year.Text);

            context.Book.Add(buch);
            context.SaveChanges();
            YetAnotherGrid.ItemsSource = context.Book.ToList(); 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // удаление
        {
            if (YetAnotherGrid.ItemsSource != null)
            {
                context.Book.Remove(YetAnotherGrid.SelectedItem as Book);
                context.SaveChanges();
                YetAnotherGrid.ItemsSource = context.Book.ToList();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // изменение
        {
            context.SaveChanges();
        }
    }
}
