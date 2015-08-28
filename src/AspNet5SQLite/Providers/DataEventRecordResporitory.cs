namespace AspNet5SQLite.Providers
{
    using System.Collections.Generic;
    using System.Linq;

    using AspNet5SQLite.Model;

    using Microsoft.AspNet.Mvc;

    public class DataEventRecordResporitory
    {
        private readonly DataEventRecordContext _context;

        public DataEventRecordResporitory(DataEventRecordContext context)
        {
            _context = context;
        }

        public List<DataEventRecord> GetAll()
        {
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

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]DataEventRecord dataEventRecord)
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
