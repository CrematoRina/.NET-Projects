using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebHosting.Entiteti;
using FluentNHibernate.Mapping;

namespace WebHosting.Mapiranja
{
    class LinuxMap : SubclassMap<Linux>
    {
        public LinuxMap()
        {
            Table("LINUX");
            KeyColumn("IP");
        }
    }
}
