using AuraSoftec.Desarollo.Application.Interfaces;
using AuraSoftec.Desarollo.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataBaseService>(
   options => options.UseSqlServer(builder.Configuration["SQLConnectionString"]));

builder.Services.AddScoped<IDataBaseService, DataBaseService>();

// Add services to the container.  
var app = builder.Build();

// Configure the HTTP request pipeline.  
app.Run();