using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using DrEmergencias;
using Radzen;
using Radzen.Blazor;



var builder = WebApplication.CreateBuilder(args);

var ConStr = builder.Configuration.GetConnectionString("ConStr");
builder.Services.AddDbContext<Contexto>(Options =>Options.UseSqlite(ConStr));

builder.Services.AddScoped<EmergenciaBLL>();

builder.Services.AddScoped<EmergenciaABLL>();

builder.Services.AddScoped<PacienteBLL>();
builder.Services.AddScoped<SuplidorBLL>();
builder.Services.AddScoped<ArticuloBLL>();
builder.Services.AddScoped<EntradaBLL>();
builder.Services.AddScoped<SalidaBLL>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<TooltipService>();



// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

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
