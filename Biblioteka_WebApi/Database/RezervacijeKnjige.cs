using System;
using System.Collections.Generic;

namespace Biblioteka_WebApi.Database
{
    public partial class RezervacijeKnjige
    {
        public int RezervacijaKnjigaId { get; set; }
        public int? KnjigaId { get; set; }
        public int? RezervacijaId { get; set; }

        public Knjige Knjiga { get; set; }
        public Rezervacije Rezervacija { get; set; }
    }
}
