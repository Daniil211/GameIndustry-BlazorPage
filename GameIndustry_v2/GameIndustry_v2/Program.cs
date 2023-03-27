using GameIndustry.Repository;
using GameIndustry_v2.Data;
using GameIndustry_v2.Data.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Tewr.Blazor.FileReader;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddTransient<IRepository, MockGamesRepository>();

builder.Services.AddFileReaderService(options => options.InitializeOnFirstCall = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
