using FargoSpaAppWellness.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// SWITCH TO SQLITE (file-based, plug-and-play)
builder.Services.AddDbContext<SpaDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SpaDb")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
