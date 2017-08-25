using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Korisnici
    {
        public virtual string adresa { get; set; }
        public virtual int id { get; set; }
        public virtual int osoba { get; set; }

        public virtual IList<Narudzbina> NarucioNarudzbinu { get; set; }
    }
}
