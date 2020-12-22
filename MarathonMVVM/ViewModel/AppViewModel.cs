using MarathonMVVM.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MarathonMVVM.ViewModel
{
    internal class AppViewModel : INotifyPropertyChanged
    {
        private RelayCommand _openUserWindow;
        public RelayCommand OpenUserWindow
        {
            get
            {
                _openUserWindow = new RelayCommand(obj =>
                {
                    UsersWindow window = new UsersWindow();
                    window.ShowDialog();
                });
                return _openUserWindow;
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}