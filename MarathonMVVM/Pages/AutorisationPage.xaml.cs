using MarathonMVVM.ViewModel;
using System.Windows.Controls;

namespace MarathonMVVM.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorisationPage.xaml
    /// </summary>
    public partial class AutorisationPage : Page
    {
        public AutorisationPage()
        {
            InitializeComponent();

            DataContext = new AutorisationViewModel();
        }
    }
}