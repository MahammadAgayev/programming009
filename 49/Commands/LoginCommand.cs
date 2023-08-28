using _49.ViewModels;

using System;
using System.Windows;
using System.Windows.Input;

namespace _49.Commands
{
    public class LoginCommand : ICommand
    {
        private readonly MainWindowViewModel _mainViewModel;

        public LoginCommand(MainWindowViewModel viewModel)
        {
            _mainViewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (_mainViewModel.LoginModel.Username == "admin" && _mainViewModel.LoginModel.Password == "1234")
            {
                MessageBox.Show("Logged in");
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }
    }


}
