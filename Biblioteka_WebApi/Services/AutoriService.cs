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


    public class AutoriService : IAutoriService
    {
        private readonly eLibraryContext _context;
        private readonly IMapper _mapper;

        public AutoriService(eLibraryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Biblioteka_Model.Autori> Get(AutoriSearchRequest request)
        {
            var list = _context.Autori.AsQueryable();
            if (request.ImePrezime == null)
            {
                return _mapper.Map<List<Biblioteka_Model.Autori>>(list);
            }
            else
            {
                list = list.Where(x => x.Ime.StartsWith(request.ImePrezime) || x.Prezime.StartsWith(request.ImePrezime));
                return _mapper.Map<List<Biblioteka_Model.Autori>>(list);
            }
        }
        public Biblioteka_Model.Autori GetById(int id)
        {
            var entity = _context.Autori.Find(id);
            return _mapper.Map<Biblioteka_Model.Autori>(entity);
        }

        public Biblioteka_Model.Autori Insert(AutoriInsertUpdateRequest request)
        {
            var entity = _mapper.Map<Database.Autori>(request);
            _context.Autori.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Biblioteka_Model.Autori>(entity);
        }

        public Biblioteka_Model.Autori Update(int id, AutoriInsertUpdateRequest request)
        {
            var entity = _context.Autori.Find(id);           
          
            _context.Autori.Attach(entity);
            _context.Autori.Update(entity);

            
            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Biblioteka_Model.Autori>(entity);

        }
    }
}
