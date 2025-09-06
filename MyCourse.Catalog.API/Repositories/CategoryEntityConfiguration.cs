using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.EntityFrameworkCore.Extensions;
using MyCourse.Catalog.API.Features.Categories;

namespace MyCourse.Catalog.API.Repositories;

public class CategoryEntityConfiguration :  IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToCollection("categories");
        builder.HasKey(x => x.Id); 
        builder.Property(x => x.Id).ValueGeneratedNever(); 
        builder.Ignore(x => x.Courses);
    }
}