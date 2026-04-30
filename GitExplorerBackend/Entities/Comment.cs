namespace Entities;

public class Comment
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; } = null!;
    public DateTime CreatedAt { get; set; }

    public User User { get; set; } = null!;
    public ICollection<CommentAnchor> CommentAnchors { get; set; } = [];
}
