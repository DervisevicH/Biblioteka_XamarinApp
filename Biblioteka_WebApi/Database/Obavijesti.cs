using System;
using System.Collections.Generic;

namespace Biblioteka_WebApi.Database
{
    public partial class Obavijesti
    {
        public int ObavijestId { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumObjave { get; set; }
        public string Sadrzaj { get; set; }
        public int? KorisnikId { get; set; }

        public Korisnici Korisnik { get; set; }
    }
}
