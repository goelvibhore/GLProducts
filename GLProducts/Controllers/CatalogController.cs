using GLProducts.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GLProducts.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class CatalogController : ControllerBase
    {
        // GET: api/<CatalogController>
        [HttpGet]
        public IEnumerable<Catalog> Get()
        {
            List<Catalog> catalogs = new List<Catalog>();
            using (GLContext context = new GLContext())
            {
                catalogs = context.Catalogs.ToList();
            }
            return catalogs;
        }

        // GET api/<CatalogController>/5
        [HttpGet("{CatalagName}")]
        public Catalog Get(string catalogName)
        {
            Catalog catalog = null;
            using (GLContext context = new GLContext())
            {
                catalog = context.Catalogs.FirstOrDefault(x => x.CatalagName == catalogName);
            }

            return (catalog == null) ? new Catalog() : catalog;
        }

        // POST api/<CatalogController>
        [HttpPost]
        public void Post([FromBody] Catalog catalog)
        {
            using (GLContext context = new GLContext())
            {
                context.Catalogs.Add(catalog);
                context.SaveChanges();
            }
        }

        // PUT api/<CatalogController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CatalogController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
