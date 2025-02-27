using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PAUYS.Entity.Entities.Concrete;

namespace PAUYS.DAL.Context
{
    public class PAUYSDbContext : IdentityDbContext<AppUser>
    {

        public PAUYSDbContext(DbContextOptions contextOptions): base(contextOptions)
        {
            
        }
        public DbSet<CustomerRequest> CustomerRequest { get; set; }

        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Material> Materials { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<CustomerRequest> CustomerRequests { get; set; }
        public DbSet<Question> Questionss { get; set; }
        public DbSet<PackingGuide> PackingGuides { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            string userId = Guid.NewGuid().ToString();
            string roleId = Guid.NewGuid().ToString();
            string stamp = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<AppUser>();

            // Kullanıcı verisi ekleme
            builder.Entity<AppUser>().HasData(new AppUser()
            {
                Id = userId,
                FirstName = "Minel",
                LastName = "Karakökçek",
                UserName = "minel.karakokcek@mail.com",
                Email = "minel.karakokcek@mail.com",
                NormalizedUserName = "MINEL.KARAKOKCEK@MAIL.COM",
                NormalizedEmail = "MINEL.KARAKOKCEK@MAIL.COM",
                PasswordHash = hasher.HashPassword(null, "Admin123."), // Şifreyi hashliyoruz
                EmailConfirmed = true,
                ConcurrencyStamp = stamp,
                SecurityStamp = stamp
            });

            // Admin rolü ekleme
            builder.Entity<IdentityRole>().HasData(new IdentityRole()
            {
                Id = roleId,
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = stamp
            });

            // Kullanıcıya Admin rolü atama
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
            {
                RoleId = roleId,
                UserId = userId,
            });
        }


    }
}
