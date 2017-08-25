using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Narudzbina
    {
        public virtual int idNarudzbine { get; set; }
        public virtual int idPaket { get; set; }
        public virtual DateTime trajanje { get; set; }
        public virtual DateTime datumKupovine { get; set; }

        public virtual IList<Prima> Ekonomisti { get; set; }
        public virtual IList<Narucio> Korisnici { get; set; }
        public virtual IList<Ekonomista> Ekonomist { get; set; }
        public virtual IList<Korisnici> Korisnik { get; set; }

        public Narudzbina()
        {

            Korisnici = new List<Narucio>();
            Ekonomisti = new List<Prima>();
            Korisnik = new List<Korisnici>();
            Ekonomist = new List<Ekonomista>();

        }
    }
}
