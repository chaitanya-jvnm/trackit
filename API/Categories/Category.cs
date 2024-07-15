namespace API.Categories;

public class Category
{
    int CategoryId { get; set; }
    
    string CategoryName { get; set; }

    Action[] CategoryActions { get; set; }
    
}