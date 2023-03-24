using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using DrEmergencias;
using Radzen;
using Radzen.Blazor;
using Microsoft.AspNetCore.Identity;
using DrEmergencias.Data;



var builder = WebApplication.CreateBuilder(args);

var ConStr = builder.Configuration.GetConnectionString("ConStr");
builder.Services.AddDbContext<Contexto>(Options =>Options.UseSqlServer(ConStr));
builder.Services.AddDbContext<DrEmergenciasContext>(Options => Options.UseSqlServer(ConStr));
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<DrEmergenciasContext>();

builder.Services.AddScoped<EmergenciaBLL>();

builder.Services.AddScoped<EmergenciaABLL>();

builder.Services.AddScoped<PacienteBLL>();
builder.Services.AddScoped<SuplidorBLL>();
builder.Services.AddScoped<ArticuloBLL>();
builder.Services.AddScoped<EntradaBLL>();
builder.Services.AddScoped<SalidaBLL>();
builder.Services.AddScoped<OrdenComprasBLL>();
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
