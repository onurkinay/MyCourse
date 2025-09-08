using MyCourse.Catalog.API.Features.Courses;
using MyCourse.Catalog.API.Features.Courses.Create;
using MyCourse.Catalog.API.Features.Courses.Dtos;

namespace MyCourse.Catalog.API.Features.Courses;

public class CourseMapping:Profile
{
    public CourseMapping()
    {
        CreateMap<CreateCourseCommand, Course>();
        CreateMap<Course, CourseDto>().ReverseMap();
        CreateMap<Feature,FeatureDto>().ReverseMap();
    }
}