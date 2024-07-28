namespace API.Categories;

public class Category
{
    public required int Id { get; set; }
    
    public required string Name { get; set; }

    public Action[]? Actions { get; set; }
    
}