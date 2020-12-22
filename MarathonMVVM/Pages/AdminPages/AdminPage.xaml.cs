using MarathonMVVM.ViewModel;
using System.Windows.Controls;

namespace MarathonMVVM.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();

            DataContext = new AdminViewModel();
        }
    }
}