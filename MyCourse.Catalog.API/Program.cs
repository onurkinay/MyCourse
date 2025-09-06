using MyCourse.Catalog.API.Options;

var builder = WebApplication.CreateBuilder(args);
 
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddOptionsExt();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}



app.Run();

 