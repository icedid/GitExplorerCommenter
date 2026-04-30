namespace Entities;

public class CommentAnchor
{
    public int CommentId { get; set; }
    public int CommitId { get; set; }

    public Comment Comment { get; set; } = null!;
    public Commit Commit { get; set; } = null!;
}
