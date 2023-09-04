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

        //storing login data 
        public LoginModel LoginModel { get; set; }

        //the action that execute login operation
        public ICommand LoginCommand { get; set; }
    }
}
