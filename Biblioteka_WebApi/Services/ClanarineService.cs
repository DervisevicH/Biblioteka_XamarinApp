using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Biblioteka_Model;
using Biblioteka_Model.Requests;
using Biblioteka_WebApi.Database;

namespace Biblioteka_WebApi.Services
{
    public class ClanarineService : IClanarineService
    {
        private readonly eLibraryContext _context;
        private readonly IMapper _mapper;

        public ClanarineService(eLibraryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Biblioteka_Model.Clanarine> Get(ClanarineSearchRequest request)
        {
            var query = _context.Clanarine.AsQueryable();           
            query = query.Where(x => x.KorisnikId == request.ClanId && x.DatumUplate.Year == request.Godina.Year);
            var list = query.ToList();
            foreach (var item in list)
            {
                item.Korisnik = _context.Korisnici.Where(x => x.KorisnikId == item.KorisnikId).First();
            }
            return _mapper.Map<List<Biblioteka_Model.Clanarine>>(list);
        }

        public Biblioteka_Model.Clanarine GetById(int id)
        {
            var entity = _context.Clanarine.Find(id);
            return _mapper.Map<Biblioteka_Model.Clanarine>(entity);
        }

        public Biblioteka_Model.Clanarine Insert(ClanarineInsertUpdateRequest request)
        {
            var entity = _mapper.Map<Database.Clanarine>(request);
            _context.Clanarine.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Biblioteka_Model.Clanarine>(entity);
        }

        public Biblioteka_Model.Clanarine Update(int id, ClanarineInsertUpdateRequest request)
        {
            var entity = _context.Clanarine.Find(id);

            _context.Clanarine.Attach(entity);
            _context.Clanarine.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();
            return _mapper.Map<Biblioteka_Model.Clanarine>(entity);
        }
    }
}
