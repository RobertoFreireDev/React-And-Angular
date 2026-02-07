namespace Common.Dtos;

public class ExpenseDashboardItemDto
{
    public string Description { get; set; }
    public int Amount { get; set; }
    public DateTime Date { get; set; }
}

public class ExpenseDashboardItemPerCategoryDto
{
    public List<ExpenseDashboardItemDto> Expenses { get; set; }

    public string CategoryName { get; set; }

    public int BudgetPerCategory { get; set; }

    public int TotalPerCategory { get; set; }
}

public class DashboardDto
{
    public List<ExpenseDashboardItemPerCategoryDto> ExpensesPerCategory { get; set; }

    public int TotalExpenses { get; set; }

    public DateTime From { get; set; }

    public DateTime To { get; set; }
}
