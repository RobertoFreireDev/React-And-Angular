namespace ExpensesModule.Public;

internal class ExpensesModule(IBudgetService budgetService, IExpenseService expenseService) : IExpensesModule
{
    public async Task<List<BudgetDto>> GetBudgets(CancellationToken cancellationToken)
    {
        return await budgetService.GetBudgets(cancellationToken);
    }

    public async Task<List<ExpenseDto>> GetExpenses(DateTime from, DateTime to, CancellationToken cancellationToken)
    {
        return await expenseService.GetExpenses(from, to, cancellationToken);
    }
}
