using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using VotingApp.Business;
using VotingApp.DataAccess;
using VotingApp.DataAccess.EntityFramework.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
    {
        option.LoginPath = "/auth/login";
        option.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        //TODO:ÖNEMLÝ
        option.AccessDeniedPath = "/";
        option.ReturnUrlParameter = "";
    });

builder.Services.AddBusinessLayer(builder.Configuration);
builder.Services.AddDataAccessLayer(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}");

using (var scope = app.Services.GetService<IServiceScopeFactory>()?.CreateScope())
{
    scope?.ServiceProvider.GetRequiredService<VotingDbContext>().Database.Migrate();
}

app.Run();
