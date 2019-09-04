using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApi.Services
{
    public interface IAutoriService
    {
        List<Biblioteka_Model.Autori> Get(AutoriSearchRequest request);
        Biblioteka_Model.Autori GetById(int id);
        Biblioteka_Model.Autori Insert(AutoriInsertUpdateRequest request);
        Biblioteka_Model.Autori Update(int id, AutoriInsertUpdateRequest request);
    }
}
