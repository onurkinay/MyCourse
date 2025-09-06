using System.ComponentModel.DataAnnotations;

namespace MyCourse.Catalog.API.Options;

public class MongoOption
{
    [Required]
    public string DatabaseName { get; set; } = default!;
    public string ConnectionString { get; set; } = default!;
}