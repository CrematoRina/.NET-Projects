using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class OdredjenoMap : SubclassMap<Odredjeno>
    {
        public OdredjenoMap()
        {
            Table("ODREDJENO");
            KeyColumn("JMBG");

            Map(x => x.IstekUgovora).Column("ISTEK_UGOVORA");
            
        }
    }
}
