namespace API.Actions;

public class Action
{
    int ActionId { get; set; }
    
    string ActionName { get; set; }
    
    int CategoryId { get; set; }

    private string ActionUnit { get; set; } = "Unit";

    private double ActionValue { get; set; }
    
}