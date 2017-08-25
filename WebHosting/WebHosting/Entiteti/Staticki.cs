using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Staticki : Paketi
    {
        public virtual IList<Hostuje> Win { get; set; }
        public virtual IList<Odrzava> Admin { get; set; }
        public virtual IList<Windows> Window { get; set; }
        public virtual IList<Administrator> Admini { get; set; }

        public Staticki()
        {
            Win = new List<Hostuje>();
            Admin = new List<Odrzava>();
            Window = new List<Windows>();
            Admini = new List<Administrator>();
        }
    }
}
