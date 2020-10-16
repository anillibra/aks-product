using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [EnableCors("CORS")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Product101", "Product102", "Product103", "ProductFromCICD" };
        }

        [HttpGet]
        [Route("healthz")]
        public ActionResult<IEnumerable<string>> healthz()
        {
            
            return new string[] { "I am running" };
        }
    }
}