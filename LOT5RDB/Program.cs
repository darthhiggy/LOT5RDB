using LOT5RDB;
using LOT5RDB.Core.Equipment.DataObjects;
using LOT5RDB.Data.DBContexts;
using LOT5RDB.Data.Repositories;
using Microsoft.EntityFrameworkCore;
//todo: Generated code, using startup class to do all this per how I learned it. Will come back around to this to see if I ultimately like it better
//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddDbContext<EquipmentDbContext>(options =>
//{
//    options.UseSqlServer(Configuration.GetConnectionString("LOT5RDB"));
//})
//builder.Services.AddScoped<IEquipmentRepository, SqlEquipmentRepo>();
//builder.Services.AddRazorPages();


//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();

Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
{
    webBuilder.UseStartup<Startup>();
}).Build().Run();