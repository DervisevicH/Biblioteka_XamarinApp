using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApi.Services
{
    public interface IOcjeneService
    {
        Biblioteka_Model.Ocjene Insert(OcjeneInsertRequest request);
    }
}
