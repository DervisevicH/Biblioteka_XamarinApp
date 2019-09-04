using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model
{
    public class Korisnici
    {
        public int KorisnikId{ get; set; }
        public string ImePrezime{ get; set; }
        public string Ime{ get; set; }
        public string Prezime{ get; set; }
        public string KorisnickoIme{ get; set; }
        public string LozinkaHash{ get; set; }
        public string LozinkaSalt{ get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public Uloge Uloga { get; set; }
    }
}
