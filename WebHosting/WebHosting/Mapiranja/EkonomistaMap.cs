using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class EkonomistaMap : SubclassMap<Ekonomista>
    {
        public EkonomistaMap()
        {
            Table("EKONOMISTA");
            KeyColumn("JMBG");

            Map(x => x.stepen).Column("STEPEN_STRUCNE_SPREME");
            Map(x => x.idEK).Column("ID_EK");

            References(x => x.Zaposlen);

            HasManyToMany(x => x.Narudzbine)
              .Table("PRIMA")
              .ParentKeyColumn("JMBG")
              .ChildKeyColumn("ID_NARUDZBINE")
              .Inverse()
              .Cascade.All();

            HasMany(x => x.PrimioNarudzbinu).KeyColumn("ID_NARUDZBINE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
