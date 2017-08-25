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
    public class FizickaController : ApiController
    {
        public IEnumerable<Fizicka> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<Fizicka> fiz = provider.GetFizicka();

            return fiz;
        }
        public Fizicka Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetFizicko(id);
        }


        public int Post([FromBody]Fizicka v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddFizicko(v);
        }


        public void Put(int id, [FromBody]Fizicka v)
        {
        }


        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveFizicko(id);
        }

    }
}
