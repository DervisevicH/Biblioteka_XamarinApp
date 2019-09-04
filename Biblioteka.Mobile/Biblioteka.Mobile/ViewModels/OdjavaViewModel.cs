using Biblioteka.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Biblioteka.Mobile.ViewModels
{
    public class OdjavaViewModel
    {
        public void Odjava()
        {
            Global.PrijavljeniKorisnik = null;
            Global.aktivnaRezervacije = null;
            Global.klijentPrijavljen = false;
            Application.Current.MainPage = new LoginPage();

        }
    }
}
