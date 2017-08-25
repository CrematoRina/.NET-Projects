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
    public class PaketiController : Controller
    {
        public IEnumerable<Paketi> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<Paketi> paketi = provider.GetPakete();

            return paketi;
        }
        public Paketi Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetPaket(id);
        }


        public int Post([FromBody]Paketi v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddPaket(v);
        }


        public void Put(int id, [FromBody]Paketi v)
        {
        }


        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemovePaket(id);
        }
    }
}
