namespace AspNet5SQLite.Controllers
{
    using System.Collections.Generic;

    using AspNet5SQLite.Model;
    using AspNet5SQLite.Repositories;

    using Microsoft.AspNet.Mvc;

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
        public void Post([FromBody]DataEventRecord value)
        {
            _dataEventRecordResporitory.Post(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]DataEventRecord value)
        {
            _dataEventRecordResporitory.Put(id, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _dataEventRecordResporitory.Delete(id);
        }
    }
}
