

namespace MyCourse.Catalog.API.Features.Categories.Create;

public class CreateCategoryCommandValidator:AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required")
            .Length(4,20).WithMessage("Name must be between 4 and 20 characters");
    }
}