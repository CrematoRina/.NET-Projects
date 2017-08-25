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
             
            Id(x => x.idNarudzbine).Column("ID_NARUDZBINE");

            Map(x => x.trajanje).Column("TRAJANJE");
            Map(x => x.datumKupovine).Column("DATUM_KUPOVINE");
            //Map(x => x.datumKupovine).Column("ID_PAKET");

           References(x => x.idPaket).Column("ID_PAKETA");

            HasManyToMany(x => x.Ekonomist)
              .Table("PRIMA")
              .ParentKeyColumn("ID_NARUDZBINE")
              .ChildKeyColumn("JMBG")
              .Inverse()
              .Cascade.All();

            HasMany(x => x.Ekonomisti).KeyColumn("JMBG").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.Korisnik)
              .Table("NARUCIO")
              .ParentKeyColumn("ID_NARUDZBINE")
              .ChildKeyColumn("ID")
              .Inverse()
              .Cascade.All();

            HasMany(x => x.Korisnici).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
        }
    }
}
