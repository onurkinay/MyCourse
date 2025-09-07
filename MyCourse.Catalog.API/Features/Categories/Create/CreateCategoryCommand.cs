using MediatR;
using MyCourse.Shared;

namespace MyCourse.Catalog.API.Features.Categories.Create;

public record CreateCategoryCommand(string Name):IRequest<ServiceResult<CreateCategoryResponse>>;
