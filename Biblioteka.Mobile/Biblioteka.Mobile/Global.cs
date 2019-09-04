using Biblioteka_Model;
using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka.Mobile
{
    public class Global
    {
        public static Korisnici PrijavljeniKorisnik { get; set; }
        public static bool klijentPrijavljen { get; set; }
        public static RezervacijeInsertRequest aktivnaRezervacije { get; set; }
    }
}
