﻿using ElMuroVenezolano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElMuroVenezolano.Controllers
{
    public class ContactController : ApiController
    {
        DataModel _context = new DataModel();
        // GET: api/Contact
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Contact/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Contact
        public void Post([FromBody]Contact contact)
        {

        }

        // PUT: api/Contact/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Contact/5
        public void Delete(int id)
        {
        }
    }
}
