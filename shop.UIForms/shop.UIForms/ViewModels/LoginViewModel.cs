

using System.Windows.Input;

namespace Shop.UIForms.ViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel Login { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand { get; }

    }
}
