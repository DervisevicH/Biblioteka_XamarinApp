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
    public partial class ClanarinePage : ContentPage
    {
        private ClanarineViewModel model = null;

        public ClanarinePage()
        {
            InitializeComponent();
            BindingContext = model = new ClanarineViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            model.BindCommand.Execute(null);
        }
    }
}