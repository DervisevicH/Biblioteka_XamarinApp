using System;
using System.Collections.Generic;

namespace Biblioteka_WebApi.Database
{
    public partial class Zanrovi
    {
        public Zanrovi()
        {
            Knjige = new HashSet<Knjige>();
        }

        public int ZanrId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Knjige> Knjige { get; set; }
    }
}
