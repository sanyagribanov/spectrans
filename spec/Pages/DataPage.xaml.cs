using spec.Models;
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

namespace spec.Pages
{
    /// <summary>
    /// Логика взаимодействия для DataPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        public DataPage()
        {
            InitializeComponent();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?", "Предупреждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var CurrentUsl = DGridUslugi.SelectedItem as uslugi;
                AppData.db.uslugi.Remove(CurrentUsl);
                AppData.db.SaveChanges();

                DGridUslugi.ItemsSource = AppData.db.uslugi.ToList();
                MessageBox.Show("Данные удалены успешно!");
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditDataPage());
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditDataPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGridUslugi.ItemsSource = AppData.db.uslugi.ToList();
        }
    }
}
