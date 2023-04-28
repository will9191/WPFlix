using Flix.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Flix.Data;
public class AppDbContext : IdentityDbContext
{
    
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieComment> MovieComments { get; set; }
    public DbSet<MovieGenre> MovieGenres { get; set; }
    public DbSet<MovieRating> MovieRatings { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityUser>(b => {
            b.ToTable("User");
        });
        builder.Entity<IdentityUserClaim<string>>(b => {
            b.ToTable("UserClaims");
        });
        builder.Entity<IdentityUserLogin<string>>(b => {
            b.ToTable("Users");
        });
        builder.Entity<IdentityUserToken<string>>(b => {
            b.ToTable("UserTokens");
        });
        builder.Entity<IdentityRole>(b => {
            b.ToTable("Roles");
        });
        builder.Entity<IdentityRoleClaim<string>>(b => {
            b.ToTable("RoleClaims");
        });
        builder.Entity<IdentityUserRole<string>>(b => {
            b.ToTable("UserRoles");
        });
    
    }
}
