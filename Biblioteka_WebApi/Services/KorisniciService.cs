using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Biblioteka_Model;
using Biblioteka_Model.Requests;
using Biblioteka_WebApi.Database;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka_WebApi.Services
{


    public class KorisniciService : IKorisniciService
    {
        private readonly eLibraryContext _context;
        private readonly IMapper _mapper;

        public KorisniciService(eLibraryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Biblioteka_Model.Korisnici Autentificiraj(string username, string password)
        {
            var user = _context.Korisnici.Include("Uloga").FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, password);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Biblioteka_Model.Korisnici>(user);
                }
                else
                    return null;
            }        
            
            else
            return null;
        }

        public List<Biblioteka_Model.Korisnici> Get()
        {
            var list = _context.Korisnici.Include("Uloga").Where(x => x.Uloga.Naziv == "Član").ToList();

            var mapped= _mapper.Map<List<Biblioteka_Model.Korisnici>>(list);
            return mapped;

        } 

        public Biblioteka_Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);           

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);
            entity.UlogaId = 2;

            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Biblioteka_Model.Korisnici>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Biblioteka_Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);
            if (entity != null)
                return _mapper.Map<Biblioteka_Model.Korisnici>(entity);
            else
                return null;
        }

        public Biblioteka_Model.Korisnici Update(int id, KorisniciUpdateRequest request)
        {
            var entity = _context.Korisnici.Find(id);
            request.UlogaId = entity.UlogaId.Value;
            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Lozinka))
            {             

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Biblioteka_Model.Korisnici>(entity);
        }
    }
}
