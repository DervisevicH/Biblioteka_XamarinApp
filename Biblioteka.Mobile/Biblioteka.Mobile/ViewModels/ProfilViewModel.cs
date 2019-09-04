using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Biblioteka.Mobile.ViewModels
{
    public class ProfilViewModel : BaseViewModel
    {
        private ApiService _korisniciService = new ApiService("Korisnici");
        public ICommand sacuvajCommand { get; set; }
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
        string _adresa = string.Empty;
        public string Adresa
        {
            get { return _adresa; }
            set { SetProperty(ref _adresa, value); }
        }
        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }
        public ProfilViewModel()
        {
            Bind();
            sacuvajCommand = new Command(async () => await Sacuvaj());
        }

        private async Task Sacuvaj()
        {
            if (String.IsNullOrWhiteSpace(Username) || String.IsNullOrWhiteSpace(Ime) || String.IsNullOrWhiteSpace(Prezime) || String.IsNullOrWhiteSpace(Email))
            {
                await App.Current.MainPage.DisplayAlert("Greška", "Potrebno je unijeti obavezna polja", "OK");               
            }
            else
            {
                KorisniciUpdateRequest request = new KorisniciUpdateRequest();
                request.KorisnikId = Global.PrijavljeniKorisnik.KorisnikId;
                request.Ime = Ime;
                request.Prezime = Prezime;
                request.KorisnickoIme = Username;
                request.Lozinka = Password;
                request.Email = Email;
                request.Telefon = Telefon;
                request.Adresa = Adresa;

                var entity = await _korisniciService.Update<Biblioteka_Model.Korisnici>(request.KorisnikId, request);
                if (entity != null)
                {
                    await App.Current.MainPage.DisplayAlert("Info", "Uspješno ste sačuvali podatke", "OK");

                }
            }


        }

        public void Bind()
        {
            Biblioteka_Model.Korisnici korisnik = Global.PrijavljeniKorisnik;
            Ime = korisnik.Ime;
            Prezime = korisnik.Prezime;
            Username = korisnik.KorisnickoIme;
            Email = korisnik.Email;
            Adresa = korisnik.Adresa;
            Telefon = korisnik.Telefon;
        }
    }
}
