 
using Asp.Versioning.Builder;
using MyCourse.Catalog.API.Features.Categories.Create;
using MyCourse.Catalog.API.Features.Categories.GetAll;
using MyCourse.Catalog.API.Features.Categories.GetById;
 

namespace MyCourse.Catalog.API.Features.Categories;

public static class CategoryEndpointExt
{
    public static void AddCategoryGroupEndpoint(this WebApplication app,ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/categories").WithTags("Categories")
            .WithApiVersionSet(apiVersionSet)
            .CreateCategoryGroupItemEndpoint()
            .GetAllCategoriesGroupItemEndpoint()
            .GetByIdCategoryGroupItemEndpoint();

    }
}