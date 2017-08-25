using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class PrimaMap : ClassMap<Prima>
    {
        public PrimaMap()
        {
            Table("PRIMA");

            References(x => x.primaoc).Column("JMBG");
            References(x => x.narudzbinu).Column("ID_NARUDZBINE");
        }
    }
}
