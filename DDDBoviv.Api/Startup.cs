
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDBovivet.Domain.Reproducao.Repositories;
using DDDBovivet.Infra.Contexts;
using DDDBovivet.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DDDBoviv.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddScoped<DDDBovivet_ReproducaoAlternativo, DDDBovivet_ReproducaoAlternativo>();

            services.AddTransient<ICustomerRepository, CustomerRepositoryPersistence2>();
            
            services.AddMvc();
        }

      
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