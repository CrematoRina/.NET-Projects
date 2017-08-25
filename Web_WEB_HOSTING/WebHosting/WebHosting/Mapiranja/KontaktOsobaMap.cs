using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class KontaktOsobaMap : ClassMap<KontakOsoba>
    {
        public KontaktOsobaMap()
        {
            Table("KONTAKT_OSOBA");

            //Id(x => x.idosobe, "ID_OSOBE").GeneratedBy.TriggerIdentity();

            Map(x => x.idOsobe).Column("ID_OSOBE");
            Map(x => x.imeO).Column("IMEO");
            Map(x => x.prezimeO).Column("PREZIMEO");
            Map(x => x.telefon).Column("TELEFON");
        }
    }
}
