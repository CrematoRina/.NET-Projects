using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Programira
    {
        public virtual Programer programira { get; set; }
        public virtual Script pakets { get; set; }
        public virtual Baza paketb { get; set; }
    }
}
