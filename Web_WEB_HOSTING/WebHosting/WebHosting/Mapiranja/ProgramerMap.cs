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

            HasManyToMany(x => x.Baze)
              .Table("PROGRAMIRA")
              .ParentKeyColumn("JMBG")
              .ChildKeyColumn("ID_PAKETA")
              .Inverse()
              .Cascade.All();

            HasManyToMany(x => x.Scripte)
             .Table("PROGRAMIRA")
             .ParentKeyColumn("JMBG")
             .ChildKeyColumn("ID_PAKETA")
             .Inverse()
             .Cascade.All();
        }
    }
}
