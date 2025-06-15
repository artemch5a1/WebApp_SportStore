using Microsoft.EntityFrameworkCore;
using SportStorage.DataAccess;
using SportStorage.DataAccess.Reposotories;
using SportStore.Application.Servises;
using SportStore.Core.Abstractions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<SportStorageDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(SportStorageDbContext)));
});

builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISportItemService, SportItemService>();

builder.Services.AddScoped<ISportsItemsRepository, SportsItemsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => Results.Redirect("/swagger/index.html")).ExcludeFromDescription();

app.Run();
