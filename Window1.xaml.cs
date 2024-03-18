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
            YetAnotherGrid.ItemsSource = reader.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // добавление
        {
            var lastName = F.Text;
            var firstName = I.Text;
            var middlename = O.Text;
            var id = Convert.ToInt32(ID.Text);
            reader.AddReader(lastName, firstName, middlename, id);
            YetAnotherGrid.ItemsSource = reader.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // удаление
        {
            int id = (int)(YetAnotherGrid.SelectedItem as DataRowView).Row[0];
            reader.DeleteQuery(id);
            YetAnotherGrid.ItemsSource = reader.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // изменение
        {
            int id = (int) (YetAnotherGrid.SelectedItem as DataRowView).Row[0];
            reader.UpdateQuery(F.Text, I.Text, O.Text, Convert.ToInt32(ID.Text), id);
            YetAnotherGrid.ItemsSource = reader.GetData();
        }
    }
}
