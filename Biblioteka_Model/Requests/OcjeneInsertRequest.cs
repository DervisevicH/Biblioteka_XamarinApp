using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model.Requests
{
    public class OcjeneInsertRequest
    {
        public int? KorisnikId { get; set; }
        public int? KnjigaId { get; set; }
        public int Ocjena { get; set; }
    }
}
