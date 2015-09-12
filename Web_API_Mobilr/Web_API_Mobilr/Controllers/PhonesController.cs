using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_API_Mobilr.Models;

namespace Web_API_Mobilr.Controllers
{
    public class PhonesController : ApiController
    {
        static readonly Dictionary<int, Phone> Phones = new Dictionary<int, Phone>();
        static int nextId = 0;

        static PhonesController()
        {
            Phones.Add(++nextId, new Phone { Id = nextId, Manufacturer = "Nokia", Name = "Lumia 920", Color = "Yellow" });
            Phones.Add(++nextId, new Phone { Id = nextId, Manufacturer = "HTC", Name = "8X", Color = "Blue" });
            Phones.Add(++nextId, new Phone { Id = nextId, Manufacturer = "Nokia", Name = "Lumia 820", Color = "Purple" });
            Phones.Add(++nextId, new Phone { Id = nextId, Manufacturer = "HTC", Name = "8S", Color = "Red" });
            Phones.Add(++nextId, new Phone { Id = nextId, Manufacturer = "Nokia", Name = "Lumia 520", Color = "White" });
            Phones.Add(++nextId, new Phone { Id = nextId, Manufacturer = "Nokia", Name = "Lumia 620", Color = "Green" });
        }

        // GET api/Phones
        public IEnumerable<Phone> Get()
        {
            return Phones.Values;
        }

        // GET api/Phones?manufacturer=value
        public IEnumerable<Phone> Get(string manufacturer)
        {
            return Phones.Values.Where(p => p.Manufacturer == manufacturer);
        }

        // GET api/Phones/id
        public Phone Get(int id)
        {
            return Phones[id];
        }

        // POST api/Phones
        public HttpResponseMessage Post([FromBody]Phone value)
        {
            value.Id = ++nextId;
            Phones.Add(value.Id, value);
            var response = Request.CreateResponse<Phone>(HttpStatusCode.Created, value);
            string uri = Url.Link("DefaultApi", new { id = value.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // PUT api/Phones/id
        public void Put(int id, [FromBody]Phone value)
        {
            value.Id = id;
            Phones[id] = value;
        }

        // DELETE api/Phones/id
        public void Delete(int id)
        {
            Phones.Remove(id);
        }
    }
}