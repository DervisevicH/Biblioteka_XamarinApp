using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model
{
    public class Clanarine
    {
        public int ClanarinaId { get; set; }
        public DateTime DatumUplate { get; set; }
        public DateTime DatumIsteka { get; set; }
        public int? KorisnikId { get; set; }
        public decimal Iznos { get; set; }
        public string ImePrezime{ get; set; }

        public Korisnici Korisnik { get; set; }
    }
}
