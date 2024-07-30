using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.CommentService.Dtos;
using TakeAway.CommentService.Services.Abstractions;

namespace TakeAway.CommentService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommentsController(ICommentService commentService) : ControllerBase
{
    private readonly ICommentService commentService = commentService;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var values = await commentService.GetAllAsync();
        return Ok(values);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetById(int id)
    {
        var values = await commentService.GetByIdCommentAsync(id);
        return Ok(values);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByProductId(string id)
    {
        var values = await commentService.GetCommentByProductIdAsync(id);
        return Ok(values);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateCommentDto createCommentDto)
    {
        await commentService.CreateCommetAsync(createCommentDto);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        await commentService.DeleteCommetAsync(id);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateCommentDto updateCommentDto)
    {
        await commentService.UpdateCommetAsync(updateCommentDto);
        return Ok();
    }
}
