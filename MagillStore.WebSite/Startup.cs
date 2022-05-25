using MagillStore.WebSite.Models;
using MagillStore.WebSite.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MagillStore.WebSite
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
            services.AddRazorPages();
            services.AddTransient<JsonFileProductService>();
            services.AddTransient<JsonFileProductCategoryService>();
            services.AddTransient<DatabaseService>();
            services.AddControllers();
            services.AddServerSideBlazor();
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Products");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                //this is one way to map a REST Endpoint
                //here i use the MapGet() to tell it the list to send to the /categories endpoint
                // the list is serialized to JSOn
                endpoints.MapGet("/categories", (context) =>
                {
                    DatabaseService dbObject = new DatabaseService();
                    IEnumerable<ProductCategory> categories = dbObject.GetProductCategoryList();
                    var json = JsonSerializer.Serialize<IEnumerable<ProductCategory>>(categories);
                    return context.Response.WriteAsync(json);

                });

                // here is another way to do the REST endpoint
                // here i created a controller class (see the controllers folder), with a ProductsController
                // to make this work, I had to set up my Database class as a Service (see configure services above)
                //the name of the class before the "Controller" becomes the endpoint, so this will expose endpoint at /Products
                //controller class is more abstract and elegant, maybe less obvious
                endpoints.MapControllers();

                endpoints.MapBlazorHub();
            });
        }
    }
}
