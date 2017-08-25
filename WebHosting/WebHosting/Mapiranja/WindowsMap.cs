using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class WindowsMap : SubclassMap<Windows>
    {
        public WindowsMap()
        {
            Table("WINDOWS");
            KeyColumn("IP");

            HasManyToMany(x => x.Stat)
                .Table("HOSTUJE")
                .ParentKeyColumn("IP")
                .ChildKeyColumn("ID_PAKETA")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.Staticki).KeyColumn("ID_PAKETA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
