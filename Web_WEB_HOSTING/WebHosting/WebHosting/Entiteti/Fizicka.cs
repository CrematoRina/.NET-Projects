using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Fizicka : Korisnici
    {
        public virtual int jmbg { get; set; }
        public virtual string imeK { get; set; }
        public virtual string prezimeK { get; set; }
    }
}
