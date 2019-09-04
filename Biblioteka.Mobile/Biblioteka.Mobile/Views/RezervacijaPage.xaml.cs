using Biblioteka.Mobile.ViewModels;
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
    public partial class RezervacijaPage : ContentPage
    {
        private RezervacijaViewModel model = null;
        public RezervacijaPage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
             model.BindCommand.Execute(null);
        }
    }
}