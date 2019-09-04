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
    public class KnjigeViewModel : BaseViewModel
    {
        private readonly ApiService _knjigeService = new ApiService("Knjige");
        private readonly ApiService _zanroviService = new ApiService("Zanrovi");
        public ICommand BindCommand { get; set; }
        public ICommand PretragaCommand { get; set; }
        public KnjigeViewModel()
        {
            BindCommand = new Command(async () => await Bind());
            PretragaCommand = new Command(async () => await Pretraga());

        }

        private async Task Pretraga()
        {
            if ( _selectedZanr == null && String.IsNullOrEmpty(NazivKnjige))
            {
                var list = await _knjigeService.Get<IEnumerable<Knjige>>(null);
                knjigeList.Clear();
                foreach (var item in list)
                {
                    knjigeList.Add(item);
                }

            }
            else
            {
                KnjigeSearchRequest request = new KnjigeSearchRequest();
                request.ZanrId = _selectedZanr.ZanrId;
                request.Naziv = NazivKnjige;

                var lista = await _knjigeService.Get<IEnumerable<Knjige>>(request);
                knjigeList.Clear();
                foreach (var item in lista)
                {
                    knjigeList.Add(item);
                }
            }

        }

        string _nazivKnjige = string.Empty;
        public string NazivKnjige
        {
            get { return _nazivKnjige; }
            set { SetProperty(ref _nazivKnjige, value); }
        }

        public ObservableCollection<Knjige> knjigeList { get; set; } = new ObservableCollection<Knjige>();
        public ObservableCollection<Zanrovi> zanroviList { get; set; } = new ObservableCollection<Zanrovi>();
     
        Zanrovi _selectedZanr = null;
        public Zanrovi SelectedZanr { get { return _selectedZanr; } set { SetProperty(ref _selectedZanr, value); } }

        public async Task Bind()
        {
            if (zanroviList.Count == 0)
            {
                var zanrovi = await _zanroviService.Get<List<Zanrovi>>(null);
                zanroviList.Insert(0, new Zanrovi { Naziv = "Odaberite..." });
                foreach (var zanr in zanrovi)
                {
                    zanroviList.Add(zanr);
                }
            }
            knjigeList.Clear();
            var list = await _knjigeService.Get<IEnumerable<Knjige>>(null);

            foreach (var knjiga in list)
            {
                knjigeList.Add(knjiga);
            }
        }
    }
}
