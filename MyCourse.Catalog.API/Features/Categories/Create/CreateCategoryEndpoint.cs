namespace MyCourse.Catalog.API.Features.Categories.Create;

public static class CreateCategoryEndpoint
{
    public static RouteGroupBuilder CreateCategoryGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/",
            async (CreateCategoryCommand command, IMediator mediator) => (await mediator.Send(command))
                .ToGenericResult())
            .WithDisplayName("Create Category")
            .Produces<Guid>(StatusCodes.Status201Created)
            .AddEndpointFilter<ValidationFilter<CreateCategoryCommand>>();
        return group;
    }
}