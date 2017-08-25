using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
     public class Programer : Neodredjeno
    {
        public virtual string programskiJezik { get; set; }

        public virtual IList<Baza> Baze { get; set; }
        public virtual IList<Script> Scripte { get; set; }
    }
}
