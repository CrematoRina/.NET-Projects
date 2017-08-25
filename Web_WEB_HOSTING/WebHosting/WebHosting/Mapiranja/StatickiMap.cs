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

            HasManyToMany(x => x.Win)
              .Table("HOSTUJE")
              .ParentKeyColumn("ID_PAKETA")
              .ChildKeyColumn("IP")
              .Inverse()
              .Cascade.All();

            HasManyToMany(x => x.Admin)
              .Table("ODRZAVA")
              .ParentKeyColumn("ID_PAKETA")
              .ChildKeyColumn("JMBG")
              .Inverse()
              .Cascade.All();
        }
    }
}
