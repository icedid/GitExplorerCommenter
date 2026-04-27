using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    
    public DbSet<User> Users { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Commit> Commits { get; set; }
    public DbSet<Repository> Repositories { get; set; }
    public DbSet<CommentAnchor> CommentAnchors { get; set; }
}