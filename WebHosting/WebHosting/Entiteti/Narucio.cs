using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Narucio
    {
        public virtual Narudzbina narucio { get; set; }
        public virtual Korisnici korisnik { get; set; }
    }
}
