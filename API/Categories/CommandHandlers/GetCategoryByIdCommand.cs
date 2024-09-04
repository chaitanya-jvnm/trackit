using API.Generic;
using MediatR;

namespace API.Categories.CommandHandlers;

//Command
public class GetCategoryByIdCommand : IRequest<Category>
{
    public required int categoryId {get;set;}
}

//CommandHandler
public class GetCategoryByIdCommandHandler : IRequestHandler<GetCategoryByIdCommand,Category>
{
    private readonly IRepository<Category> _categoryRepository;

    public GetCategoryByIdCommandHandler(IRepository<Category> categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<Category> Handle(GetCategoryByIdCommand request, CancellationToken cancellationToken)
    {
        return await _categoryRepository.GetOneAsync(request.categoryId);
    }
}