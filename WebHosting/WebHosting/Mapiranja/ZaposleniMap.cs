using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class ZaposleniMap : ClassMap<Zaposleni>
    {
        public ZaposleniMap()
        {
            Table("ZAPOSLENI");

            Id(x => x.jmbg).Column("JMBG");

            Map(x => x.ime).Column("IME");
            Map(x => x.ImeOca).Column("IME_OCA");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.GodinaRodjenja).Column("GODINA_RODJENJA");
            Map(x => x.DatumZaposlenja).Column("DATUM_ZAPOSLENJA");
            Map(x => x.RadniStaz).Column("RADNI_STAZ");

        }
    }
}
