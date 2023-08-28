using _49.Models;
using _49.ViewModels;

using System.Windows;

namespace _49
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel _viewModel;

        public MainWindow()
        {
            _viewModel = new MainWindowViewModel
            {
                LoginModel = new LoginModel()
            };

            this.DataContext = _viewModel;

            InitializeComponent();
        }

        //public void loginClick(object sender, RoutedEventArgs e)
        //{
        //    string username = txtUsername.Text;
        //    string password = txtPassword.Password;

        //    if (username != "admin" || password != "1234")
        //    {
        //        MessageBox.Show("Username or password is incorrect");
        //        return;
        //    }

        //    MessageBox.Show("Logged in");
        //}

        //private void txtPassword_PreviewKeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Enter)
        //    {
        //        this.loginClick(sender, null);
        //    }
        //}

        //private void btnLogin_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    txtUsername.Clear();
        //}
    }
}
