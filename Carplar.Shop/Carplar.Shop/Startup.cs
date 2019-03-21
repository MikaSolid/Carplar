using Carplar.Shop.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Carplar.Shop
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddDbContext<Db>(options => 
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.Run(async (context) => await context.Response.WriteAsync(string.Empty));
        }
    }
}