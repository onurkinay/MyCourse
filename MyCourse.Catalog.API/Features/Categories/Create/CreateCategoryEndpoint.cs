using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyCourse.Shared.Extensions;

namespace MyCourse.Catalog.API.Features.Categories.Create;

public static class CreateCategoryEndpoint
{
    public static RouteGroupBuilder CreateCategoryGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/", async (CreateCategoryCommand command, IMediator mediator) => (await mediator.Send(command)).ToGenericResult() );
        return group;
    }
}