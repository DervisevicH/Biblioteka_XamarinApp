using System;
using System.Collections.Generic;

namespace Biblioteka_WebApi.Database
{
    public partial class Clanarine
    {
        public int ClanarinaId { get; set; }
        public DateTime DatumUplate { get; set; }
        public DateTime DatumIsteka { get; set; }
        public int? KorisnikId { get; set; }
        public decimal Iznos { get; set; }

        public Korisnici Korisnik { get; set; }
    }
}
