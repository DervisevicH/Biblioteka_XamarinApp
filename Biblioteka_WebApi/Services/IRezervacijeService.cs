using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApi.Services
{
    public interface IRezervacijeService
    {
        List<Biblioteka_Model.Rezervacije> Get(RezervacijeSearchRequest request);
        Biblioteka_Model.Rezervacije GetById(int id);
        Biblioteka_Model.Rezervacije Update(int id, RezervacijeUpdateRequest request);
        RezervacijeInsertRequest Insert(RezervacijeInsertRequest request);
    }
}
