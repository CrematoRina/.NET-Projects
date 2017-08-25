using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neo4J_Repository.DomainModel
{
    public class Voters
    {
        public String id { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String birthplace { get; set; }
        public String birthday { get; set; }
        public String voteFor { get; set; }

        public DateTime getBirthday()
        {
            if(this.birthday == null) return new DateTime();

            long timestamp = Int64.Parse(this.birthday);
            DateTime startDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return startDateTime.AddMilliseconds(timestamp).ToLocalTime();
        }

    }
}
