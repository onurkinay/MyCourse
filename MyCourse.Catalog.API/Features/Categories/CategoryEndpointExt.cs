using MyCourse.Catalog.API.Features.Categories.Create;
using MyCourse.Catalog.API.Features.Categories.GetAll;
using MyCourse.Catalog.API.Features.Categories.GetById;
 

namespace MyCourse.Catalog.API.Features.Categories;

public static class CategoryEndpointExt
{
    public static void AddCategoryGroupEndpoint(this WebApplication app)
    {
        app.MapGroup("api/categories")
            .CreateCategoryGroupItemEndpoint()
            .GetAllCategoryGroupItemEndpoint()
            .GetByIdCategoryGroupItemEndpoint();

    }
}