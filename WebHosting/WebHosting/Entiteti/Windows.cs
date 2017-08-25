using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Windows : Server
    {
        public virtual IList<Hostuje> Staticki { get; set; }
        public virtual IList<Staticki> Stat { get; set; }

        public Windows()
        {
            Staticki = new List<Hostuje>();
            Stat = new List<Staticki>();
        }
    }
}
