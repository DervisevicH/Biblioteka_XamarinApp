using System;
using System.Collections.Generic;

namespace Biblioteka_WebApi.Database
{
    public partial class KnjigeAutori
    {
        public int KnjigeAutoriId { get; set; }
        public int? KnjigaId { get; set; }
        public int? AutorId { get; set; }

        public Autori Autor { get; set; }
        public Knjige Knjiga { get; set; }
    }
}
