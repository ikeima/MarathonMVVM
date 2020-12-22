using MarathonMVVM.ViewModel;
using System.Windows.Controls;

namespace MarathonMVVM.Pages.RunnerPages
{
    /// <summary>
    /// Логика взаимодействия для IsParticipatedPage.xaml
    /// </summary>
    public partial class IsParticipatedPage : Page
    {
        public IsParticipatedPage()
        {
            InitializeComponent();

            DataContext = new ParticipatedViewModel();
        }
    }
}