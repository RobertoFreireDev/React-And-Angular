namespace DashboardModule.Public;

public static class DashboardModuleRegistration
{
    public static IMvcBuilder AddDashboardsControllers(this IMvcBuilder mvcBuilder)
    {
        return mvcBuilder.AddApplicationPart(typeof(DashboardModuleRegistration).Assembly);
    }

    public static IServiceCollection RegisterDashboardsServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IDashboardService, DashboardService>();

        return services;
    }
}