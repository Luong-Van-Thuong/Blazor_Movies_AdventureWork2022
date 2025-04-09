using Blazor_Movies_02.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Blazor_Movies_02.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<BlazorMovies02Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BlazorMovies02Context") ?? throw new InvalidOperationException("Connection string 'BlazorMovies02Context' not found.")));
builder.Services.AddDbContextFactory<BlazorMoviesRoadMap>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BlazorMoviesRoadMap") ?? throw new InvalidOperationException("Connection string 'BlazorMoviesRoadMap' not found.")));
builder.Services.AddDbContextFactory<AdventureWorks2022>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AdventureWorks2022") ?? throw new InvalidOperationException("Connection string 'AdventureWork2022' not found.")));


builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
