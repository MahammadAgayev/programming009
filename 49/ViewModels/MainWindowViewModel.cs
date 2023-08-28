using _49.Commands;
using _49.Models;

using System.Windows.Input;

namespace _49.ViewModels
{

    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            this.LoginCommand = new LoginCommand(this);
        }

        public LoginModel LoginModel { get; set; }

        public ICommand LoginCommand { get; set; }
    }
}
