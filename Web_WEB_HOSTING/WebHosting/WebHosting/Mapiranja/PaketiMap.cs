using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;
namespace WebHosting.Mapiranja
{
    class PaketiMap : ClassMap<Paketi>
    {
        public PaketiMap()
        {
            Table("PAKETI");

            Map(x => x.idPaketa).Column("ID_PAKETA");
            Map(x => x.cena).Column("CENA");
            Map(x => x.prostor).Column("PROSTOR");
        }
    }
}
