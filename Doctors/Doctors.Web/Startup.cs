namespace Doctors.Web
{
    using Doctors.Domain.DoctorAggregate;
    using Doctors.Infrastructure;
    using Doctors.Web.Application;
    using Doctors.Web.Application.Commands;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.OpenApi.Models;

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
           
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Doctors.Web", Version = "v1" });
            });

            /**
             * A place where we decide what are used for added interfaces
             * The following three lines in a moment, when we define a constructor which takes as a parameter one of following interfaces,
             * framework will add to this an indicated implementation
             **/
            services.AddSingleton<IDoctorsRepository, DoctorsRepository>();
            services.AddTransient<IDoctorQueriesHandler, DoctorQueriesHandler>();
            services.AddTransient<ICommandHandler<AddDoctorCommand>, DoctorsCommandsHandler>();
            services.AddTransient<ICommandHandler<DeleteDoctorCommand>, DoctorsCommandsHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Laboratories.Web v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
