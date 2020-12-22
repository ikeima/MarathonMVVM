using MarathonMVVM.Model;
using MarathonMVVM.Pages.AdminPages;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MarathonMVVM.ViewModel
{
    internal class AutorisationViewModel : INotifyPropertyChanged
    {
        private string _login;
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }


        private RelayCommand _autorisation;
        public RelayCommand Autorisation
        {
            get
            {
                _autorisation = new RelayCommand(obj =>
                {
                    AutorisationMethod();
                });
                return _autorisation;
            }
        }

        private bool AutorisationMethod()
        {
            using (MarathonEntities context = new MarathonEntities())
            {
                context.User.Load();

                User user = context.User
                    .Where(u => u.Email == _login && u.Password == _password)
                    .FirstOrDefault();

                if (user != null)
                {
                    Redirection(user);
                    return true;
                }
                else return false;
            }
        }

        private void Redirection(User user)
        {
            switch (user.RoleId)
            {
                case "A":
                    Navigation.Frame.Navigate(new AdminPage());
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