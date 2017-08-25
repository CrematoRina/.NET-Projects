using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Odredjeno : Zaposleni
    {
        public virtual DateTime IstekUgovora { get; set; }
    }
}
