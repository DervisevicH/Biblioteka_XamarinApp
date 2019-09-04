using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka_WebApi.Services
{
    public interface IRecenzijeService
    {
         Biblioteka_Model.Recenzije Insert(RecenzijeInsertRequest request);
    }
}
