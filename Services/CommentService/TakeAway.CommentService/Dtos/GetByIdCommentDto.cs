namespace TakeAway.CommentService.Dtos;

public class GetByIdCommentDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? SurName { get; set; }
    public string? Email { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? CommentDetail { get; set; }
    public bool Status { get; set; }
    public string? ProductId { get; set; }
}
