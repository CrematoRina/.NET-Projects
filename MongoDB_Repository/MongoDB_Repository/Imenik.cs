using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Repository
{
    public class Imenik
    {
        public ObjectId Id { get; set; }
        public string VImenik { get; set; }
        public List<MongoDBRef> Imena { get; set; }

        public Imenik()
        {
            Imena = new List<MongoDBRef>();
        }
    }
}
