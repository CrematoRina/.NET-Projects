using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class KorisniciMap : ClassMap<Korisnici>
    {
        public KorisniciMap()
        {
            Table("KORISNICI");

            // Id(x => x.id, "ID").GeneratedBy.TriggerIdentity(); 

            Map(x => x.id).Column("ID");
            Map(x => x.adresa).Column("ADRESA");

            References(x => x.osoba).Column("ID_OSOBE");

            HasManyToMany(x => x.NarucioNarudzbinu)
             .Table("NARUCIO")
             .ParentKeyColumn("ID")
             .ChildKeyColumn("ID_NARUDZBINE")
             .Inverse()
             .Cascade.All();
        }
    }
}
