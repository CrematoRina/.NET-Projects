using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class NarudzbinaMap : ClassMap<Narudzbina>
    {
        public NarudzbinaMap()
        {
            Table("NARUDZBINA");

            //Id(x => x.idNarudzbine, "ID_NARUDZBINE").GeneratedBy.TriggerIdentity();
             
            Map(x => x.idNarudzbine).Column("ID_NARUDZBINE");
            Map(x => x.trajanje).Column("TRAJANJE");
            Map(x => x.datumKupovine).Column("DATUM_KUPOVINE");

            References(x => x.idPaket).Column("ID_PAKETA");

            HasManyToMany(x => x.Ekonomisti)
              .Table("PRIMA")
              .ParentKeyColumn("ID_NARUDZBINE")
              .ChildKeyColumn("JMBG")
              .Inverse()
              .Cascade.All();

            HasManyToMany(x => x.Korisnici)
              .Table("NARUCIO")
              .ParentKeyColumn("ID_NARUDZBINE")
              .ChildKeyColumn("ID")
              .Inverse()
              .Cascade.All();

        }
    }
}
