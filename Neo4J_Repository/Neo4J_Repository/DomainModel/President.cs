﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository.DomainModel
{
    class President
    {
        public String id { get; set; }
        public String name { get; set; }
        public int votes { get; set; }
    }
}
