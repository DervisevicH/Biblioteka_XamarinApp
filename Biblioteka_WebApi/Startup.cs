using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Biblioteka_WebApi.Database;
using Biblioteka_WebApi.Security;
using Biblioteka_WebApi.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Biblioteka_WebApi
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddAutoMapper(typeof(Startup));
            //Configure connection string
            services.AddScoped<IClanarineService, ClanarineService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IAutoriService, AutoriService>();
            services.AddScoped<IKnjigeService, KnjigeService>();
            services.AddScoped<IZanroviService, ZanroviService>();
            services.AddScoped<IRezervacijeService, RezervacijeService>();
            services.AddScoped<IRecenzijeService, RecenzijeService>();
            services.AddScoped<IOcjeneService, OcjeneService>();
            services.AddScoped<IObavijestiService, ObavijestiService>();

            services.AddAuthentication("BasicAuthentication")
              .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            var connection = @"Server=.;Database=eLibrary;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<eLibraryContext>(options => options.UseSqlServer(connection));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseAuthentication();
            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
