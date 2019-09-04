using Biblioteka_Model;
using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApi.Services
{
    public interface IKorisniciService
    {
        List<Korisnici> Get();
        Korisnici GetById(int id);
        Korisnici Autentificiraj(string username, string password);
        Korisnici Insert(KorisniciInsertRequest request);
        Korisnici Update(int id, KorisniciUpdateRequest request);

    }
}
