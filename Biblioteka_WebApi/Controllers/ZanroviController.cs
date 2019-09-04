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
    public class ZanroviController : ControllerBase
    {
        private readonly IZanroviService _service;

        public ZanroviController(IZanroviService service)
        {
            _service = service;
        }
        public List<Biblioteka_Model.Zanrovi> Get() { return _service.Get(); }
    }
}