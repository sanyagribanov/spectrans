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
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : Page
    {
        public User()
        {
            InitializeComponent();

            mbu_spectransEntities data = new mbu_spectransEntities();
            //отображение имени пользователя
            UserTB_1.Text = data.Users.FirstOrDefault().Login;
            RoleTB_1.Text = "(" + data.Roles.FirstOrDefault().Title + ")";
        }
    }
}
