using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model
{
    public class Ocjene
    {
        public int OcjenaId { get; set; }
        public int? KorisnikId { get; set; }
        public int? KnjigaId { get; set; }
        public int Ocjena { get; set; }

    }
}
