using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace AspNet5SQLiteMigrations
{
    public partial class testMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "DataEventRecord",
                columns: table => new
                {
                    Id = table.Column(type: "TEXT", nullable: false),
                    Description = table.Column(type: "TEXT", nullable: true),
                    Name = table.Column(type: "TEXT", nullable: true),
                    Timestamp = table.Column(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataEventRecord", x => x.Id);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("DataEventRecord");
        }
    }
}
