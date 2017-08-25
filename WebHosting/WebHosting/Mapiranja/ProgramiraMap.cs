using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class ProgramiraMap : ClassMap<Programira>
    {
        public ProgramiraMap()
        {
            Table("PRIMA");

            References(x => x.programira).Column("JMBG");
            References(x => x.pakets).Column("ID_PAKETA");
            References(x => x.paketb).Column("ID_PAKETA");
        }
    }
}
