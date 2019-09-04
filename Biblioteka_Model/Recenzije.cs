using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model
{
    public class Recenzije
    {
        public int RecenzijaId { get; set; }
        public DateTime DatumObjave { get; set; }
        public string Recenzija { get; set; }
        public int? KorisnikId { get; set; }
        public int? KnjigaId { get; set; }
        public Korisnici Korisnik { get; set; }
    }
}
