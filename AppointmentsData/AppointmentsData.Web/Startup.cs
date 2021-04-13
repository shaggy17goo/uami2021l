namespace AppointmentsData.Web
{
    using AppointmentsData.Domain;
    using Domain.PatientAggregate;
    using AppointmentsData.Infrastructure.Repositories;
    using AppointmentsData.Web.Application.Queries;
    using AppointmentsData.Web.Application.Commands;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.HttpsPolicy;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Microsoft.OpenApi.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Patients.Web", Version = "v1" });
            });

            //Miejsce, w którym określamy co ma się kryć za poszczególnymi interfejsami.
            //Poniższe trzy linijki sprawią, że kiedy zdefiniujemy kontruktor przyjmujący jako parametr jeden z poniższych interfejsów
            //framework automatycznie "wstzyknie" do niego wskazaną przez nas implementację
            services.AddSingleton<IAppointmentsRepository, AppointmentsRepository>();
            services.AddTransient<IAppointmentsQueriesHandler, AppointmentsQueriesHandler>();
            services.AddTransient<ICommandHandler<AddAppointmentCommand>, PatientsCommandsHandler>();
            services.AddTransient<ICommandHandler<DeleteAppointmentCommand>, PatientsCommandsHandler>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Project.Web v1"));
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
