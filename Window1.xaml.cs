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

        BookTableAdapter books = new BookTableAdapter();
        ReaderTableAdapter reader = new ReaderTableAdapter();
        public Window1()
        {
            InitializeComponent();
            YetAnotherGrid.ItemsSource = books.GetData();
            combobox.ItemsSource = reader.GetData();
            combobox.DisplayMemberPath = "Last_Name";
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            YetAnotherGrid.ItemsSource = books.SearchData(textbox.Text);
        }
        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            if(combobox.SelectedItem != null)
            {
                var id = (int)(combobox.SelectedItem as DataRowView).Row[0];
                YetAnotherGrid.ItemsSource = books.FilterData(id);
            }
        }
    }
}
