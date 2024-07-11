using Microsoft.Data.SqlClient;
using System.Data;

namespace TakeAway.DiscountService.Settings.DbContexts;

public class DapperOrmDbConnection(IConfiguration configuration)
{
    private readonly string _connectionString = configuration.GetConnectionString("DapperConnection") 
        ?? throw new InvalidOperationException("The ConnectionString property has not been initialized.");
    public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
}
