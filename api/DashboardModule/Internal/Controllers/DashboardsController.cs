namespace DashboardModule.Internal.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
internal class DashboardsController(IDashboardService dashboardService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetDashboards([FromQuery] DateTime from, DateTime to, CancellationToken cancellationToken)
    {
        return Ok(await dashboardService.GetDashboard(from, to,cancellationToken));
    }
}
