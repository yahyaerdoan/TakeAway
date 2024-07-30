using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TakeAway.CommentService.DataAccessLayer.Entities;
using TakeAway.CommentService.DataAccessLayer.Settings.Context;
using TakeAway.CommentService.Dtos;
using TakeAway.CommentService.Services.Abstractions;

namespace TakeAway.CommentService.Services.Concretions;

public class CommentService(CommentContext commentContext, IMapper mapper) : ICommentService
{
    private readonly CommentContext _commentContext = commentContext;
    private readonly IMapper mapper = mapper;

    public async Task CreateCommetAsync(CreateCommentDto createCommentDto)
    {
        var comment = mapper.Map<Comment>(createCommentDto);
        await _commentContext.Comments.AddAsync(comment);
        await _commentContext.SaveChangesAsync();
    }

    public async Task DeleteCommetAsync(int id)
    {
        var values = await _commentContext.Comments.FindAsync(id);
        _commentContext.Comments.Remove(values);
        await _commentContext.SaveChangesAsync();
    }

    public async Task<List<ResultCommentDto>> GetAllAsync()
    {
        var values = await _commentContext.Comments.ToListAsync();
        return mapper.Map<List<ResultCommentDto>>(values);
    }

    public async Task<GetByIdCommentDto> GetByIdCommentAsync(int id)
    {
        var values = await _commentContext.Comments.FindAsync(id);
        return mapper.Map<GetByIdCommentDto>(values);
    }

    public async Task<List<ResultCommentDto>> GetCommentByProductIdAsync(string productId)
    {
        var values = await _commentContext.Comments.Where(x => x.ProductId == productId).ToListAsync();
        return mapper.Map<List<ResultCommentDto>>(values);
    }

    public async Task UpdateCommetAsync(UpdateCommentDto updateCommentDto)
    {
        var values = mapper.Map<Comment>(updateCommentDto);
        _commentContext.Comments.Update(values);
        await _commentContext.SaveChangesAsync();
    }
}
