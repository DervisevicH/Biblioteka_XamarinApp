using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteka_WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteka_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecenzijeController : ControllerBase
    {
        private readonly IRecenzijeService _service;

        public RecenzijeController(IRecenzijeService service)
        {
            _service = service;
        }
        [HttpPost]
        public Biblioteka_Model.Recenzije Insert([FromBody] Biblioteka_Model.Requests.RecenzijeInsertRequest request) { return _service.Insert(request); }
    }
}