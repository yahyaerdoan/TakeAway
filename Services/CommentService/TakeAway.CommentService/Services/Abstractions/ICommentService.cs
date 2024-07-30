using TakeAway.CommentService.Dtos;

namespace TakeAway.CommentService.Services.Abstractions;

public interface ICommentService
{
    Task<List<ResultCommentDto>> GetAllAsync();
    Task CreateCommetAsync(CreateCommentDto createCommentDto); 
    Task UpdateCommetAsync(UpdateCommentDto updateCommentDto); 
    Task DeleteCommetAsync(int id); 
    Task<GetByIdCommentDto> GetByIdCommentAsync(int id);
    Task<List<ResultCommentDto>> GetCommentByProductIdAsync(string productId);
}
