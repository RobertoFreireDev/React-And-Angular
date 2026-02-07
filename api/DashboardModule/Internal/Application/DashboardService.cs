namespace DashboardModule.Internal.Application;

internal class DashboardService(IExpensesModule expensesModule) : IDashboardService
{
    public async Task<DashboardDto> GetDashboard(DateTime from, DateTime to, CancellationToken cancellationToken)
    {
        var expenses = await expensesModule.GetExpenses(from, to, cancellationToken);
        var budgets = await expensesModule.GetBudgets(cancellationToken);
        var dashboard = new DashboardDto()
        {
            From = from,
            To = to,
            TotalExpenses = 0
        };

        dashboard.ExpensesPerCategory = expenses
            .GroupBy(e => e.CategoryName)
            .Select(g => new ExpenseDashboardItemPerCategoryDto
            {
                Expenses = g.Select(e => new ExpenseDashboardItemDto()
                {
                    Description = e.Description,
                    Amount = e.Amount,
                    Date = e.Date
                }).ToList(),
                CategoryName = g.Key,
                BudgetPerCategory = budgets.FirstOrDefault(b => b.CategoryName == g.Key)?.Amount ?? 0,
                TotalPerCategory = g.Sum(x => x.Amount)
            })
            .ToList();

        foreach (var expense in dashboard.ExpensesPerCategory)
        {
            dashboard.TotalExpenses += expense.TotalPerCategory;
        }

        return dashboard;
    }
}
