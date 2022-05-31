using LOT5RDB.Data.DescriptionsDb;
using LOT5RDB.Data.EquipmentDb;
using LOT5RDB.Data.ExtensionMethods;
using LOT5RDB.Equipment.Server.ExtensionMethods;
using LOT5RDB.Equipment.Shared.ExtensionMethods;
using LOT5RDB.Skills.Server.ExtensionMethods;
using LOT5RDB.Skills.Shared.ExtensionMethods;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EquipmentDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LOT5RDB")));
builder.Services.AddDbContext<DescriptionsDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DescriptionsDb")));

builder.Services.InjectRepos();

builder.Services.InjectEquipmentRequest()
    .InjectEquipmentHandlers()
    .InjectSkillRequest()
    .InjectSkillHandlers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
