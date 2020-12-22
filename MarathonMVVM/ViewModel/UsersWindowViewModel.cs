using MarathonMVVM.Model;

namespace MarathonMVVM.ViewModel
{
    internal class UsersWindowViewModel
    {
        private RelayCommand _backButton;
        public RelayCommand BackButton
        {
            get
            {
                _backButton = new RelayCommand(obj =>
                {
                    Navigation.Frame.GoBack();
                },
                (obj) => Navigation.Frame.CanGoBack);
                return _backButton;
            }
        }

    }
}