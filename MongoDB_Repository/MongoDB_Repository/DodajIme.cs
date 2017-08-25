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
    public partial class DodajIme : Form
    {
        public DodajIme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Rina");

            var collection = db.GetCollection<Imena>("Imena");
            var imenikCollection = db.GetCollection<Imenik>("Imenik");

           

            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string adresa = textBox3.Text;
            string broj = textBox4.Text;
            string Vimenik = textBox5.Text;

            Imenik sek = new Imenik { VImenik = Vimenik };
            imenikCollection.Insert(sek);

            Imena i = new Imena { ime = ime, prezime = prezime, Adresa = adresa, Broj = broj };
           

            collection.Insert(i);

            MessageBox.Show("Sacuvano:\n" + "Ime: " +  i.ime + "\n" + "Broj: " +i.Broj);

            
             sek.Imena.Add(new MongoDBRef("imena", i.Id));

             i.Imenik = new MongoDBRef("imenik", sek.Id);

                collection.Save(i);
                imenikCollection.Save(sek);

                this.Close();
        }
    }
}
