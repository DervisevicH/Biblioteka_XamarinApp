using System;
using System.Collections.Generic;

namespace Biblioteka_WebApi.Database
{
    public partial class Knjige
    {
        public Knjige()
        {
            KnjigeAutori = new HashSet<KnjigeAutori>();
            Ocjene = new HashSet<Ocjene>();
            Recenzije = new HashSet<Recenzije>();
            RezervacijeKnjige = new HashSet<RezervacijeKnjige>();
        }

        public int KnjigaId { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public int? BrojStranica { get; set; }
        public int BrojDostupnihKnjiga { get; set; }
        public DateTime? DatumIzdavanja { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }
        public int? ZanrId { get; set; }

        public Zanrovi Zanr { get; set; }
        public ICollection<KnjigeAutori> KnjigeAutori { get; set; }
        public ICollection<Ocjene> Ocjene { get; set; }
        public ICollection<Recenzije> Recenzije { get; set; }
        public ICollection<RezervacijeKnjige> RezervacijeKnjige { get; set; }
    }
}
