using MarathonMVVM.Model;
using MarathonMVVM.Pages;

namespace MarathonMVVM.ViewModel
{
    internal class ParticipatedViewModel
    {
        private RelayCommand _redirectAutorisation;
        public RelayCommand RedirectAutorisation
        {
            get
            {
                _redirectAutorisation = new RelayCommand(obj =>
                {
                    Navigation.Frame.Navigate(new AutorisationPage());
                });
                return _redirectAutorisation;
            }
        }
    }
}