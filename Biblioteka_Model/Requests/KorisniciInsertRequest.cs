using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model.Requests
{
    public class KorisniciInsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string Lozinka { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
    }
}
