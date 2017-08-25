using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHosting.Entiteti
{
    public class KontakOsoba
    {
        public virtual int idOsobe { get; set; }
        public virtual string imeO { get; set; }
        public virtual string prezimeO { get; set; }
        public virtual int telefon { get; set; }

    }
}
