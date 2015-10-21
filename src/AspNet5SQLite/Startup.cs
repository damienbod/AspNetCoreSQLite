using AspNet5SQLite.Model;
using AspNet5SQLite.Repositories;

using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Data.Entity;
using Microsoft.Dnx.Runtime;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;

namespace AspNet5SQLite
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }

        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(appEnv.ApplicationBasePath)
                .AddJsonFile("config.json");
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration["Production:SqliteConnectionString"];

            services.AddEntityFramework()
                .AddSqlite()
                .AddDbContext<DataEventRecordContext>(options => options.UseSqlite(connection));

            services.AddMvc();
            services.AddScoped<IDataEventRecordRepository, DataEventRecordRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.MinimumLevel = LogLevel.Information;
            loggerFactory.AddConsole();
            loggerFactory.AddDebug();

            app.UseIISPlatformHandler();

            app.UseExceptionHandler("/Home/Error");         

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
