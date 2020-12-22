using MarathonMVVM.ViewModel;
using System.Windows.Controls;

namespace MarathonMVVM.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();

            DataContext = new UsersViewModel();
        }
    }
}