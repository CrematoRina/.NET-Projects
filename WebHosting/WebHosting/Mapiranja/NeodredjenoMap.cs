using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class NeodredjenoMap : SubclassMap<Linux>
    {
        public NeodredjenoMap()
        {
            Table("NEODREDJENO");
            KeyColumn("JMBG");
        }
    }
}
