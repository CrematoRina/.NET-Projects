using NHibernate;
using WebHosting.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;

namespace WebHosting
{
    public class DataProvider
    {
        public IEnumerable<Zaposleni> GetZaposleni()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Zaposleni> zap = s.Query<Zaposleni>()

                                                .Select(p => p);
            return zap;
        }

        public Zaposleni GetZaposlenog(int jmbg)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Zaposleni>()
                .Where(v => v.jmbg == jmbg).Select(p => p).FirstOrDefault();
        }

        public int AddZaposlenog(Zaposleni v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveZaposlenog(int jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni v = s.Load<Zaposleni>(jmbg);

                s.Delete(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }
        public IEnumerable<Fizicka> GetFizicka()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Fizicka> fiz = s.Query<Fizicka>()

                                                .Select(p => p);
            return fiz;
        }

        public Fizicka GetFizicko(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Fizicka>()
                .Where(v => v.id == id).Select(p => p).FirstOrDefault();
        }

        public int AddFizicko(Fizicka v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveFizicko(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Fizicka v = s.Load<Fizicka>(id);

                s.Delete(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }
        public IEnumerable<Pravna> GetPravna()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Pravna> prav = s.Query<Pravna>()

                                                .Select(p => p);
            return prav;
        }

        public Pravna GetPravno(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Pravna>()
                .Where(v => v.id == id).Select(p => p).FirstOrDefault();
        }

        public int AddPravno(Pravna v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemovePravno(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pravna v = s.Load<Pravna>(id);

                s.Delete(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }
        public IEnumerable<Paketi> GetPakete()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Paketi> paketi = s.Query<Paketi>()

                                                .Select(p => p);
            return paketi;
        }

        public Paketi GetPaket(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Paketi>()
                .Where(v => v.idPaketa == id).Select(p => p).FirstOrDefault();
        }

        public int AddPaket(Paketi v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemovePaket(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Paketi v = s.Load<Paketi>(id);

                s.Delete(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }
        public IEnumerable<Narudzbina> GetNarudzbine()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Narudzbina> nar = s.Query<Narudzbina>()

                                                .Select(p => p);
            return nar;
        }

        public Narudzbina GetNarudzbinu(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Narudzbina>()
                .Where(v => v.idNarudzbine == id).Select(p => p).FirstOrDefault();
        }

        public int AddNarudzbinu(Narudzbina v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveNarudzbinu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Narudzbina v = s.Load<Narudzbina>(id);

                s.Delete(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }
    }
}
