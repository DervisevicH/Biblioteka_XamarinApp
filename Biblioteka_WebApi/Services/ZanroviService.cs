using AutoMapper;
using Biblioteka_WebApi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApi.Services
{
    public class ZanroviService:IZanroviService
    {
        private readonly eLibraryContext _context;
        private readonly IMapper _mapper;

        public ZanroviService(eLibraryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Biblioteka_Model.Zanrovi> Get()
        {
            var list = _context.Zanrovi.ToList();
            return _mapper.Map<List<Biblioteka_Model.Zanrovi>>(list);
        }
    }
}
