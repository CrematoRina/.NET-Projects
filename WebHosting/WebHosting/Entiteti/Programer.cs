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

        public virtual IList<Programira> Baze { get; set; }
        public virtual IList<Programira> Scripte { get; set; }
        public virtual IList<Baza> Bz { get; set; }
        public virtual IList<Script> Sct { get; set; }

         public Programer()
        {

            Baze = new List<Programira>();
            Scripte = new List<Programira>();
            Bz = new List<Baza>();
            Sct = new List<Script>();

        }
    }
}
