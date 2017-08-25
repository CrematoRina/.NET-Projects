using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class StatickiMap : SubclassMap<Staticki>
    {
        public StatickiMap()
        {
            Table("STATIC");
            KeyColumn("ID_PAKETA");

            HasManyToMany(x => x.Window)
              .Table("HOSTUJE")
              .ParentKeyColumn("ID_PAKETA")
              .ChildKeyColumn("IP")
              .Inverse()
              .Cascade.All();

            HasMany(x => x.Win).KeyColumn("IP").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.Admini)
              .Table("ODRZAVA")
              .ParentKeyColumn("ID_PAKETA")
              .ChildKeyColumn("JMBG")
              .Inverse()
              .Cascade.All();

            HasMany(x => x.Admin).KeyColumn("JMBG").LazyLoad().Cascade.All().Inverse();
        }
    }
}
