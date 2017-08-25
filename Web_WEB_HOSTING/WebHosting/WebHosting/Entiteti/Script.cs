using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
     public class Script : Paketi
    {
        public virtual string scriptingJezik { get; set; }

        public virtual IList<Programer> Programeri { get; set; }
    }
}
