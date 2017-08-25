using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Windows : Server
    {
        public virtual IList<Staticki> Staticki { get; set; }

        public Windows()
        {
            Staticki = new List<Staticki>();
        }
    }
}
