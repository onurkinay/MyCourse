using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MyCourse.Catalog.API.Options;
using MyCourse.Catalog.API.Repositories;

var builder = WebApplication.CreateBuilder(args);
 
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOptionsExt();
builder.Services.AddDataseServiceExt();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}



app.Run();

 