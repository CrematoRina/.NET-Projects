using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class ScriptMap : SubclassMap<Script>
    {
        public ScriptMap()
        {
            Table("SCRIPT");
            KeyColumn("ID_PAKETA");

            Map(x => x.scriptingJezik).Column("SCRIPTING_JEZIK");


            HasManyToMany(x => x.Pro)
             .Table("PROGRAMIRA")
             .ParentKeyColumn("ID_PAKETA")
             .ChildKeyColumn("JMBG")
             .Inverse()
             .Cascade.All();

            HasMany(x => x.Programeri).KeyColumn("JMBG").LazyLoad().Cascade.All().Inverse();
        }
    }
}
