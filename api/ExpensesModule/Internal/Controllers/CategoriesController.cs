namespace ExpensesModule.Internal.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
internal class CategoriesController(ICategoryService categoryService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetCategory(CancellationToken cancellationToken)
    {
        return Ok(await categoryService.GetCategories(cancellationToken));
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrUpdateCategory([FromBody] CategoryDto request, CancellationToken cancellationToken)
    {
        await categoryService.CreateOrUpdateCategory(request, cancellationToken);
        return Ok();
    }

    [HttpDelete("{categoryName}")]
    public async Task<IActionResult> DeleteCategory(string categoryName, CancellationToken cancellationToken)
    {
        await categoryService.DeleteCategory(categoryName, cancellationToken);
        return Ok($"Category {categoryName} deleted");
    }
}