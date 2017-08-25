using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace MongoDB_Repository
{
    public partial class ObrisiIme : Form
    {
        public ObrisiIme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Rina");

            var collection = db.GetCollection<Imena>("Imena");

            string oime = textBox1.Text;

            var query = Query.EQ("ime", oime);

            collection.Remove(query);

            this.Close();
        }

        private void ObrisiIme_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Rina");

            var collection = db.GetCollection<Imena>("Imena");

            foreach (Imena r in collection.FindAll())
            {
                listBox1.Items.Add("\n" + r.ime + "\t" + r.prezime + "\t" + r.Broj + "\n");
            }
        }
    }
}
