using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApi.Services
{
    public interface IZanroviService
    {
        List<Biblioteka_Model.Zanrovi> Get();
    }
}
