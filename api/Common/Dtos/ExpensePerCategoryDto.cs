namespace Common.Dtos;

public class ExpensePerCategoryDto
{
    public List<ExpenseDto> Expenses { get; set; }

    public CategoryDto Category { get; set; }
}
