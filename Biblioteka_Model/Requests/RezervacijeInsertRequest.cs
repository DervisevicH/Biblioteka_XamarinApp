using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model.Requests
{
    public class RezervacijeInsertRequest
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
        public List<Knjige> Knjige { get; set; } = new List<Knjige>();
    }
}
