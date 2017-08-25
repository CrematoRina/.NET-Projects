using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class ProgramerMap : SubclassMap<Programer>
    {
        public ProgramerMap()
        {
            Table("PROGRAMER");
            KeyColumn("JMBG");

            Map(x => x.programskiJezik).Column("PROGRAMSKI_JEZIK");

            HasManyToMany(x => x.Bz)
              .Table("PROGRAMIRA")
              .ParentKeyColumn("JMBG")
              .ChildKeyColumn("ID_PAKETA")
              .Inverse()
              .Cascade.All();

            HasMany(x => x.Baze).KeyColumn("ID_PAKETA").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.Sct)
             .Table("PROGRAMIRA")
             .ParentKeyColumn("JMBG")
             .ChildKeyColumn("ID_PAKETA")
             .Inverse()
             .Cascade.All();

            HasMany(x => x.Scripte).KeyColumn("ID_PAKETA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
