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
    public partial class OdjavaPage : ContentPage
    {
        private OdjavaViewModel model = null;

        public OdjavaPage()
        {
            InitializeComponent();
            this.BindingContext = model = new OdjavaViewModel();
            model.Odjava();
        }
        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    model.Odjava();
        //}
    }
}