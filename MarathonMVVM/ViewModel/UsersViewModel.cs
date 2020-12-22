using MarathonMVVM.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.CompilerServices;

namespace MarathonMVVM.ViewModel
{
    internal class UsersViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<User> _users;
        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged("Users");
            }
        }

        private ObservableCollection<User> LoadUsers()
        {
            using (MarathonEntities context = new MarathonEntities())
            {
                context.User.Load();
                context.Role.Load();
                return context.User.Local;
            }
        }

        public UsersViewModel()
        {
            _users = LoadUsers();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}