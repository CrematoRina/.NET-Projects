using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Pravna : Korisnici
    {
        public virtual int pib { get; set; }
        public virtual string naziv { get; set; }
    }
}
