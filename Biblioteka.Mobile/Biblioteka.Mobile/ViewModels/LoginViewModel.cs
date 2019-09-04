using Biblioteka.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Biblioteka.Mobile.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        private readonly ApiService _service = new ApiService("Korisnici");
        private readonly ApiService _autoriService = new ApiService("Autori");
        public ICommand LoginCommand { get; set; }
        public ICommand SignUpCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async() =>await Login());
            SignUpCommand = new Command(async () => await Register());
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        async Task Login()
        {
            IsBusy = true;
            if (String.IsNullOrEmpty(Username))
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Niste unijeli korisničko ime", "OK");

            }
            else if (String.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Niste unijeli lozinku", "OK");

            }
            else
            {
                ApiService.Username = Username;
                ApiService.Password = Password;


                try
                {
                    var obj = await _autoriService.Get<dynamic>(null);
                    if (obj != null)
                    {
                        List<Biblioteka_Model.Korisnici> entity = await _service.Get<List<Biblioteka_Model.Korisnici>>(null);
                        int id = 0;
                        foreach (var item in entity)
                        {
                            if (item.KorisnickoIme == Username)
                                id = item.KorisnikId;

                        }
                        if (id != 0)
                        {
                            Biblioteka_Model.Korisnici korisnik = await _service.GetById<Biblioteka_Model.Korisnici>(id);
                            Global.PrijavljeniKorisnik = korisnik;
                            Global.klijentPrijavljen = true;
                            Application.Current.MainPage = new MainPage();
                        }
                    }

                }
                catch (Exception ex)
                {

                await App.Current.MainPage.DisplayAlert("Greška", "Prijava nije uspjela", "OK");

                }
            }
           
            
        }
        async Task Register()
        {
             Application.Current.MainPage =  new RegisterPage();
        }

    }
}
