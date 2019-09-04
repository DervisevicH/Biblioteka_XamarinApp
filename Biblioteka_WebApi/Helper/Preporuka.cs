using AutoMapper;
using Biblioteka_WebApi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApi.Helper
{
    public class Preporuka
    {
        eLibraryContext _db ;
        IMapper _mapper;
        
        
        Dictionary<int, List<Ocjene>> knjige = new Dictionary<int, List<Ocjene>>();

        public Preporuka(eLibraryContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public List<Biblioteka_Model.Knjige> GetSlicneKnjige(int knjigaId)
        {
            UcitajKnjige(knjigaId);
            List<Ocjene> ocjenePosmatraneKnjige = _db.Ocjene.Where(x => x.KnjigaId == knjigaId).OrderBy(x => x.KorisnikId).ToList();
            List<Ocjene> zajednickeOcjene1 = new List<Ocjene>();
            List<Ocjene> zajednickeOcjene2 = new List<Ocjene>();

            List<Biblioteka_Model.Knjige> preporuceno = new List<Biblioteka_Model.Knjige>();

            foreach (var k in knjige)
            {
                foreach (var o in ocjenePosmatraneKnjige)
                {
                    if (k.Value.Where(x => x.KorisnikId == o.KorisnikId).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(k.Value.Where(x => x.KorisnikId == o.KorisnikId).First());
                    }
                }
                double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                if (slicnost > 0.6)
                {
                    var entity = _db.Knjige.Find(k.Key);
                    var mapped = _mapper.Map<Biblioteka_Model.Knjige>(entity);
                    preporuceno.Add(mapped);
                }


                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }
            return preporuceno;
        }

        private void UcitajKnjige(int knjigaId)
        {
            var aktivneKnjige = _db.Knjige.Where(x => x.KnjigaId != knjigaId && x.BrojDostupnihKnjiga > 0).ToList();

            List<Ocjene> listaOcjena;

            foreach (var item in aktivneKnjige)
            {
                listaOcjena = _db.Ocjene.Where(x => x.KnjigaId == item.KnjigaId).OrderBy(x => x.Korisnik).ToList();
                if (listaOcjena.Count > 0)
                    knjige.Add(item.KnjigaId, listaOcjena);

            }
        }
        double GetSlicnost(List<Ocjene> ocjene1, List<Ocjene> ocjene2)
        {
            if (ocjene1.Count != ocjene2.Count)
                return 0;

            int brojnik = 0;
            double int1 = 0;
            double int2 = 0;

            for (int i = 0; i < ocjene1.Count; i++)
            {
                brojnik += ocjene1[i].Ocjena * ocjene2[i].Ocjena;
                int1 += ocjene1[i].Ocjena * ocjene1[i].Ocjena;
                int2 += ocjene2[i].Ocjena * ocjene2[i].Ocjena;
            }

            int1 = Math.Sqrt(int1);
            int2 = Math.Sqrt(int2);

            double nazivnik = int1 * int2;

            if (nazivnik != 0)
                return brojnik / nazivnik;

            return 0;

        }
    }
}
