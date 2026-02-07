namespace ExpensesModule.Internal.Application.Interfaces;

internal interface ICategoryService
{
    Task<List<CategoryDto>> GetCategories(CancellationToken cancellationToken);

    Task CreateOrUpdateCategory(CategoryDto request, CancellationToken cancellationToken);

    Task DeleteCategory(string categoryName, CancellationToken cancellationToken);
}
