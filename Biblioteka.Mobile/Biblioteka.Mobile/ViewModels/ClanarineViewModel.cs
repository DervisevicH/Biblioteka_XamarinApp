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
    public class ClanarineViewModel
    {
        private ApiService _clanarineService = new ApiService("Clanarine");
        public ObservableCollection<Clanarine> clanarineList { get; set; } = new ObservableCollection<Clanarine>();

        public ICommand BindCommand { get; set; }
        public ClanarineViewModel()
        {
            BindCommand = new Command(async () => await Bind());
        }

        public async Task Bind()
        {
            ClanarineSearchRequest request = new ClanarineSearchRequest() { ClanId = Global.PrijavljeniKorisnik.KorisnikId, Godina = DateTime.Now};
            var lista = await _clanarineService.Get<List<Biblioteka_Model.Clanarine>>(request);
            foreach (var item in lista)
            {
                clanarineList.Add(item);
            }

        }
    }
}
