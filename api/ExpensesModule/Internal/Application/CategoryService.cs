namespace ExpensesModule.Internal.Application;

internal class CategoryService : ICategoryService
{
    private List<CategoryDto> Categories = new List<CategoryDto>();

    public async Task<List<CategoryDto>> GetCategories(CancellationToken cancellationToken)
    {
        return Categories;
    }

    public async Task CreateOrUpdateCategory(CategoryDto request, CancellationToken cancellationToken)
    {
        var categoryIndex = Categories.FindIndex(e => e.Name == request.Name);

        if (categoryIndex >= 0)
        {
            Categories[categoryIndex] = request;
            return;
        }

        Categories.Add(request);
    }

    public async Task DeleteCategory(string categoryName, CancellationToken cancellationToken)
    {
        var category = Categories.FirstOrDefault(e => e.Name == categoryName);

        if (category == null)
        {
            throw new Exception($"category {categoryName} doesn't exist");
        }

        Categories.Remove(category);
        return;
    }
}
