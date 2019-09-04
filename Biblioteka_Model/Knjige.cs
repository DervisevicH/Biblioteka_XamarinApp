using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka_Model
{
    public class Knjige
    {
        public int KnjigaId { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public int? BrojStranica { get; set; }
        public int BrojDostupnihKnjiga { get; set; }
        public DateTime? DatumIzdavanja { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }
        public int? ZanrId { get; set; }
        public List<int> Autori { get; set; } = new List<int>();
        public ICollection<Recenzije> Recenzije { get; set; } 
    }
}
