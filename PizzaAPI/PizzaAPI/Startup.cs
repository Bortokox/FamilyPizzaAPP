using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using PizzaAPI.Helpers;
using PizzaAPI.Models;
using PizzaAPI.Repositories;
using System.Net;

namespace PizzaAPI
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddScoped<IPizzaRepositorie, PizzaRepositorie>();
            services.AddScoped<ICommentsRepository, CommentsRepository>();
            services.AddDbContext<DataContext>(options => options.UseSqlite(_config.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            services.AddCors();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PizzaAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaAPI v1"));
            }
            else
            {
                app.UseExceptionHandler(
             builder =>
             {
                 builder.Run(
                 async context =>
                 {
                     context.Response.StatusCode =
                     (int)HttpStatusCode.InternalServerError;
                     context.Response.ContentType =
                     "application/json";
                     var exception =
                     context.Features.Get
                     <IExceptionHandlerFeature>();
                     if (exception != null)
                     {
                         var error = new ErrorDetails()
                         {
                             StackTrace =
                             exception.Error.StackTrace,
                             Message = exception.Error.Message
                         };
                         var errObj =
                         JsonConvert.SerializeObject(error);
                         await context.Response.WriteAsync
                         (errObj).ConfigureAwait(false);
                     }
                 });
             });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}