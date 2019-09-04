using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApi.Services
{
    public interface IKnjigeService
    {
        List<Biblioteka_Model.Knjige> Get(KnjigeSearchRequest request);
        Biblioteka_Model.Knjige GetById(int id);
        List<Biblioteka_Model.Knjige> GetPreporucenoById(int id);
        Biblioteka_Model.Knjige Insert(KnjigeInsertUpdateRequest request);
        Biblioteka_Model.Knjige Update(int id, KnjigeInsertUpdateRequest request);
    }
}
