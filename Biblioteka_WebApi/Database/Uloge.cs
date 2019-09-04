using System;
using System.Collections.Generic;

namespace Biblioteka_WebApi.Database
{
    public partial class Uloge
    {
        public Uloge()
        {
            Korisnici = new HashSet<Korisnici>();
        }

        public int UlogaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Korisnici> Korisnici { get; set; }
    }
}
