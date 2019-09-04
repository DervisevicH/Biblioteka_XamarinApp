using System;
using System.Collections.Generic;

namespace Biblioteka_WebApi.Database
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            Clanarine = new HashSet<Clanarine>();
            Obavijesti = new HashSet<Obavijesti>();
            Ocjene = new HashSet<Ocjene>();
            Recenzije = new HashSet<Recenzije>();
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public int? UlogaId { get; set; }

        public Uloge Uloga { get; set; }
        public ICollection<Clanarine> Clanarine { get; set; }
        public ICollection<Obavijesti> Obavijesti { get; set; }
        public ICollection<Ocjene> Ocjene { get; set; }
        public ICollection<Recenzije> Recenzije { get; set; }
        public ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
