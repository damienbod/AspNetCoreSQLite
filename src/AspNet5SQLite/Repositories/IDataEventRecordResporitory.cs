namespace AspNet5SQLite.Repositories
{
    using System.Collections.Generic;

    using AspNet5SQLite.Model;

    using Microsoft.AspNet.Mvc;

    public interface IDataEventRecordResporitory
    {
        void Delete(string id);
        DataEventRecord Get(string id);
        List<DataEventRecord> GetAll();
        void Post(DataEventRecord dataEventRecord);
        void Put(string id, [FromBody] DataEventRecord dataEventRecord);
    }
}