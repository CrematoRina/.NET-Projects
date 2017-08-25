using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class TehnickaPodrska
    {
        public virtual int id { get; set; }

        public virtual IList<Ekonomista> Ekonomiste { get; set; }

        public TehnickaPodrska()
        {
            Ekonomiste = new List<Ekonomista>();
        }
    }

    
}
