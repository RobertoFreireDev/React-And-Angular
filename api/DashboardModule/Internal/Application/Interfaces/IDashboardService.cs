
namespace DashboardModule.Internal.Application.Interfaces;

internal interface IDashboardService
{
    Task<DashboardDto> GetDashboard(DateTime from, DateTime to, CancellationToken cancellationToken);
}
