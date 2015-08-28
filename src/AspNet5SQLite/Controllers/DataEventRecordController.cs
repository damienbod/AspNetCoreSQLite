using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AspNet5SQLite.Controllers
{
    using AspNet5SQLite.Model;

    [Route("api/[controller]")]
    public class DataEventRecordsController : Controller
    {
        private readonly DataEventRecordContext _context;

        public DataEventRecordsController(DataEventRecordContext context)
        {
            _context = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _context.DataEventRecords.Add(new DataEventRecord {Id ="1", Description = "test", Name="name", Timestamp= DateTime.UtcNow});
            _context.SaveChanges();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
