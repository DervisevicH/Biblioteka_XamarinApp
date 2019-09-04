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
    public class ClanarineController : ControllerBase
    {
        private readonly IClanarineService _service;

        public ClanarineController(IClanarineService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Biblioteka_Model.Clanarine> Get([FromQuery]ClanarineSearchRequest request) { return _service.Get(request); }
        [HttpGet("{id}")]
        public Biblioteka_Model.Clanarine GetById(int id) { return _service.GetById(id); }
        [HttpPost]
        public Biblioteka_Model.Clanarine Insert(ClanarineInsertUpdateRequest request) { return _service.Insert(request); }
        [HttpPut("{id}")]
        public Biblioteka_Model.Clanarine Update(int id, [FromBody] ClanarineInsertUpdateRequest request) { return _service.Update(id, request); }
    }
}