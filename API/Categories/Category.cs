using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace API.Categories;

public class Category
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }

    public Collection<Action>? Actions { get; set; }
    
    [Required]
    public int UserId { get; set; }
}