namespace AspNet5SQLite.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using AspNet5SQLite.Model;

    using Microsoft.AspNet.Mvc;
    using Microsoft.Framework.Logging;

    public class DataEventRecordResporitory : IDataEventRecordResporitory
    {
        private readonly DataEventRecordContext _context;

        private readonly ILogger _logger;

        public DataEventRecordResporitory(DataEventRecordContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("IDataEventRecordResporitory");          
        }

        public List<DataEventRecord> GetAll()
        {
            _logger.LogCritical("Getting a the existing records");
            return _context.DataEventRecords.ToList();
        }

        public DataEventRecord Get(string id)
        {
            return _context.DataEventRecords.First(t => t.Id == id);
        }

        [HttpPost]
        public void Post(DataEventRecord dataEventRecord )
        {
            _context.DataEventRecords.Add(dataEventRecord);
            _context.SaveChanges();
        }

        public void Put(string id, [FromBody]DataEventRecord dataEventRecord)
        {
            _context.DataEventRecords.Update(dataEventRecord);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var entity = _context.DataEventRecords.First(t => t.Id == id);
            _context.DataEventRecords.Remove(entity);
            _context.SaveChanges();
        }
    }
}
