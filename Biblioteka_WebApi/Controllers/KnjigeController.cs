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
    public class KnjigeController : ControllerBase
    {
        private readonly IKnjigeService _service;

        public KnjigeController(IKnjigeService service)
        {
            _service = service;
        }
        public List<Biblioteka_Model.Knjige> Get([FromQuery]KnjigeSearchRequest request) { return _service.Get(request); }
        [HttpGet("{id}")]
        public Biblioteka_Model.Knjige GetById(int id) { return _service.GetById(id); }
        [HttpGet("GetPreporucenoById/{id}")]
        //[Route("api/Knjige/GetPreporucenoById/{id}")]
        public List<Biblioteka_Model.Knjige> GetPreporucenoById(int id) { return _service.GetPreporucenoById(id); }
        [HttpPost]
        public Biblioteka_Model.Knjige Insert(KnjigeInsertUpdateRequest request) { return _service.Insert(request); }
        [HttpPut("{id}")]
        public Biblioteka_Model.Knjige Update(int id,[FromBody] KnjigeInsertUpdateRequest request) { return _service.Update(id, request); }
    }
}