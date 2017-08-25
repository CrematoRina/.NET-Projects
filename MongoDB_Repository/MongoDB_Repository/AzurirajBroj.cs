using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace MongoDB_Repository
{
    public partial class AzurirajBroj : Form
    {
        public AzurirajBroj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Rina");

            var collection = db.GetCollection<Imena>("Imena");

            string ime = textBox1.Text;
            string nbroj = textBox2.Text;

            var query = Query.EQ("ime", ime);
            var update = MongoDB.Driver.Builders.Update.Set("Broj", BsonValue.Create(nbroj));

            collection.Update(query, update);

            this.Close();
        }
    }
}
