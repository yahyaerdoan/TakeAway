using Microsoft.Data.SqlClient;
using System.Data;

namespace TakeAway.DiscountService.Settings.DbContexts;

public class DapperOrmDbConnection(IConfiguration configuration)
{
    private readonly IConfiguration _configuration = configuration;
    private readonly string _connectionString = configuration.GetConnectionString("DapperConnection");

    public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
}
