using ElMuroVenezolano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElMuroVenezolano.Controllers
{
    public class DeceasedController : ApiController
    {
        DataModel _context = new DataModel();
        // GET: api/Deceased
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Deceased/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Deceased
        public IHttpActionResult Post([FromBody]Deceased deceased)
        {
            try
            {
                _context.Deceased.Add(deceased);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {

                return null;
            }
            


        }

        // PUT: api/Deceased/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Deceased/5
        public void Delete(int id)
        {
        }
    }
}
