using FargoSpaAppWellness.Components;
using FargoSpaAppWellness.Data;   // <-- add this
using Microsoft.EntityFrameworkCore; // <-- add this

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register EF Core DbContext
builder.Services.AddDbContext<SpaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SpaDbConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();