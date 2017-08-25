using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class OdrzavaMap : ClassMap<Odrzava>
    {
        public OdrzavaMap()
        {
            Table("ODRZAVA");

            References(x => x.odrzavaoc).Column("JMBG");
            References(x => x.spaket).Column("ID_PAKETA");
        }
    }
}