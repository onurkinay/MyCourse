using MyCourse.Catalog.API.Features.Categories.Create;
using MyCourse.Catalog.API.Features.Courses.Create;

namespace MyCourse.Catalog.API.Features.Courses;

public static class CourseEndpointExt
{
    public static void AddCourseGroupEndpoint(this WebApplication app)
    {
        app.MapGroup("api/courses").WithTags("Courses")
            .CreateCourseGroupItemEndpoint();

    }
}