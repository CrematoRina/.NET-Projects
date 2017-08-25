using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class NarucioMap : ClassMap<Narucio>
    {
        public NarucioMap()
        {
            Table("NARUCIO");

            References(x => x.narucio).Column("ID_NARUDZBINE");
            References(x => x.korisnik).Column("ID");
        }
    }
}
