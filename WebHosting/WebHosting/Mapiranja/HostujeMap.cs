using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class HostujeMap : ClassMap<Hostuje>
    {
        public HostujeMap()
        {
            Table("HOSTUJE");

            References(x => x.srv).Column("IP");
            References(x => x.paket).Column("ID_PAKETA");
        }
    }
}
