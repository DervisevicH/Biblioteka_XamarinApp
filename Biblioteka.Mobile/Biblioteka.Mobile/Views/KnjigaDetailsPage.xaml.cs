using Biblioteka.Mobile.ViewModels;
using Biblioteka_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biblioteka.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KnjigaDetailsPage : ContentPage
    {
        private KnjigaDetailViewModel model = null; 
        public KnjigaDetailsPage(Knjige knjiga)
        {
            InitializeComponent();
            this.BindingContext = model = new KnjigaDetailViewModel()
            {
                Knjiga = knjiga
            };

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
             model.Bind();
            model.Preporuci(model.Knjiga.KnjigaId);
        }


    }
}