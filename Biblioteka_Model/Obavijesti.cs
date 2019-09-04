using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model
{
    public class Obavijesti
    {
        public int ObavijestId { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumObjave { get; set; }
        public string Sadrzaj { get; set; }
        public int? KorisnikId { get; set; }

    }
}
