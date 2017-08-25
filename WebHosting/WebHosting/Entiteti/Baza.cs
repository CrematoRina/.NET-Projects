using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Baza : Paketi
    {
        public virtual string dbms { get; set; }

        public virtual IList<Programira> Programerii { get; set; }
        public virtual IList<Programer> Prog { get; set; }

        public Baza()
        {

            Programerii = new List<Programira>();
            Prog = new List<Programer>();
        }
    }
}
