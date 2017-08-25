using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class TehnickaPodrskaMap : ClassMap<TehnickaPodrska>
    {
        public TehnickaPodrskaMap()
        {
            Table("TEHNICKA_PODRSKA");

            Id(x => x.id).Column("ID_KONTAKT");

            HasMany(x => x.Ekonomiste);
        }
    }
}
