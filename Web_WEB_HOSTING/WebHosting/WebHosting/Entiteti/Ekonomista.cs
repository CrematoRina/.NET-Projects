using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Ekonomista : Odredjeno
    {
        public virtual int idEK { get; set; }
        public virtual string stepen { get; set; }

        public virtual TehnickaPodrska Zaposlen { get; set; }
        public virtual IList<Narudzbina> PrimioNarudzbinu { get; set; }
    }
}
