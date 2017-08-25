using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class ServerMap : ClassMap<Server>
    {
        public ServerMap()
        {
            Table("SERVER");

            Id(x => x.ip).Column("IP");
        }
    }
}
