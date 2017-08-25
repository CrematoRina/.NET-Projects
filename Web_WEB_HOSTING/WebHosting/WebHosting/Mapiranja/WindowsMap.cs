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

            HasManyToMany(x => x.Staticki)
                .Table("HOSTUJE")
                .ParentKeyColumn("IP")
                .ChildKeyColumn("ID_PAKETA")
                .Inverse()
                .Cascade.All();
        }
    }
}
