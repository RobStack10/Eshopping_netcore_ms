using System;
namespace Catalog.API
{
    public class Startup
    {

        public IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public void ConfiguraServices(IServiceCollection services)
        {

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(configure =>
            {
                configure.MapControllers();
            });

        }

    }
}

