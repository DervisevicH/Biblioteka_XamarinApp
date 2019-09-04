using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model.Requests
{
    public class ObavijestiInsertRequest
    {
        public string Naslov { get; set; }
        public DateTime DatumObjave { get; set; }
        public string Sadrzaj { get; set; }
        public int? KorisnikId { get; set; }

    }
}
