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
    public class ZaposleniController : ApiController
    {
        public IEnumerable<Zaposleni> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<Zaposleni> zap = provider.GetZaposleni();

            return zap;
        }
        public Zaposleni Get(int jmbg)
        {
            DataProvider provider = new DataProvider();

            return provider.GetZaposlenog(jmbg);
        }


        public int Post([FromBody]Zaposleni v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddZaposlenog(v);
        }


        public void Put(int id, [FromBody]Zaposleni v)
        {
        }


        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveZaposlenog(id);
        }
    }
}
