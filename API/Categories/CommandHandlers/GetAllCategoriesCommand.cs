using MediatR;

namespace API.Categories.CommandHandlers;

// Command
public class GetAllCategoriesCommand : IRequest<Category[]>
{
    public Category[] Categories { get; set; } 
}

// Command Handler
public class GetAllCategoriesCommandHandler : IRequestHandler<GetAllCategoriesCommand, Category[]>
{
    public Task<Category[]> Handle(GetAllCategoriesCommand request, CancellationToken cancellationToken)
    {
        Category[] categories = new Category[]();
        return categories;
    }
}

