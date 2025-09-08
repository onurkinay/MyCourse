 
using MyCourse.Catalog.API.Features.Courses.Create;
using MyCourse.Catalog.API.Features.Courses.Delete;
using MyCourse.Catalog.API.Features.Courses.GetAll;
using MyCourse.Catalog.API.Features.Courses.GetById;
using MyCourse.Catalog.API.Features.Courses.Update;

namespace MyCourse.Catalog.API.Features.Courses;

public static class CourseEndpointExt
{
    public static void AddCourseGroupEndpoint(this WebApplication app)
    {
        app.MapGroup("api/courses").WithTags("Courses")
            .CreateCourseGroupItemEndpoint()
            .GetAllCoursesGroupItemEndpoint()
            .GetByIdCourseGroupItemEndpoint()
            .UpdateCourseGroupItemEndpoint().DeleteCourseGroupItemEndpoint();

    }
}