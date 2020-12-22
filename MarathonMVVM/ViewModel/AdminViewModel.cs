using MarathonMVVM.Model;
using MarathonMVVM.Pages.AdminPages;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace MarathonMVVM.ViewModel
{
    internal class AdminViewModel : INotifyPropertyChanged
    {
        private RelayCommand _redirectButton;
        public RelayCommand RedirectButton
        {
            get
            {
                _redirectButton = new RelayCommand(obj =>
                {
                    string pageName = obj.ToString();
                    Redirect(pageName);
                });
                return _redirectButton;
            }
        }

        private void Redirect(string pageName)
        {
            switch (pageName)
            {
                case "Пользователи":
                    Navigation.Frame.Navigate(new UsersPage());
                    break;
                case "Волонтеры":
                    Navigation.Frame.Navigate(new VolunteersPage());
                    break;
                case "Благотворительные организации":
                    Navigation.Frame.Navigate(new CharitiesPage());
                    break;
                case "Инвентарь":
                    Navigation.Frame.Navigate(new InventoryPage());
                    break;
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}