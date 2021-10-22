using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string _userName;
        private string _password;
        private Command _loginCommand;
        private Command _closeAlertCommand;
        private bool isErrorLogin;

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {

        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => _password;
            set
            {

                _password = value;
                OnPropertyChanged();
            }
        }

        public Command LoginCommand
        {
            get => _loginCommand ?? (_loginCommand = new Command(GoToLoginAction));
        }

        public Command CloseAlertCommand
        {
            get => _closeAlertCommand ?? (_closeAlertCommand = new Command(() => IsErrorLogin = false));
        }

        public bool IsErrorLogin
        {
            get => isErrorLogin;
            set
            {
                isErrorLogin = value;

                OnPropertyChanged();
            }
        }


        private void GoToLoginAction()
        {
            IsErrorLogin = !(string.Equals(UserName, "holi") && string.Equals(Password, "Nada"));

            if (!IsErrorLogin)
            {
                UserName = String.Empty;
                Password = String.Empty;
                Navigation.PushAsync(new PaginaInicio());
            }
        }
    }
}
