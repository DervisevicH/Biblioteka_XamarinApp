using System;
using System.Collections.Generic;

namespace Biblioteka_WebApi.Database
{
    public partial class Rezervacije
    {
        public Rezervacije()
        {
            RezervacijeKnjige = new HashSet<RezervacijeKnjige>();
        }

        public int RezervacijaId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime? DatumPreuzimanja { get; set; }
        public DateTime? DatumVracanja { get; set; }
        public bool? Zavrsena { get; set; }
        public int? BrojKnjiga { get; set; }
        public int? KorisnikId { get; set; }

        public Korisnici Korisnik { get; set; }
        public ICollection<RezervacijeKnjige> RezervacijeKnjige { get; set; }
    }
}
