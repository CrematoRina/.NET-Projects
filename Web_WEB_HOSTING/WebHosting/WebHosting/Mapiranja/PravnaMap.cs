using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class PravnaMap : SubclassMap<Pravna>
    {
        public PravnaMap()
        {
            Table("PRAVNA");
            KeyColumn("ID");

            Map(x => x.pib).Column("PIB");
            Map(x => x.naziv).Column("NAZIV");
        }
    }
}
