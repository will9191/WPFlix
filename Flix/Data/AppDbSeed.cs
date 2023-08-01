using Flix.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Flix.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Roles - Perfis de Usuário
            List<IdentityRole> roles = new()
            {
                new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },
                new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Mod",
                    NormalizedName = "MOD"
                },
                new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "User",
                    NormalizedName = "USER"
                },
                
            };
            builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate AppUser - Usuários
        List<AppUser> users = new(){
            new AppUser(){
                Id = Guid.NewGuid().ToString(),
                Name = "Willian",
                DateOfBirth = DateTime.Parse("06/07/2005"),
                Email = "willian.fernando040@gmail.com",
                NormalizedEmail = "WILLIAN.FERNANDO040@GMAIL.COM",
                UserName = "Will",
                NormalizedUserName = "WILL",
                LockoutEnabled = false,
                PhoneNumber = "14982260514",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                ProfilePicture = "/img/users/avatar.png"
            }
        };

        foreach (var user in users)
        {
            PasswordHasher<AppUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }

        builder.Entity<AppUser>().HasData(users);
        #endregion
    
        #region Populate UserRole - Usuário com Perfil
            List<IdentityUserRole<string>> userRoles = new()
            {
                new IdentityUserRole<string>()
                {
                    UserId = users[0].Id,
                    RoleId = roles[0].Id
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}
