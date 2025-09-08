namespace MyCourse.Catalog.API.Features.Courses.Create;

public  static class CreateCourseCommandEndpoint
{
    public static RouteGroupBuilder CreateCourseGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/", 
            async (CreateCourseCommand command, IMediator mediator) => (await mediator.Send(command))
                .ToGenericResult())
            .Produces<Guid>(StatusCodes.Status201Created)
            .AddEndpointFilter<ValidationFilter<CreateCourseCommand>>();
        return group;
    }
}