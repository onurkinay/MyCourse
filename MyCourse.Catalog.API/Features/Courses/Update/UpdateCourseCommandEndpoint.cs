namespace MyCourse.Catalog.API.Features.Courses.Update;

public  static class UpdateCourseCommandEndpoint
{
    public static RouteGroupBuilder UpdateCourseGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPut("/", 
                async (UpdateCourseCommand command, IMediator mediator) => (await mediator.Send(command))
                    .ToGenericResult())
            .Produces<Guid>(StatusCodes.Status201Created)
            .AddEndpointFilter<ValidationFilter<UpdateCourseCommand>>();
        return group;
    }
}