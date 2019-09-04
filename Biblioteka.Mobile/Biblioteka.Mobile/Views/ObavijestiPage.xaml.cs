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
    public partial class ObavijestiPage : ContentPage
    {
        private ObavijestiViewModel model = null;
        public ObavijestiPage()
        {
            InitializeComponent();
            this.BindingContext = model = new ObavijestiViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            model.Bind();
        }
    }
}