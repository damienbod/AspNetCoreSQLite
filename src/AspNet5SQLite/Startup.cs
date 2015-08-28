namespace AspNet5SQLite
{
    using AspNet5SQLite.Model;
    using AspNet5SQLite.Providers;

    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Hosting;
    using Microsoft.Data.Entity;
    using Microsoft.Framework.Configuration;
    using Microsoft.Framework.DependencyInjection;
    using Microsoft.Framework.Runtime;

    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            _configuration = new ConfigurationBuilder(appEnv.ApplicationBasePath)
             .AddEnvironmentVariables()
             .AddJsonFile("config.json")
             .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connection = _configuration.Get("Production:SqliteConnectionString");

            services.AddEntityFramework()
                .AddSqlite()
                .AddDbContext<DataEventRecordContext>(options => options.UseSqlite(connection));

            services.AddMvc();
            services.AddScoped<IDataEventRecordResporitory, DataEventRecordResporitory>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
