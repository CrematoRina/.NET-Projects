using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class BazaMap : SubclassMap<Baza>
    {
        public BazaMap()
        {
            Table("BAZA");
            KeyColumn("ID_PAKETA");

            Map(x => x.dbms).Column("DBMS");

            HasManyToMany(x => x.Prog)
             .Table("PROGRAMIRA")
             .ParentKeyColumn("ID_PAKETA")
             .ChildKeyColumn("JMBG")
             .Inverse()
             .Cascade.All();

            HasMany(x => x.Programerii).KeyColumn("JMBG").LazyLoad().Cascade.All().Inverse();
        }
    }
}
