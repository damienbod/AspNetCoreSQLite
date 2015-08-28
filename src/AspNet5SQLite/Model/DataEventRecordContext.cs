namespace AspNet5SQLite.Model
{
    using Microsoft.Data.Entity;

    public class DataEventRecordContext : DbContext
    {
        public DbSet<DataEventRecord> DataEventRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        { 
            builder.UseSqlite("Data Source=./dataeventrecords.sqlite"); 
              
        } 
      
        protected override void OnModelCreating(ModelBuilder builder)
        { 
            builder.Entity<DataEventRecord>().Key(m => m.Id); 
            base.OnModelCreating(builder); 
        } 

    }
}