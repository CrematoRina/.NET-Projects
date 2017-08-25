using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class AdministratorMap : SubclassMap<Administrator>
    {
        public AdministratorMap()
        {
            Table("ADMINISTRATOR");
            KeyColumn("JMBG");

            Map(x => x.os).Column("OPERATIVNI_SISTEM");

            HasManyToMany(x => x.Statik)
              .Table("ODRZAVA")
              .ParentKeyColumn("JMBG")
              .ChildKeyColumn("ID_PAKETA")
              .Inverse()
              .Cascade.All();

            HasMany(x => x.Static).KeyColumn("ID_PAKETA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
