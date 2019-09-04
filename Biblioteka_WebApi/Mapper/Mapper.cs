using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteka_Model;
namespace Biblioteka_WebApi.Mapper
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Biblioteka_Model.Korisnici>().ForMember(x => x.ImePrezime, y => y.MapFrom(z => z.Ime + " " + z.Prezime));
            CreateMap<Database.Korisnici, Biblioteka_Model.Requests.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnici, Biblioteka_Model.Requests.KorisniciUpdateRequest>().ReverseMap();

            CreateMap<Database.Uloge, Biblioteka_Model.Uloge>();

            CreateMap<Database.Obavijesti, Biblioteka_Model.Obavijesti>();
            CreateMap<Database.Obavijesti, Biblioteka_Model.Requests.ObavijestiInsertRequest>().ReverseMap();

            CreateMap<Database.Clanarine,Biblioteka_Model.Clanarine>().ForMember(x => x.ImePrezime, y => y.MapFrom(z => z.Korisnik.Ime + " " + z.Korisnik.Prezime));
            CreateMap<Database.Clanarine, Biblioteka_Model.Requests.ClanarineInsertUpdateRequest>().ReverseMap();

            CreateMap<Database.Autori, Biblioteka_Model.Autori>().ForMember(x => x.ImePrezime, y => y.MapFrom(z => z.Ime + " " + z.Prezime));
            CreateMap<Database.Autori, Biblioteka_Model.Requests.AutoriInsertUpdateRequest>().ReverseMap();

            CreateMap<Database.Zanrovi, Biblioteka_Model.Zanrovi>();

            CreateMap<Database.Ocjene, Biblioteka_Model.Ocjene>();
            CreateMap<Database.Ocjene, Biblioteka_Model.Requests.OcjeneInsertRequest>().ReverseMap();

            CreateMap<Database.Recenzije, Biblioteka_Model.Recenzije>();
            CreateMap<Database.Recenzije, Biblioteka_Model.Requests.RecenzijeInsertRequest>().ReverseMap();

            CreateMap<Database.KnjigeAutori, Biblioteka_Model.KnjigeAutori>();

            CreateMap<Database.Knjige, Biblioteka_Model.Knjige>();
            CreateMap<Database.Knjige, Biblioteka_Model.Requests.KnjigeInsertUpdateRequest>().ReverseMap();

            CreateMap<Database.Rezervacije, Biblioteka_Model.Rezervacije>().ForMember(x => x.ImePrezimeClana, y => y.MapFrom(z => z.Korisnik.Ime + " " + z.Korisnik.Prezime));
            CreateMap<Database.Rezervacije, Biblioteka_Model.Requests.RezervacijeUpdateRequest>().ReverseMap();
            CreateMap<Database.Rezervacije, Biblioteka_Model.Requests.RezervacijeInsertRequest>().ReverseMap();


        }
    }
}
