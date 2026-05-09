using Entities;

public static class Seeder
{
    public static void Seed(AppDbContext context)
    {
        if (context.Repositories.Any())
        {
            Console.WriteLine("[Seeder] DB already seeded, skipping.");
            return;
        }

        Console.WriteLine("[Seeder] Starting seed...");

        var repo = new Repository
        {
            GithubId = "octocat/Hello-World",
            RepoName = "Hello-World"
        };
        context.Repositories.Add(repo);
        context.SaveChanges();
        Console.WriteLine($"[Seeder] Inserted Repository: Id={repo.Id}, Name={repo.RepoName}");

        var commits = new List<Commit>
        {
            new Commit { RepoId = repo.Id, Repository = repo, Sha = "abc123", Message = "Initial commit", Author = "octocat", CommittedAt = DateTime.UtcNow.AddDays(-10) },
            new Commit { RepoId = repo.Id, Repository = repo, Sha = "def456", Message = "Add readme", Author = "octocat", CommittedAt = DateTime.UtcNow.AddDays(-5) },
        };
        context.Commits.AddRange(commits);
        context.SaveChanges();
        Console.WriteLine($"[Seeder] Inserted {commits.Count} commits (Ids: {string.Join(", ", commits.Select(c => c.Id))})");

        var user = new User
        {
            Username = "testuser",
            PasswordHash = "fakehash",
            CreatedAt = DateTime.UtcNow
        };
        context.Users.Add(user);
        context.SaveChanges();
        Console.WriteLine($"[Seeder] Inserted User: Id={user.Id}, Username={user.Username}");

        var comment = new Comment
        {
            UserId = user.Id,
            Content = "This commit looks great!",
            CreatedAt = DateTime.UtcNow
        };
        context.Comments.Add(comment);
        context.SaveChanges();
        Console.WriteLine($"[Seeder] Inserted Comment: Id={comment.Id}, UserId={comment.UserId}");

        context.CommentAnchors.Add(new CommentAnchor
        {
            CommentId = comment.Id,
            CommitId = commits[0].Id
        });
        context.SaveChanges();
        Console.WriteLine($"[Seeder] Inserted CommentAnchor: CommentId={comment.Id}, CommitId={commits[0].Id}");

        Console.WriteLine("[Seeder] Seed complete.");
    }
}