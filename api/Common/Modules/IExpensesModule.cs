namespace Common.Modules;

public interface IExpensesModule
{
    Task<List<ExpenseDto>> GetExpenses(DateTime from, DateTime to, CancellationToken cancellationToken);

    Task<List<BudgetDto>> GetBudgets(CancellationToken cancellationToken);
}