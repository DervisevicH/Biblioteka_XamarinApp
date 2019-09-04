using System;
using System.Collections.Generic;

namespace Biblioteka_WebApi.Database
{
    public partial class Recenzije
    {
        public int RecenzijaId { get; set; }
        public DateTime DatumObjave { get; set; }
        public string Recenzija { get; set; }
        public int? KorisnikId { get; set; }
        public int? KnjigaId { get; set; }

        public Knjige Knjiga { get; set; }
        public Korisnici Korisnik { get; set; }
    }
}
