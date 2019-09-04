using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApi.Services
{
    public interface IObavijestiService
    {
        List<Biblioteka_Model.Obavijesti> Get(ObavijestSearchRequest request);
        Biblioteka_Model.Obavijesti Insert(ObavijestiInsertRequest request);
    }
}
