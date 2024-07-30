namespace TakeAway.CommentService.DataAccessLayer.Entities;

public class Comment
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? SurName { get; set; }
    public string? Email { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? CommentDetail { get; set; }
    public bool Status { get; set; }
}
