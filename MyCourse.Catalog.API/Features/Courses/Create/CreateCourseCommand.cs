using MyCourse.Catalog.API.Features.Categories.Create;

namespace MyCourse.Catalog.API.Features.Courses.Create;

public record CreateCourseCommand(string Name, string Description, decimal Price, string? ImageUrl, Guid CategoryId) :
    IRequestByServiceResult<Guid>;
