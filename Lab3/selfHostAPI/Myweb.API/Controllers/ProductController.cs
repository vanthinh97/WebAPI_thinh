using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Myweb.API.Models;

namespace Myweb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {

        }
        [Route("")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Neo()
        {
            List<Product> p = new List<Product>() { 
                new Product{Id = 1, ProductName = "Tshirt", Description="áo chất lượng"},
                 new Product{Id = 2, ProductName = "Tsshirt", Description="áo chất slượng"},
                new Product{Id = 3, ProductName = "Tsshirt", Description="áo chấts lượng"}
            };
            return p;
        }

        [Route("update")]
        [HttpPost]
        public async Task<ActionResult<string>> update(Product p)
        {
            //Product pa = db.products.find(p.id);
            // pa.ProductNảme = p.name;
            //... db.savechange();
            return "Bạn đã update thành công";
        }
    }
}
