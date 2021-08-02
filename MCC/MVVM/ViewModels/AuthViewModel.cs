using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MCC.Commands;

namespace MCC.MVVM.ViewModels
{
    class AuthViewModel : BaseViewModel
    {

        private SignIn signInVM;
        private SignUp signUpVM;



        private object _currentContent;
        public object CurrentContent
        {
            get => _currentContent;
            set
            {
                _currentContent = value;
                OnPropertyChanged();
            }
        }


        public AuthViewModel()
        {
            signInVM = new SignIn();
            signUpVM = new SignUp();
            CurrentContent = signInVM;
        }


        private RelayCommand _signInCommand;
        public RelayCommand SignInCommand
        {
            get => _signInCommand ?? (_signInCommand = new RelayCommand(obj =>
            {
                CurrentContent = signInVM;
            }));
        }


        private RelayCommand _signUpCommand;
        public RelayCommand SignUpCommand
        {
            get => _signUpCommand ?? (_signUpCommand = new RelayCommand(obj =>
            {
                CurrentContent = signUpVM;
            }));
        }

    }
}
