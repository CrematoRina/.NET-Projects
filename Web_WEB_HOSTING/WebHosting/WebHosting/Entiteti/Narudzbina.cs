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

        public virtual IList<Administrator> Ekonomisti { get; set; }
        public virtual IList<Korisnici> Korisnici { get; set; }
    }
}
