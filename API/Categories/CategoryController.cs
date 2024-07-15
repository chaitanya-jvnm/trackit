using MediatR;
using Microsoft.AspNetCore.Mvc;
using API.Categories;
using API.Categories.CommandHandlers;

namespace API.Categories;

[ApiController]
[Route("/v1/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    
    CategoryController(IMediator mediator) => _mediator = mediator;
    
    
    [HttpGet]
    public async Task<IActionResult<Category[]>> GetCategories()
    {
        var result = await _mediator.Send(new GetAllCategoriesCommand());
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetCategoryById([FromRoute]int id)
    {
        
    }


}