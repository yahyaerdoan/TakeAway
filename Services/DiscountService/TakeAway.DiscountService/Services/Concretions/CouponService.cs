using AutoMapper;
using Dapper;
using TakeAway.DiscountService.Dtos.CouponDto;
using TakeAway.DiscountService.Entities;
using TakeAway.DiscountService.Services.Abstractions;
using TakeAway.DiscountService.Settings.DbContexts;

namespace TakeAway.DiscountService.Services.Concretions;

public class CouponService(DapperOrmDbConnection dbConnection, IMapper mapper) : ICouponService
{
    private readonly DapperOrmDbConnection dbConnection = dbConnection;
    private readonly IMapper mapper = mapper;

    public async Task CreateCouponAsync(CreateCouponDto createCouponDto)
    {
        var Coupon = mapper.Map<Coupon>(createCouponDto);
        string query = "INSERT INTO Coupons (Code, Rate, IsActive) VALUES (@Code, @Rate, @IsActive)";
        var parameters = new DynamicParameters();
        parameters.Add("@Code", Coupon.Code);
        parameters.Add("@Rate", Coupon.Rate);
        parameters.Add("@IsActive", Coupon.IsActive);
        var connection = dbConnection.CreateConnection();
        await connection.ExecuteAsync(query, parameters);
    }

    public async Task DeleteCouponAsync(int id)
    {
        string query = "DELETE FROM Coupons WHERE Id = @Id";
        var parameters = new DynamicParameters();
        parameters.Add("@Id", id);
        var connection = dbConnection.CreateConnection();
        await connection.ExecuteAsync(query, parameters);
    }

    public async Task<List<ResultCouponDto>> GetAllCouponAsync()
    {

        string query = "SELECT * FROM Coupons";
        var connection = dbConnection.CreateConnection();
        var values = await connection.QueryAsync<ResultCouponDto>(query);
        return [.. mapper.Map<List<ResultCouponDto>>(values)];
    }

    public async Task<GetByIdCouponDto> GetByIdCouponAsync(int id)
    {
        string query = "SELECT * FROM Coupons WHERE Id = @Id";
        var parameters = new DynamicParameters();
        parameters.Add("@Id", id);
        var connection = dbConnection.CreateConnection();
        var values = await connection.QueryFirstOrDefaultAsync<GetByIdCouponDto>(query, parameters);
        return mapper.Map<GetByIdCouponDto>(values);
    }

    public async Task UpdateCouponAsync(UpdateCouponDto updateCouponDto)
    {
        var Coupon = mapper.Map<Coupon>(updateCouponDto);
        string query = "UPDATE Coupons SET Code = @Code, Rate = @Rate, IsActive = @IsActive WHERE Id = @Id";
        var parameters = new DynamicParameters();
        parameters.Add("@Code", Coupon.Code);
        parameters.Add("@Rate", Coupon.Rate);
        parameters.Add("@IsActive", Coupon.IsActive);
        parameters.Add("@Id", Coupon.Id);
        var connection = dbConnection.CreateConnection();
        await connection.ExecuteAsync(query, parameters);
    }
}
