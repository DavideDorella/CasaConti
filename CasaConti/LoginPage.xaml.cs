using CarListApp.Maui.ViewModels;

namespace CarListApp.Maui;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel loginViewModel)
    {
        InitializeComponent();
        BindingContext = loginViewModel;

        loginViewModel.Username = "admin@localhost.com";
        loginViewModel.Password = "P@ssword1";
    }
}