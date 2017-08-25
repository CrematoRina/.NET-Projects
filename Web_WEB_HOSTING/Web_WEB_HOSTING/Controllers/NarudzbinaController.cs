using WebHosting;
using WebHosting.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Web_WEB_HOSTING.Controllers
{
    public class NarudzbinaController : Controller
    {
        public IEnumerable<Narudzbina> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<Narudzbina> nar = provider.GetNarudzbine();

            return nar;
        }
        public Narudzbina Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetNarudzbinu(id);
        }


        public int Post([FromBody]Narudzbina v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddNarudzbinu(v);
        }


        public void Put(int id, [FromBody]Narudzbina v)
        {
        }


        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveNarudzbinu(id);
        }
    }
}
