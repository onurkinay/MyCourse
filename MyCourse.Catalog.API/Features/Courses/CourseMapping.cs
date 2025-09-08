using MyCourse.Catalog.API.Features.Courses;
using MyCourse.Catalog.API.Features.Courses.Create;

namespace MyCourse.Catalog.API.Features.Courses;

public class CourseMapping:Profile
{
    public CourseMapping()
    {
        CreateMap<CreateCourseCommand, Course>();
    }
}