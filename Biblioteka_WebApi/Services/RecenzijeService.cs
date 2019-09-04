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
    public class RecenzijeService : IRecenzijeService
    {
        private readonly eLibraryContext _context;
        private readonly IMapper _mapper;

        public RecenzijeService(eLibraryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Biblioteka_Model.Recenzije Insert(RecenzijeInsertRequest request)
        {
            var entity = _mapper.Map<Database.Recenzije>(request);
            _context.Recenzije.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Biblioteka_Model.Recenzije>(entity);
        }
    }
}
