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
    /// Логика взаимодействия для EditDataPage.xaml
    /// </summary>
    public partial class EditDataPage : Page
    {
        public EditDataPage()
        {
            InitializeComponent();
            //заполняем комбарь
            CmbTitle.ItemsSource = AppData.db.uslugi.ToList();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uslugi usl = new uslugi();
                int a = Int32.Parse(Price.Text);
                int b = Int32.Parse(IdTbx.Text);
                usl.ID =b;
                usl.price = a;
                usl.code = CodeUsluga.Text;
                //данные из комбаря
                var CurrentUsluga = CmbTitle.SelectedItem as uslugi;
                usl.title = CurrentUsluga.title;
            
                AppData.db.uslugi.Add(usl);
                AppData.db.SaveChanges();
                MessageBox.Show("Данные внесены успешно");
                NavigationService.GoBack();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
