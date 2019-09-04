using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteka_Model.Requests;
using Biblioteka_WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteka_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervacijeController : ControllerBase
    {
        private readonly IRezervacijeService _service;

        public RezervacijeController(IRezervacijeService service)
        {
            _service = service;
        }
        public List<Biblioteka_Model.Rezervacije> Get([FromQuery]RezervacijeSearchRequest request) { return _service.Get(request); }
        [HttpGet("{id}")]
        public Biblioteka_Model.Rezervacije GetById(int id) { return _service.GetById(id); }
        [HttpPost]
        public RezervacijeInsertRequest Insert([FromBody]RezervacijeInsertRequest request) { return _service.Insert(request); }
        [HttpPut("{id}")]
        public Biblioteka_Model.Rezervacije Update(int id, RezervacijeUpdateRequest request) { return _service.Update(id, request); }
    }
}