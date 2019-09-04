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
    public class ObavijestiController : ControllerBase
    {
        private readonly IObavijestiService _service;

        public ObavijestiController(IObavijestiService service)
        {
            _service = service;
        }
        public List<Biblioteka_Model.Obavijesti> Get([FromQuery] ObavijestSearchRequest request) { return _service.Get(request); }
        [HttpPost]
        public Biblioteka_Model.Obavijesti Insert([FromBody]ObavijestiInsertRequest request) { return _service.Insert(request); }
    }
}