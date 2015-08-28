using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using AspNet5SQLite.Model;

namespace AspNet5SQLiteMigrations
{
    [ContextType(typeof(DataEventRecordContext))]
    partial class DataEventRecordContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13752");

            builder.Entity("AspNet5SQLite.Model.DataEventRecord", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Timestamp");

                    b.Key("Id");
                });
        }
    }
}
