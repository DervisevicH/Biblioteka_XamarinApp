using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model
{
   public class Rezervacije
    {
        public int RezervacijaId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime? DatumPreuzimanja { get; set; }
        public DateTime? DatumVracanja { get; set; }
        public bool? Zavrsena { get; set; }
        public int? BrojKnjiga { get; set; }
        public int? KorisnikId { get; set; }      
        public string ImePrezimeClana { get; set; }
        public string listaKnjiga { get; set; }
        public List<int> listaRezervacija { get; set; } = new List<int>();
        public List<Knjige> Knjige { get; set; } = new List<Knjige>();

    }
}
