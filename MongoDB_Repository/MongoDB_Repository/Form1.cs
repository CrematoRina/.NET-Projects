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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Rina");
            
            var collection = database.GetCollection<Imena>("Imena");

            MongoCursor<Imena> imena = collection.FindAll();

            foreach (Imena i in imena.ToArray<Imena>())
            {
                MessageBox.Show(i.ime);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DodajIme dodajForm = new DodajIme();
            dodajForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AzurirajBroj azurForm = new AzurirajBroj();
            azurForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ObrisiIme obrisiForm = new ObrisiIme();
            obrisiForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SortList listForm = new SortList();
            listForm.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Rina");

            var imenikCollection = db.GetCollection<Imenik>("Imenik");

            foreach (Imenik s in imenikCollection.FindAll())
            {
                foreach (MongoDBRef imRef in s.Imena.ToList())
                {
                    Imena im = db.FetchDBRefAs<Imena>(imRef);
                    MessageBox.Show(im.ime + " " + im.prezime + " Vlasnik imenika: " + s.VImenik);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Rina");

            var imenikCollection = db.GetCollection<Imenik>("Imenik");
            imenikCollection.RemoveAll();

            var imena = db.GetCollection<Imena>("Imena");
            imena.RemoveAll();

        }
    }
}
