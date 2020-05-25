using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gallery.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<GalleryImage>()
                .HasKey(c => new { c.GalleryId, c.ImageId });
            modelBuilder.Entity<IdentityUser<Guid>>().HasData(new IdentityUser<Guid>
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Email = "admin@admin.admin",
                NormalizedEmail = "ADMIN@ADMIN.ADMIN",
                EmailConfirmed = true,
                LockoutEnabled = false,
                UserName = "admin@admin.admin",
                NormalizedUserName = "ADMIN@ADMIN.ADMIN",
                PasswordHash = hasher.HashPassword(null, "Admin_1234"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<Gallery>().HasData(new Gallery { GalleryId = Guid.Parse("12345678-1234-1234-1234-123456781234"), OwnerId = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "First Gallery" });
            modelBuilder.Entity<Image>().HasData(new Image { ImageId = Guid.Parse("12341234-1234-1234-1234-123412341234"), OwnerId = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "Sinon", Source = "https://i.redd.it/1r9ev8i0i4631.jpg", GalleryId = Guid.Parse("12345678-1234-1234-1234-123456781234") });
            modelBuilder.Entity<Image>().HasData(new Image { ImageId = Guid.Parse("12121212-1212-1212-1212-121212121212"), OwnerId = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "Sinon", Source = "https://i.pinimg.com/originals/6e/36/b5/6e36b544c8f6edb3d509c7cbb59fa84d.jpg", GalleryId = Guid.Parse("12345678-1234-1234-1234-123456781234") });
            modelBuilder.Entity<Image>().HasData(new Image { ImageId = Guid.Parse("43214321-4321-4321-4321-432143214321"), OwnerId = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "Maou", Source = "https://www.covercentury.com/covers/audio/m/maoyuu-maou-yuusha-o_takeshi-hama_30803434.jpg", GalleryId = Guid.Parse("12345678-1234-1234-1234-123456781234") });
            modelBuilder.Entity<GalleryImage>().HasData(new GalleryImage { GalleryId = Guid.Parse("12345678-1234-1234-1234-123456781234"), ImageId = Guid.Parse("43214321-4321-4321-4321-432143214321")});
            modelBuilder.Entity<GalleryImage>().HasData(new GalleryImage { GalleryId = Guid.Parse("12345678-1234-1234-1234-123456781234"), ImageId = Guid.Parse("12121212-1212-1212-1212-121212121212") });
            modelBuilder.Entity<GalleryImage>().HasData(new GalleryImage { GalleryId = Guid.Parse("12345678-1234-1234-1234-123456781234"), ImageId = Guid.Parse("12341234-1234-1234-1234-123412341234")});
        }
    }
}
