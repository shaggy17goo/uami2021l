using DoctorsApplicationMicroservice.Web.Application.Commands.Commands;

namespace DoctorsApplicationMicroservice.Web
{
    using Application.Commands.Queries;
    using Application.DataServiceClients;
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DoctorsApplicationMicroservice.Web", Version = "v1" });
            });
            services.AddHttpClient();
            services.AddTransient<IDoctorsApplicationQueriesHandler, DoctorsApplicationQueriesQueryHandler>();
            
            services.AddTransient<IPatientServiceClient, PatientServiceClient>();
            services.AddTransient<IDoctorServiceClient, DoctorServiceClient>();
            services.AddTransient<IAppointmentServiceClient, AppointmentServiceClient>();

            services.AddTransient<ICommandHandler<AddPatientCommand>, DoctorsApplicationCommandsHandler>();
            services.AddTransient<ICommandHandler<AddAppointmentCommand>, DoctorsApplicationCommandsHandler>();
            services.AddTransient<ICommandHandler<DeleteAppointmentCommand>, DoctorsApplicationCommandsHandler>();
            services.AddTransient<ICommandHandler<DeleteDoctorCommand>, DoctorsApplicationCommandsHandler>();
            services.AddTransient<ICommandHandler<DeletePatientCommand>, DoctorsApplicationCommandsHandler>();


            
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LaboratoriesInventory.Web v1"));
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
