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
using Dapper.FastCrud;
using Autofac;
using System.IO;
using System.Xml.XPath;
using Swashbuckle.AspNetCore.SwaggerGen;
using AutoMapper;
using NorthWind.API.Profiles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NorthWind.API.Helpers;
using NorthWind.API;

namespace NorthWind.API
{
    public class Startup
    {
        protected readonly IHostingEnvironment _env;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            _env = env;
            this.Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; private set; }

        // Configure is where you add middleware. This is called after
        // ConfigureContainer. You can use IApplicationBuilder.ApplicationServices
        // here if you need to resolve things from the container.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IServiceProvider serviceProvider)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            // app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            // app.UseSwaggerUI(c =>
            // {
                // c.SwaggerEndpoint("/swagger/v1/swagger.json", "NorthWind API V1");
            // });
            //
            OrmConfiguration.DefaultDialect = SqlDialect.PostgreSql;
            //
            // loggerFactory.AddConsole(this.Configuration.GetSection("Logging"));
            // loggerFactory.AddDebug();

            // app.UseResponseCompression();

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            app.UseAuthentication();
            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
            app.UseMvc();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            AutofacRegistrar.Register(builder);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            OrmConfiguration.DefaultDialect = SqlDialect.PostgreSql;
            //services.AddSingleton<IConfiguration>(Configuration);
            //services.AddOptions();
            services.Configure<DatabaseOptions>(Configuration.GetSection("ConnectionStrings"));
            services.Configure<ServiceOptions>(Configuration.GetSection("ServiceUrls"));
            services.Configure<ConvertOptions>(Configuration.GetSection("ConvertRef"));
            services.Configure<LevelOptions>(Configuration.GetSection("LevelConfig"));


            services.AddCors();

            services.AddLogging(options =>
            {
                options.AddDebug();
                options.AddConsole(console =>
                {
                    console.IncludeScopes = true;
                });
            });

            services.AddMvcCore()
                    .AddApiExplorer()
                    .AddAuthorization()
                    .AddJsonOptions(options =>
                    {
                        options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                        // options.SerializerSettings.TypeNameHandling = TypeNameHandling.Objects;
                        options.SerializerSettings.MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead;
                        options.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
                        // options.SerializerSettings.SerializationBinder = new KnownTypesBinder() { KnownTypes = new List<Type>() { typeof(Layer) } };
                    })
                    .AddJsonFormatters();

            // Register the Swagger generator, defining 1 or more Swagger documents
            // services.AddSwaggerGen(c =>
            // {
                // c.DescribeAllEnumsAsStrings();
                // c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "NorthWind API", Version = "v1" });
                // c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{_env.ApplicationName}.xml"));
            // });

            services.AddAuthentication("Bearer")
                    .AddIdentityServerAuthentication(options =>
                    {
                        options.Authority = Configuration["ServiceUrls:IdentityServiceUrl"];
                        // options.Authority = "http://127.0.0.1:2277";
                        options.RequireHttpsMetadata = false;
                        options.ApiName = "NorthWind.API";
                    });

            // services.AddAutoMapper();
            services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
            }).CreateMapper());
        }
    }
}
