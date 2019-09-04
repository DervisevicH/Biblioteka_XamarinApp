using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model
{
    public class RezervacijeKnjige
    {
        public int ? RezervacijaKnjigaId { get; set; }
        public int? KnjigaId { get; set; }
        public int? RezervacijaId { get; set; }

    }
}
