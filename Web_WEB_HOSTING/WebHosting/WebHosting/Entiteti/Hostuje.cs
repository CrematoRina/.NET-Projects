using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class Hostuje
    {
        public virtual Windows srv { get; set; }
        public virtual Staticki paket { get; set; }
    }
}
