using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model
{
    public class KnjigeAutori
    {
        public int KnjigeAutoriId { get; set; }
        public int? KnjigaId { get; set; }
        public int? AutorId { get; set; }

        public Autori Autor { get; set; }
        public Knjige Knjiga { get; set; }
    }
}
