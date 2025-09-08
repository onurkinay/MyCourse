namespace MyCourse.Catalog.API.Features.Courses.Create;

public class CreateCourseCommandValidator:AbstractValidator<CreateCourseCommand>
{
    public CreateCourseCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required")
            .MaximumLength(100).WithMessage("Name must be between 100 characters");
        
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is required")
            .MaximumLength(1000).WithMessage("Description must be less than 1000 characters");
        
        RuleFor(x => x.Price)
            .NotEmpty().WithMessage("Price is required")
            .GreaterThan(0).WithMessage("Price must be greater than 0");
 
        
        RuleFor(x => x.CategoryId).NotEmpty().WithMessage("CategoryId is required");


    }
    
   
}