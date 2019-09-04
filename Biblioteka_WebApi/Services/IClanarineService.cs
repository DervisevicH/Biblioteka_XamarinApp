using Biblioteka_Model;
using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApi.Services
{
    public interface IClanarineService
    {
        List<Clanarine> Get(ClanarineSearchRequest request);
        Biblioteka_Model.Clanarine GetById(int id);
        Clanarine Insert(ClanarineInsertUpdateRequest request);
        Biblioteka_Model.Clanarine Update(int id, ClanarineInsertUpdateRequest request);
    }
}
