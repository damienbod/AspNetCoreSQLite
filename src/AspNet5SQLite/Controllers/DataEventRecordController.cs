namespace AspNet5SQLite.Controllers
{
    using System.Collections.Generic;

    using AspNet5SQLite.Model;
    using AspNet5SQLite.Repositories;

    using Microsoft.AspNet.Mvc;

    [Route("api/[controller]")]
    public class DataEventRecordsController : Controller
    {
        private readonly IDataEventRecordRepository _dataEventRecordResporitory;

        public DataEventRecordsController(IDataEventRecordRepository dataEventRecordResporitory)
        {
            _dataEventRecordResporitory = dataEventRecordResporitory;
        }

        [HttpGet]
        public IEnumerable<DataEventRecord> Get()
        {
            return _dataEventRecordResporitory.GetAll();
        }

        [HttpGet("{id}")]
        public DataEventRecord Get(long id)
        {
            return _dataEventRecordResporitory.Get(id);
        }

        [HttpPost]
        public void Post([FromBody]DataEventRecord value)
        {
            _dataEventRecordResporitory.Post(value);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody]DataEventRecord value)
        {
            _dataEventRecordResporitory.Put(id, value);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _dataEventRecordResporitory.Delete(id);
        }
    }
}
