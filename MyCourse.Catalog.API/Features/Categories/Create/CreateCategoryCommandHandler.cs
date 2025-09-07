using System.Net;
using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyCourse.Catalog.API.Repositories;
using MyCourse.Shared;

namespace MyCourse.Catalog.API.Features.Categories.Create;

public class CreateCategoryCommandHandler(AppDbContext context) : IRequestHandler<CreateCategoryCommand, ServiceResult<CreateCategoryResponse>>
{
    public async Task<ServiceResult<CreateCategoryResponse>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
         var existCategory = await context.Categories.AnyAsync(x=>x.Name == request.Name, cancellationToken);

         if (existCategory)
         {
             ServiceResult<CreateCategoryResponse>.Error("category already exists", $"The category name '{request.Name}' was already exists.",
                 HttpStatusCode.BadRequest);
         }

         var category = new Category
         {
             Name = request.Name,
             Id = NewId.NextSequentialGuid()
         };
         await  context.AddAsync(category, cancellationToken);
         await context.SaveChangesAsync(cancellationToken);
         
         return ServiceResult<CreateCategoryResponse>.SuccessAsCreated(new CreateCategoryResponse(category.Id),"<empty>");
    }
}