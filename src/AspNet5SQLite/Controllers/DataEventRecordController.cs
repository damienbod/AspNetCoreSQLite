using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AspNet5SQLite.Controllers
{
    using AspNet5SQLite.Model;
    using AspNet5SQLite.Providers;

    [Route("api/[controller]")]
    public class DataEventRecordsController : Controller
    {
        private readonly IDataEventRecordResporitory _dataEventRecordResporitory;

        public DataEventRecordsController(IDataEventRecordResporitory dataEventRecordResporitory)
        {
            _dataEventRecordResporitory = dataEventRecordResporitory;
        }

        [HttpGet]
        public IEnumerable<DataEventRecord> Get()
        {
            return _dataEventRecordResporitory.GetAll();
        }

        [HttpGet("{id}")]
        public DataEventRecord Get(string id)
        {
            return _dataEventRecordResporitory.Get(id);
        }

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
