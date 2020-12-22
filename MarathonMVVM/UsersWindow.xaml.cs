using MarathonMVVM.ViewModel;
using System.Windows;

namespace MarathonMVVM
{
    /// <summary>
    /// Логика взаимодействия для UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        public UsersWindow()
        {
            InitializeComponent();

            Navigation.Frame = this.MainFrame;
            DataContext = new UsersWindowViewModel();
        }
    }
}