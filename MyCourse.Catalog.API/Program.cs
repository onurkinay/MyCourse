using MyCourse.Catalog.API;
using MyCourse.Catalog.API.Features.Categories;
using MyCourse.Catalog.API.Features.Courses;
using MyCourse.Catalog.API.Options;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
 

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOptionsExt();
builder.Services.AddDataseServiceExt();
builder.Services.AddCommonServiceExt(typeof(CatalogAssembly));
builder.Services.AddOpenApi();
builder.Services.AddVersioningExt();
var app = builder.Build();
 
app.AddCategoryGroupEndpoint(app.AddVersionSetExt());
app.AddCourseGroupEndpoint(app.AddVersionSetExt());
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}


app.Run();

 