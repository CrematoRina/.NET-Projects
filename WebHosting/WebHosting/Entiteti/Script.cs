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

        public virtual IList<Programira> Programeri { get; set; }
        public virtual IList<Programer> Pro { get; set; }

          public Script()
        {

            Programeri = new List<Programira>();
            Pro = new List<Programer>();

        }
    }
}
