namespace ExpensesModule.Public;

public static class ExpensesModuleRegistration
{
    public static IMvcBuilder AddExpensesControllers(this IMvcBuilder mvcBuilder)
    {
        return mvcBuilder.AddApplicationPart(typeof(ExpensesModuleRegistration).Assembly);
    }

    public static IServiceCollection RegisterExpensesServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IExpenseService, ExpenseService>();
        services.AddSingleton<IBudgetService, BudgetService>();
        services.AddSingleton<ICategoryService, CategoryService>();

        return services;
    }
}