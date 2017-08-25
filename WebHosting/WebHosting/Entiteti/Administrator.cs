using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Administrator : TehnickaStruka
    {
        public virtual string os { get; set; }

        public virtual IList<Odrzava> Static { get; set; }
        public virtual IList<Staticki> Statik { get; set; }

        public Administrator()
        {

            Static = new List<Odrzava>();
            Statik = new List<Staticki>();
        }
    }
}
