using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Biblioteka_Model;
using Biblioteka_Model.Requests;
using Biblioteka_WebApi.Database;
using Biblioteka_WebApi.Helper;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka_WebApi.Services
{
    public class KnjigeService : IKnjigeService
    {
        private readonly eLibraryContext _context;
        private readonly IMapper _mapper;

        public KnjigeService(eLibraryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Biblioteka_Model.Knjige> Get(KnjigeSearchRequest request)
        {

            var query = _context.Knjige.Include("Recenzije.Korisnik").AsQueryable();

            if (request == null)
            {
                var lista = query.ToList();
                return _mapper.Map<List<Biblioteka_Model.Knjige>>(lista);
            }
            else if (String.IsNullOrWhiteSpace(request.Naziv) && request.ZanrId == 0)
            {

            }

            if (request.ZanrId != 0 && !String.IsNullOrEmpty(request.Naziv))
            {
                query = query.Where(x => x.ZanrId == request.ZanrId && x.Naziv.StartsWith(request.Naziv));
            }
            else if (request.ZanrId == 0)
            {
                if (!String.IsNullOrEmpty(request.Naziv))
                    query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }
            else if (request.ZanrId != 0 && request.ZanrId != null)
            {
                query = query.Where(x => x.ZanrId == request.ZanrId);
            }
            var list = query.ToList();
            List<Biblioteka_Model.Knjige> knjige = new List<Biblioteka_Model.Knjige>();
            foreach (var item in list)
            {
                Biblioteka_Model.Knjige knjiga = new Biblioteka_Model.Knjige();
                knjiga.KnjigaId = item.KnjigaId;
                knjiga.Naziv = item.Naziv;
                knjiga.Sadrzaj = item.Sadrzaj;
                knjiga.Sifra = item.Sifra;
                knjiga.Slika = item.Slika;
                knjiga.ZanrId = item.ZanrId;
                knjiga.BrojDostupnihKnjiga = item.BrojDostupnihKnjiga;
                knjiga.BrojStranica = item.BrojStranica;
                knjiga.DatumIzdavanja = item.DatumIzdavanja;
                List<Biblioteka_Model.Recenzije> recenzije = new List<Biblioteka_Model.Recenzije>();
                foreach (var rec in item.Recenzije)
                {
                    Biblioteka_Model.Recenzije recenzija = new Biblioteka_Model.Recenzije();
                    recenzija.DatumObjave = rec.DatumObjave;
                    recenzija.Recenzija = rec.Recenzija;
                    recenzija.KorisnikId = rec.KorisnikId;
                    recenzija.KnjigaId = rec.KnjigaId;
                    recenzija.RecenzijaId = rec.RecenzijaId;
                    var mappedKorisnik = _mapper.Map<Biblioteka_Model.Korisnici>(rec.Korisnik);
                    recenzija.Korisnik = mappedKorisnik;
                    recenzije.Add(recenzija);
                }
                knjiga.Recenzije = recenzije;
                knjige.Add(knjiga);
            }

            return knjige;

        }
        public Biblioteka_Model.Knjige GetById(int id)
        {
            var entity = _context.Knjige.Include("KnjigeAutori.Autor").Where(x => x.KnjigaId == id).First();
            var mappedEntity= _mapper.Map<Biblioteka_Model.Knjige>(entity);

            //var entityy = _context.Knjige.Include("KnjigeAutori.Autor").Where(x => x.KnjigaId == id).First();
            //var lista = entityy.KnjigeAutori.ToList();
            //foreach (var item in lista)
            //{
            //    var autorId = item.AutorId;
            //    mappedEntity.Autori.Add(autorId.Value);
            //}

            return mappedEntity;
        }
        public List<Biblioteka_Model.Knjige> GetPreporucenoById(int id)
        {
            Preporuka preporuka = new Preporuka(_context, _mapper);
            var lista= preporuka.GetSlicneKnjige(id);
            return lista;
        }

        public Biblioteka_Model.Knjige Insert(KnjigeInsertUpdateRequest request)
        {
            var entity = _mapper.Map<Database.Knjige>(request);
            _context.Knjige.Add(entity);
            _context.SaveChanges();
            List<Biblioteka_Model.KnjigeAutori> listaAutora = new List<Biblioteka_Model.KnjigeAutori>();
            foreach (var item in request.Autori)
            {
                Database.KnjigeAutori knjigeAutori = new Database.KnjigeAutori();
                knjigeAutori.KnjigaId = entity.KnjigaId;
                knjigeAutori.AutorId = item;
                _context.KnjigeAutori.Add(knjigeAutori);
            }

            _context.SaveChanges();

            var knjiga = _context.Knjige.Include("KnjigeAutori.Autor").Where(x => x.KnjigaId == entity.KnjigaId).First();
            return _mapper.Map<Biblioteka_Model.Knjige>(knjiga);
        }

        public Biblioteka_Model.Knjige Update(int id, KnjigeInsertUpdateRequest request)
        {
            var entity = _context.Knjige.Find(id);
            _context.Knjige.Attach(entity);
            _context.Knjige.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Biblioteka_Model.Knjige>(entity);


        }
    }
}
