using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Biblioteka_Model;
using Biblioteka_Model.Requests;
using Biblioteka_WebApi.Database;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka_WebApi.Services
{
    public class RezervacijeService : IRezervacijeService
    {
        private readonly eLibraryContext _context;
        private readonly IMapper _mapper;

        public RezervacijeService(eLibraryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Biblioteka_Model.Rezervacije> Get(RezervacijeSearchRequest request)
        {
            var query = _context.Rezervacije.AsQueryable().Include(x => x.Korisnik).Where(x=>x.KorisnikId==request.ClanId && x.Zavrsena==false);          
            var list = query.ToList();
            return _mapper.Map<List<Biblioteka_Model.Rezervacije>>(list);
        }

        public Biblioteka_Model.Rezervacije GetById(int id)
        {
            Database.Rezervacije entity = _context.Rezervacije.Include(x => x.RezervacijeKnjige).Include(x=>x.Korisnik).Where(x => x.RezervacijaId == id).First();
            var mappedEntity = _mapper.Map<Biblioteka_Model.Rezervacije>(entity);
            int i = 1;
            foreach (var item in entity.RezervacijeKnjige)
            {

                var knjiga = _context.Knjige.Where(x => x.KnjigaId == item.KnjigaId).First();
                var naziv = knjiga.Naziv;
                mappedEntity.listaKnjiga += i.ToString();
                mappedEntity.listaKnjiga += ". " + naziv;
                mappedEntity.listaKnjiga += Environment.NewLine;
                i++;
            }

            return mappedEntity;
        }

        public RezervacijeInsertRequest Insert(RezervacijeInsertRequest request)
        {
            var entity = _mapper.Map<Database.Rezervacije>(request);
            entity.BrojKnjiga = request.Knjige.Count();
            _context.Rezervacije.Add(entity);
            _context.SaveChanges();
            List<Biblioteka_Model.RezervacijeKnjige> listaKnjiga = new List<Biblioteka_Model.RezervacijeKnjige>();
           
            foreach (var item in request.Knjige)
            {
                Database.RezervacijeKnjige rezervacijeKnjige = new Database.RezervacijeKnjige();
                rezervacijeKnjige.RezervacijaId = entity.RezervacijaId;
                rezervacijeKnjige.KnjigaId = item.KnjigaId;
                _context.RezervacijeKnjige.Add(rezervacijeKnjige);
                
            }

            _context.SaveChanges();

            var savedEntity = _mapper.Map<RezervacijeInsertRequest>(entity);
            return savedEntity;
        }

        public Biblioteka_Model.Rezervacije Update(int id, RezervacijeUpdateRequest request )
        {
            var entity = _context.Rezervacije.Find(id);
            if(request.DatumPreuzimanja!=null && request.DatumVracanja !=null)
            {
                request.Zavrsena = true;
                entity.Zavrsena = true;
            }
            _context.Rezervacije.Attach(entity);
            _context.Rezervacije.Update(entity);

            
            entity.DatumPreuzimanja = request.DatumPreuzimanja;
            entity.DatumRezervacije = request.DatumRezervacije;
            entity.DatumVracanja = request.DatumVracanja;
            entity.KorisnikId = request.KorisnikId;
            entity.Zavrsena = request.Zavrsena;

            _context.SaveChanges();
            if (entity.DatumPreuzimanja != null && entity.DatumVracanja==null)
            {
                var rezervacijeKnjige = _context.RezervacijeKnjige.Where(x => x.RezervacijaId == id).ToList();
                foreach (var item in rezervacijeKnjige)
                {
                    var knjiga = _context.Knjige.Where(x => x.KnjigaId == item.KnjigaId).Single();
                    knjiga.BrojDostupnihKnjiga =knjiga.BrojDostupnihKnjiga-1;
                    _context.Knjige.Attach(knjiga);
                    _context.Knjige.Update(knjiga);
                    _context.SaveChanges();
                }
            }
            else
            if(entity.DatumPreuzimanja !=null && entity.DatumVracanja != null)
            {
                var rezervacijeKnjige = _context.RezervacijeKnjige.Where(x => x.RezervacijaId == id).ToList();
                foreach (var item in rezervacijeKnjige)
                {
                    var knjiga = _context.Knjige.Where(x => x.KnjigaId == item.KnjigaId).Single();
                    knjiga.BrojDostupnihKnjiga = knjiga.BrojDostupnihKnjiga + 1;
                    _context.Knjige.Attach(knjiga);
                    _context.Knjige.Update(knjiga);
                    _context.SaveChanges();
                }
            }

            return _mapper.Map<Biblioteka_Model.Rezervacije>(entity);
        }
    }
}
