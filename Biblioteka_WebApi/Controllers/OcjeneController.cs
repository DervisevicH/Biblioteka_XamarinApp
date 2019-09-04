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
    public class OcjeneController : ControllerBase
    {
        private readonly IOcjeneService _service;

        public OcjeneController(IOcjeneService service)
        {
            _service = service;
        }

        [HttpPost]
        public Biblioteka_Model.Ocjene Insert([FromBody] OcjeneInsertRequest request) { return _service.Insert(request); }
    }
}