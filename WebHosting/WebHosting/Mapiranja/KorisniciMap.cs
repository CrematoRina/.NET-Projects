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

            Id(x => x.id).Column("ID");

            Map(x => x.adresa).Column("ADRESA");
            //Map(x => x.adresa).Column("OSOBA");

           References(x => x.osoba).Column("ID_OSOBE");

            HasManyToMany(x => x.NarudzbineK)
             .Table("NARUCIO")
             .ParentKeyColumn("ID")
             .ChildKeyColumn("ID_NARUDZBINE")
             .Inverse()
             .Cascade.All();

            HasMany(x => x.NarucioNarudzbinu).KeyColumn("ID_NARUDZBINE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
