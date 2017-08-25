using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Staticki : Paketi
    {
        public virtual IList<Windows> Win { get; set; }
        public virtual IList<Administrator> Admin { get; set; }

        public Staticki()
        {
            Win = new List<Windows>();
        }
    }
}
