using API.Generic;
using MediatR;

namespace API.Categories.CommandHandlers;

// Command
public class GetAllCategoriesCommand : IRequest<List<Category>>
{
    public Category[]? Categories { get; set; } 
}

// Command Handler
public class GetAllCategoriesCommandHandler : IRequestHandler<GetAllCategoriesCommand,List<Category>>
{
    private readonly IRepository<Category> _categoryRepository;

    public GetAllCategoriesCommandHandler(IRepository<Category> categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<List<Category>> Handle(GetAllCategoriesCommand request, CancellationToken cancellationToken)
    {
        return await _categoryRepository.GetAllAsync();
    }
}

