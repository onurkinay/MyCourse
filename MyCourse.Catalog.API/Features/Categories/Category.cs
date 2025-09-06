using MyCourse.Catalog.API.Repositories;
using MyCourse.Catalog.API.Features.Courses;

namespace MyCourse.Catalog.API.Features.Categories;

public class Category:BaseEntity
{
    public string Name { get; set; } = default!;

    public List<Course>? Courses { get; set; }
    
}