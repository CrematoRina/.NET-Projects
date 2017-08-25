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

        public virtual IList<Programer> Programerii { get; set; }
    }
}
