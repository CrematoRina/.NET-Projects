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
    public class PravnaController : Controller
    {
        public IEnumerable<Pravna> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<Pravna> prav = provider.GetPravna();

            return prav;
        }
        public Pravna Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetPravno(id);
        }


        public int Post([FromBody]Pravna v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddPravno(v);
        }


        public void Put(int id, [FromBody]Pravna v)
        {
        }


        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemovePravno(id);
        }
    }
}
