using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteka_Model;
using Biblioteka_Model.Requests;
using Biblioteka_WebApi.Database;
using Biblioteka_WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteka_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }
        public List<Biblioteka_Model.Korisnici> Get(){ return _service.Get(); }
        [HttpGet("{id}")]
        public Biblioteka_Model.Korisnici GetById(int id) { return _service.GetById(id); }
        [HttpPut("{id}")]
        public Biblioteka_Model.Korisnici Update(int id,[FromBody] KorisniciUpdateRequest request) { return _service.Update(id, request); }
        [HttpPost]
        public Biblioteka_Model.Korisnici Insert(KorisniciInsertRequest request) { return _service.Insert(request); }
        

    }
}