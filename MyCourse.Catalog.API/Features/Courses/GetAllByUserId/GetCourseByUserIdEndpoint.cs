
using MyCourse.Catalog.API.Features.Courses.Dtos;
 
namespace MyCourse.Catalog.API.Features.Courses.GetAllByUserId;

public record GetCourseByUserIdQuery(Guid UserId) : IRequestByServiceResult<List<CourseDto>>;

public class GetCourseByIdQueryHandler(AppDbContext context, IMapper mapper) : IRequestHandler<GetCourseByUserIdQuery, ServiceResult<List<CourseDto>>>
{
    public async Task<ServiceResult<List<CourseDto>>> Handle(GetCourseByUserIdQuery request, CancellationToken cancellationToken)
    {
        var courses = await context.Courses.Where(x=>x.UserId == request.UserId).ToListAsync(cancellationToken);
       
        var categories = await  context.Categories.ToListAsync(cancellationToken);

        foreach (var course in courses)
        {
            course.Category =  categories.FirstOrDefault(x => x.Id == course.CategoryId);
        }
        
        var coursesAsDto = mapper.Map<List<CourseDto>>(courses);
        return ServiceResult<List<CourseDto>>.SuccessAsOk(coursesAsDto);
    }
}

public static class GetCourseByUserIdEndpoint
{
    public static RouteGroupBuilder GetByUserIdCourseGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/user/{userId:guid}",
            async (IMediator mediator,Guid userId) => (await mediator.Send(new GetCourseByUserIdQuery(userId)))
                .ToGenericResult()).WithName("GetCourseByUserId");
        return group;
    }
}