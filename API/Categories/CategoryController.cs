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
    public async Task<IActionResult> GetCategories()
    {
        var result = await _mediator.Send(new GetAllCategoriesCommand());
        if(result == null) return NotFound();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryById([FromRoute]int id)
    {
        var result = await _mediator.Send(
            new GetCategoryByIdCommand{categoryId = id});
        if(result == null) return NotFound();
        return Ok(result);
    }


}