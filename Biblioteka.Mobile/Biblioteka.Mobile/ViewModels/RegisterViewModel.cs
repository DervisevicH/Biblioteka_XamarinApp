using Biblioteka.Mobile.Views;
using Biblioteka_Model;
using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Biblioteka.Mobile.ViewModels
{
    public class RegisterViewModel:BaseViewModel
    {
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
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        
       
        public ICommand signUpCommand { get; set; }
       
        private readonly ApiService _service = new ApiService("Korisnici");


        public RegisterViewModel()
        {
            signUpCommand = new Command(async () => await SignUp());
        }

         async Task SignUp()
        {
            if(String.IsNullOrWhiteSpace(Username) || String.IsNullOrWhiteSpace(Password ) || String.IsNullOrWhiteSpace(Ime) || String.IsNullOrWhiteSpace(Prezime) || String.IsNullOrWhiteSpace(Email))
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Za registraciju je potrebno unijeti sva polja", "OK");
            }
            else
            {
                KorisniciInsertRequest korisnik = new KorisniciInsertRequest();
                korisnik.Ime = Ime;
                korisnik.Prezime = Prezime;
                korisnik.KorisnickoIme = Username;
                korisnik.Lozinka = Password;
                korisnik.Email = Email;
                var entity = await _service.Insert<Korisnici>(korisnik);
                if (entity != null)
                {
                    Global.PrijavljeniKorisnik = entity;
                    Global.klijentPrijavljen = true;
                    Application.Current.MainPage = new MainPage();                    
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Greška", "Registracija nije uspjela", "OK");
                    Application.Current.MainPage = new LoginPage();
                }
            }
        }
    }
}
