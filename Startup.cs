using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Npgsql.PostgresTypes;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Stemming.Models;
using Stemming.Models.Interface;
using Stemming.Models.Repository;

namespace Stemming
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var pgsqlConnectionString = Configuration.GetConnectionString("StemmingConnectionString");
            
            services.AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql(pgsqlConnectionString));
            
            services.AddMvc();
            services.AddScoped<IDataRepostory<RootModel, long>, RootRepository>();
            services.AddScoped<IDataRepostory<StopWordModel, long>, StopwordRepository>();
            services.AddScoped<IDataRepostory<InputModel, long>, InputRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
