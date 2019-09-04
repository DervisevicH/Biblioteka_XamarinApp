using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_WinForms
{
    public partial class LoginForm : Form
    {
        private readonly ApiService _service = new ApiService("Autori");
        private readonly ApiService _korisniciService = new ApiService("Korisnici");
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void BtnPrijava_Click(object sender, EventArgs e)
        {
            ApiService.Username = txtKorisnickoIme.Text;
            ApiService.Password = txtLozinka.Text;
            try
            {
                var obj = await _service.Get<dynamic>(null);
                if (obj != null)
                {
                    List<Biblioteka_Model.Korisnici> entity = await _korisniciService.Get<List<Biblioteka_Model.Korisnici>>(null);
                    int id = 0;
                    foreach (var item in entity)
                    {
                        if (item.KorisnickoIme == txtKorisnickoIme.Text.Trim())
                            id = item.KorisnikId;

                    }
                    if (id != 0)
                    {
                        
                        Biblioteka_Model.Korisnici korisnik = await _korisniciService.GetById<Biblioteka_Model.Korisnici>(id);
                        Global.PrijavljeniKorisnik = korisnik;
                        Global.klijentPrijavljen = true;
                        MainForm frm = new MainForm();
                        frm.Show();
                    }
                } 
            }
            catch (Exception ex)
            {

            }

        }
    }
}
