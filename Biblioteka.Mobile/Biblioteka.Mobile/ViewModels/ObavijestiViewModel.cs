using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Biblioteka.Mobile.ViewModels
{
    public class ObavijestiViewModel
    {
        private readonly ApiService _obavijestiService = new ApiService("Obavijesti");
        public ObservableCollection<Biblioteka_Model.Obavijesti> obavijestiLista { get; set; } = new ObservableCollection<Biblioteka_Model.Obavijesti>();

        public ObavijestiViewModel()
        {
            Bind();

        }

        public async void Bind()
        {
            obavijestiLista.Clear();
            var list = await _obavijestiService.Get<IEnumerable<Biblioteka_Model.Obavijesti>>(null);

            foreach (var obavijest in list)
            {
                obavijestiLista.Add(obavijest);
            }
        }
    }
}
