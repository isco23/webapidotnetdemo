using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebApiDotNetDemo.Controllers
{
    public class ProductsController : ApiController
    {
        public IEnumerable<Product> Get()
        {
            using(DemoEntities demo = new DemoEntities())
            {
                return demo.Products.ToList();
            }
        }

        public Product Get(int Id)
        {
            using (DemoEntities demo = new DemoEntities())
            {
                return demo.Products.FirstOrDefault(x => x.Id == Id);
            }
        }
    }
}
