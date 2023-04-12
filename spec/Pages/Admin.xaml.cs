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
using spec.Models;
namespace spec.Pages
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();

            mbu_spectransEntities data = new mbu_spectransEntities();
            //отображение имени пользователя
            UserTB_2.Text = data.Users.FirstOrDefault().Login;
            RoleTB_2.Text = "(" + data.Roles.FirstOrDefault().Title + ")";
        }
    }
}
