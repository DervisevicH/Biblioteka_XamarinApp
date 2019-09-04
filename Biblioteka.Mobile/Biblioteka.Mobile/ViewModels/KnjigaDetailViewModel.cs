using Biblioteka_Model;
using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Biblioteka.Mobile.ViewModels
{
    public class KnjigaDetailViewModel: BaseViewModel
    {
        private ApiService _recenzijeService = new ApiService("Recenzije");
        private ApiService _ocjeneService = new ApiService("Ocjene");
        private ApiService _knjigeService = new ApiService("Knjige");
        public Knjige Knjiga { get; set; }
        public ICommand rezervisiCommand{ get; set; }
        public ICommand jedanCommand{ get; set; }
        public ICommand dvaCommand{ get; set; }
        public ICommand triCommand{ get; set; }
        public ICommand cetiriCommand{ get; set; }
        public ICommand petCommand{ get; set; }
        public ICommand dodajKomentarCommand { get; set; }
        public ObservableCollection<Recenzije> recenzijeLista { get; set; } = new ObservableCollection<Recenzije>();
        public ObservableCollection<Biblioteka_Model.Knjige> preporukaLista { get; set; } = new ObservableCollection<Biblioteka_Model.Knjige>();

        string _recenzija = string.Empty;
        public string Recenzija
        {
            get { return _recenzija; }
            set { SetProperty(ref _recenzija, value); }
        }

        public KnjigaDetailViewModel()
        {
            rezervisiCommand = new Command(Rezervisi);
            dodajKomentarCommand = new Command(async () => await Dodaj());
            jedanCommand = new Command(async () => await ocijeniJedan());
            dvaCommand = new Command(async () => await ocijeniDva());
            triCommand = new Command(async () => await ocijeniTri());
            cetiriCommand = new Command(async () => await ocijeniCetiri());
            petCommand = new Command(async () => await ocijeniPet());

        }

        private async Task ocijeniPet()
        {
            OcjeneInsertRequest request = new OcjeneInsertRequest() { KnjigaId = Knjiga.KnjigaId, KorisnikId = Global.PrijavljeniKorisnik.KorisnikId, Ocjena = 5 };
            var entity = await _ocjeneService.Insert<Biblioteka_Model.Ocjene>(request);
            if (entity != null)
            {
                await App.Current.MainPage.DisplayAlert("Info", "Uspješno ste ocijenili knjigu", "OK");

            }
           
        }

        private async Task ocijeniCetiri()
        {
            OcjeneInsertRequest request = new OcjeneInsertRequest() { KnjigaId = Knjiga.KnjigaId, KorisnikId = Global.PrijavljeniKorisnik.KorisnikId, Ocjena = 4 };
            var entity = await _ocjeneService.Insert<Biblioteka_Model.Ocjene>(request);
            if (entity != null)
            {
                await App.Current.MainPage.DisplayAlert("Info", "Uspješno ste ocijenili knjigu", "OK");

            }
        }

        private async Task ocijeniTri()
        {
            OcjeneInsertRequest request = new OcjeneInsertRequest() { KnjigaId = Knjiga.KnjigaId, KorisnikId = Global.PrijavljeniKorisnik.KorisnikId, Ocjena = 3 };
            var entity = await _ocjeneService.Insert<Biblioteka_Model.Ocjene>(request);
            if (entity != null)
            {
                await App.Current.MainPage.DisplayAlert("Info", "Uspješno ste ocijenili knjigu", "OK");

            }
        }

        private async Task ocijeniDva()
        {
            OcjeneInsertRequest request = new OcjeneInsertRequest() { KnjigaId = Knjiga.KnjigaId, KorisnikId = Global.PrijavljeniKorisnik.KorisnikId, Ocjena = 2 };
            var entity = await _ocjeneService.Insert<Biblioteka_Model.Ocjene>(request);
            if (entity != null)
            {
                await App.Current.MainPage.DisplayAlert("Info", "Uspješno ste ocijenili knjigu", "OK");

            }
        }

        private async Task ocijeniJedan()
        {
            OcjeneInsertRequest request = new OcjeneInsertRequest() { KnjigaId = Knjiga.KnjigaId, KorisnikId = Global.PrijavljeniKorisnik.KorisnikId, Ocjena = 1 };
            var entity = await _ocjeneService.Insert<Biblioteka_Model.Ocjene>(request);
            if (entity != null)
            {
                await App.Current.MainPage.DisplayAlert("Info", "Uspješno ste ocijenili knjigu", "OK");

            }

        }

        private async Task Dodaj()
        {
            RecenzijeInsertRequest request = new RecenzijeInsertRequest();
            request.DatumObjave = System.DateTime.Now;
            request.KnjigaId = Knjiga.KnjigaId;
            request.KorisnikId = Global.PrijavljeniKorisnik.KorisnikId;
            request.Recenzija = Recenzija;

            var entity = await _recenzijeService.Insert<Biblioteka_Model.Recenzije>(request);
            if (entity != null)
            {
                await App.Current.MainPage.DisplayAlert("Info", "Uspješno ste dodali recenziju", "OK");

            }


        }

        private void Rezervisi()
        {
            if (Global.aktivnaRezervacije == null)
            {
                Global.aktivnaRezervacije = new Biblioteka_Model.Requests.RezervacijeInsertRequest();
                Global.aktivnaRezervacije.KorisnikId = Global.PrijavljeniKorisnik.KorisnikId;
                Global.aktivnaRezervacije.DatumRezervacije = DateTime.Now;
                Global.aktivnaRezervacije.Zavrsena = false;
            }
            if (Global.aktivnaRezervacije.Knjige != null)
            {
                bool postoji = false;
                foreach (var item in Global.aktivnaRezervacije.Knjige)
                {
                    if (Knjiga.KnjigaId == item.KnjigaId)
                    {
                        postoji = true;
                        break;
                    }
                }
                if (postoji)
                    App.Current.MainPage.DisplayAlert("Greška", "Odabrana knjiga je već rezervisana", "OK");
                else
                {
                    int id = Knjiga.KnjigaId;

                    Global.aktivnaRezervacije.Knjige.Add(Knjiga);
                    App.Current.MainPage.DisplayAlert("Info", "Knjiga je dodata u rezervaciju", "OK");

                }
            }
            else
            {
                int id = Knjiga.KnjigaId;
                Global.aktivnaRezervacije.Knjige.Add(Knjiga);

               
                App.Current.MainPage.DisplayAlert("Info", "Knjiga je dodata u rezervaciju", "OK");
            }


        }
        public void Bind() {
            foreach (var item in Knjiga.Recenzije)
            {
                recenzijeLista.Add(item);
            }
        }


        public async void Preporuci(int id) {
            var list = await _knjigeService.GetPreporucenoById<IEnumerable<Biblioteka_Model.Knjige>>(id);
            preporukaLista.Clear();

            foreach (var knjiga in list)
            {
                preporukaLista.Add(knjiga);
            }
        }


    }
}
