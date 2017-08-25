using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class ServerskiMap : SubclassMap<Serverski>
    {
        public ServerskiMap()
        {
            Table("SERVERSKI");
            KeyColumn("ID_PAKETA");
        }
    }
}
