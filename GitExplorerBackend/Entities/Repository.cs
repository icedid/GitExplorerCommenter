namespace Entities;

public class Repository
{
    public int Id { get; set; }
    public string GithubId { get; set; } = null!;
    public string RepoName { get; set; } = null!;

    public ICollection<Commit> Commits { get; set; } = [];
}
