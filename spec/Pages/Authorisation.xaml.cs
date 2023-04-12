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
    /// Логика взаимодействия для Authorisation.xaml
    /// </summary>
    public partial class Authorisation : Page
    {
        public Authorisation()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = Models.AppData.db.Users.FirstOrDefault(u => u.Login == TbxLogin.Text && u.Password == PbxPassword.Password);
            if (CurrentUser != null)
            {
                MessageBox.Show("Вы успешно вошли!", CurrentUser.Roles.Title);
                switch (CurrentUser.RoleID)
                {
                    case 1:
                        NavigationService.Navigate(new Admin());
                        break;
                    case 2:
                        NavigationService.Navigate(new User());
                        break;
                    default:
                        MessageBox.Show("Ошибка", "Данные не обнаружены", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Пользователя нет в БД");
            }
        }
    }
}
