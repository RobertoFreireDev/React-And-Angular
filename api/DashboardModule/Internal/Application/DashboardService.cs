namespace DashboardModule.Internal.Application;

internal class DashboardService : IDashboardService
{
    public Task<DashboardDto> GetDashboard(DateTime from, DateTime to, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
