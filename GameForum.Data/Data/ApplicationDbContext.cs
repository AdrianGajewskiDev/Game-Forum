using GameForum.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameForum.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        DbSet<Forum> Forums { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<PostReply> Replies { get; set; }
    }
}
