using CarListApp.Maui.Helpers;
using CarListApp.Maui.Models;
using CarListApp.Maui.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp.Maui.ViewModels
{
    public partial class PreferenzeViewModel : BaseViewModel
    {

        [ObservableProperty]
        string contopref;


        public PreferenzeViewModel()
        {
            Preferenze();
        }

        [RelayCommand]        
        public void SavePreferenze()
        {
            Preferences.Set("ContoPref", contopref);
        }

        void Preferenze()
        {
            //SecureStorage.Remove("Token");
            //App.UserInfo = null;
            //await Shell.Current.GoToAsync($"{nameof(LoginPage)}");
            contopref = Preferences.Get("ContoPref", contopref);
            if(contopref==null)
                contopref= "";
        }
      
    }
}
