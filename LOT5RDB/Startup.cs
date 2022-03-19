using LOT5RD.Equipment.Interfaces;
using LOT5RDB.Data.DBContexts;
using LOT5RDB.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddDbContext<EquipmentDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("LOT5RDB"));
            });
            services.AddScoped<IEquipmentRepository, SqlEquipmentRepo>();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
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
            });
        }
    }
}
