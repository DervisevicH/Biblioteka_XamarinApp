using Biblioteka.Mobile.Views;
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
    public class RezervacijaViewModel
    {
        private readonly ApiService _service = new ApiService("Rezervacije");

        public ObservableCollection<Knjige> knjigeList { get; set; } = new ObservableCollection<Knjige>();
        public ICommand BindCommand { get; set; }
        public ICommand RezervisiCommand { get; set; }

        public RezervacijaViewModel()
        {
            BindCommand= new Command(Bind);
            RezervisiCommand = new Command(async () => await Rezervisi());
        }

        private async Task Rezervisi()
        {
            var entity = await _service.Insert<RezervacijeInsertRequest>(Global.aktivnaRezervacije);
            if (entity != null)
            {
                await App.Current.MainPage.DisplayAlert("Info", "Uspješno ste rezervisali knjige", "OK");
                Global.aktivnaRezervacije = null;
                Application.Current.MainPage = new MainPage();

            }
        }

        public void Bind() {
            if (Global.aktivnaRezervacije==null)
            {
                knjigeList.Clear();    
                 App.Current.MainPage.DisplayAlert("Greška", "Niste rezervisali knjige", "OK");
                Application.Current.MainPage = new MainPage();

            }
            else
            {
                knjigeList.Clear();
                var list = Global.aktivnaRezervacije.Knjige;
                foreach (var knjiga in list)
                {
                    knjigeList.Add(knjiga);
                }
            }
           
        }
    }
}
