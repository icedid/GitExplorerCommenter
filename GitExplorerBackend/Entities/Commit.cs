namespace Entities;

public class Commit
{
    public int Id { get; set; }
    public int RepoId { get; set; }
    public string Sha { get; set; } = null!;
    public string Message { get; set; } = null!;
    public string Author { get; set; } = null!;
    public DateTime CommittedAt { get; set; }

    public Repository Repository { get; set; } = null!;
    public ICollection<CommentAnchor> CommentAnchors { get; set; } = [];
}
