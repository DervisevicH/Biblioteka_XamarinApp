using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model.Requests
{
    public class RecenzijeInsertRequest
    {
        public DateTime DatumObjave { get; set; }
        public string Recenzija { get; set; }
        public int? KorisnikId { get; set; }
        public int? KnjigaId { get; set; }
    }
}
