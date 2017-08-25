using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Repository
{
    public class Imena
    {
        public ObjectId Id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string Adresa { get; set; }
        public string Broj { get; set; }
        public MongoDBRef Imenik { get; set; }

    }
}
