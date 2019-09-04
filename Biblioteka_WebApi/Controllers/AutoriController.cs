using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteka_Model.Requests;
using Biblioteka_WebApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteka_WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AutoriController : ControllerBase
    {
        private readonly IAutoriService _service;

        public AutoriController(IAutoriService service)
        {
            _service = service;
        }
        public List<Biblioteka_Model.Autori> Get([FromQuery]AutoriSearchRequest request) { return _service.Get(request); }
        [HttpGet("{id}")]
        public Biblioteka_Model.Autori GetById(int id) { return _service.GetById(id); }
        [HttpPost]
        public Biblioteka_Model.Autori Insert(AutoriInsertUpdateRequest request) { return _service.Insert(request); }
        [HttpPut("{id}")]
        public Biblioteka_Model.Autori Update(int id,[FromBody]AutoriInsertUpdateRequest request) { return _service.Update(id, request); }
    }
}