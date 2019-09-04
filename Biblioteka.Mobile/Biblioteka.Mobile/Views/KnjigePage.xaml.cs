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
    public partial class KnjigePage : ContentPage
    {
        private KnjigeViewModel model = null;
        public KnjigePage()
        {
            InitializeComponent();
            BindingContext = model = new KnjigeViewModel();
        }
        protected  async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Bind();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Navigation.PushAsync
            var item = e.SelectedItem as Knjige;

            await Navigation.PushAsync(new KnjigaDetailsPage(item));
        }
    }
}