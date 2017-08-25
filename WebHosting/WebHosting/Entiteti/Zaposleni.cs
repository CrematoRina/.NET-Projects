using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebHosting.Entiteti
{
    public class Zaposleni
    {
        public virtual int jmbg { get; set; }
        public virtual string ime { get; set; }
        public virtual string ImeOca { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime GodinaRodjenja { get; set; }
        public virtual DateTime DatumZaposlenja { get; set; }
        public virtual int RadniStaz { get; set; }
    }
}
