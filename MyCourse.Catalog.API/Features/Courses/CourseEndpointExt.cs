using Asp.Versioning.Builder;
using MyCourse.Catalog.API.Features.Courses.Create;
using MyCourse.Catalog.API.Features.Courses.Delete;
using MyCourse.Catalog.API.Features.Courses.GetAll;
using MyCourse.Catalog.API.Features.Courses.GetAllByUserId;
using MyCourse.Catalog.API.Features.Courses.GetById;
using MyCourse.Catalog.API.Features.Courses.Update;

namespace MyCourse.Catalog.API.Features.Courses;

public static class CourseEndpointExt
{
    public static void AddCourseGroupEndpoint(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/courses").WithTags("Courses").WithApiVersionSet(apiVersionSet)
            .CreateCourseGroupItemEndpoint()
            .GetAllCoursesGroupItemEndpoint()
            .GetByIdCourseGroupItemEndpoint()
            .UpdateCourseGroupItemEndpoint()
            .DeleteCourseGroupItemEndpoint()
            .GetByUserIdCourseGroupItemEndpoint();

    }
}