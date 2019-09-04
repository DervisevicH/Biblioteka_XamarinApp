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
    public class ObavijestiService : IObavijestiService
    {
        private readonly eLibraryContext _context;
        private readonly IMapper _mapper;

        public ObavijestiService(eLibraryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Biblioteka_Model.Obavijesti> Get(ObavijestSearchRequest request)
        {
            var list = _context.Obavijesti.AsQueryable();
            if (request.Naslov == null)
            {
                return _mapper.Map<List<Biblioteka_Model.Obavijesti>>(list);
            }
            else
            {
                list = list.Where(x => x.Naslov.StartsWith(request.Naslov));
                return _mapper.Map<List<Biblioteka_Model.Obavijesti>>(list);
            }
        }

        public Biblioteka_Model.Obavijesti Insert(ObavijestiInsertRequest request)
        {
            var entity = _mapper.Map<Database.Obavijesti>(request);
            _context.Obavijesti.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Biblioteka_Model.Obavijesti>(entity);
        }

     

       
    }
}
