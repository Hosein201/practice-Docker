using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Data.SqlClient;

namespace DockerApp
{
    public class HealthCheckSql : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=db;Database=master;User Id=SA;Password=example_123;";
            try
            {
                conn.Open();
                conn.Close();
                return Task.FromResult(HealthCheckResult.Healthy());
            }
            catch(Exception ex)
            {
                return Task.FromResult(HealthCheckResult.Unhealthy(ex.Message,ex));
            }           
        }
    }
}
