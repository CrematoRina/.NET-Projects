using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class TehnickaStrukaMap : SubclassMap<TehnickaStruka>
    {
        public TehnickaStrukaMap()
        {
            Table("TEHNICKA_STRUKA");
            KeyColumn("JMBG");
        }
    }
}
