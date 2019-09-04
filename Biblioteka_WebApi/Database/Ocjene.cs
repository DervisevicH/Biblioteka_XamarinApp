using System;
using System.Collections.Generic;

namespace Biblioteka_WebApi.Database
{
    public partial class Ocjene
    {
        public int OcjenaId { get; set; }
        public int? KorisnikId { get; set; }
        public int? KnjigaId { get; set; }
        public int Ocjena { get; set; }

        public Knjige Knjiga { get; set; }
        public Korisnici Korisnik { get; set; }
    }
}
