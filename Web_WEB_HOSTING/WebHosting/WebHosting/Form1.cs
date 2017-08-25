using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using WebHosting.Entiteti;

namespace WebHosting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                WebHosting.Entiteti.Zaposleni z = s.Load<WebHosting.Entiteti.Zaposleni>(1602993733514);

                MessageBox.Show(z.ime);
                MessageBox.Show(z.Prezime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Zaposleni z = new Entiteti.Zaposleni();
                z.jmbg = 1234512345;
                z.ime = "Goran";
                z.ImeOca = "Janko";
                z.Prezime = "ivic";
                z.GodinaRodjenja = new DateTime(1991, 6, 10);
                z.DatumZaposlenja = new DateTime(2011, 6, 10);
                z.RadniStaz = 4;


                s.Save(z);
                

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Fizicka k = new Fizicka();
                


                k.osoba = 2;
                k.id = 10;
                k.adresa = "Trg 14";
                k.imeK = "Marko";
                k.prezimeK = "Mikic";
                k.jmbg = 12454634;

                s.Save(k);
                s.Close();
            }


            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             try
            {
                ISession s = DataLayer.GetSession();

                Korisnici k1 = s.Load<Korisnici>(3);

                foreach (Entiteti.Narudzbina n1 in k1.NarucioNarudzbinu)
                {
                    MessageBox.Show(n1.trajanje.ToString());
                }
                 

                Entiteti.Narudzbina n2 = s.Load<Entiteti.Narudzbina>(1);

                foreach (Korisnici k2 in n2.Korisnici)
                {
                    MessageBox.Show(k2.adresa);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from ZAPOSLENI");

                IList<Zaposleni> z = q.List<Zaposleni>();

                foreach (Zaposleni zp in z)
                {
                    MessageBox.Show(zp.ime+ " " + zp.Prezime + " " + zp.RadniStaz);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from NARUDZBINA as n where n.ID_PAKETA = 4");

                IList<Narudzbina> n = q.List<Narudzbina>();

                foreach (Narudzbina nr in n)
                {
                    MessageBox.Show(nr.datumKupovine.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                IQuery q = s.CreateQuery("from ZAPOSLENI as z where z.RADNI_STAZ > ? ");
                q.SetInt32(0, 10);

                IList<Zaposleni> zap = q.List<Zaposleni>();

                foreach (Zaposleni z in zap)
                {
                    MessageBox.Show(z.ime + " " + z.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(1602993733514);

                
                s.Close();

                
                z.RadniStaz = 10;

                
                ISession s1 = DataLayer.GetSession();

                
                s1.Update(z);

                s1.Flush();
                s1.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KontakOsoba k = s.Load<KontakOsoba>(3);

        
                s.Delete(k);
                

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KontakOsoba k = s.Load<KontakOsoba>(1);

                ITransaction t = s.BeginTransaction();

                s.Delete(k);

                //t.Commit();
                t.Rollback();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        }
}
