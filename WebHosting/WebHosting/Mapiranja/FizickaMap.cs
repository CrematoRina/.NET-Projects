using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class FizickaMap : SubclassMap<Fizicka>
    {
        public FizickaMap()
        {
            Table("FIZICKA");
            KeyColumn("ID");

            Map(x => x.jmbg).Column("JMBGK");
            Map(x => x.imeK).Column("IMEK");
            Map(x => x.prezimeK).Column("PREZIMEK");
        }
    }
}
