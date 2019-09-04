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
    public class OcjeneService : IOcjeneService
    {

        private readonly eLibraryContext _context;
        private readonly IMapper _mapper;

        public OcjeneService(eLibraryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Biblioteka_Model.Ocjene Insert(OcjeneInsertRequest request)
        {
            bool postoji=false;
            var lista = _context.Ocjene.ToList();
            foreach (var item in lista)
            {
                if (item.KnjigaId == request.KnjigaId && item.KorisnikId == request.KorisnikId)
                    postoji = true;
            }
            if (postoji)
                return null;
            else
            {
                var entity = _mapper.Map<Database.Ocjene>(request);
                _context.Ocjene.Add(entity);
                _context.SaveChanges();
                return _mapper.Map<Biblioteka_Model.Ocjene>(entity);
            }
        }
    }
}
