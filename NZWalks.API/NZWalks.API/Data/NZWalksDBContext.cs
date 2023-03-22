using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domian;

namespace NZWalks.API.Data
{
    public class NZWalksDBContext: DbContext
    {
        // First create ctor
        public NZWalksDBContext(DbContextOptions<NZWalksDBContext> options) : base(options)
        {

        }
        // then write the domain oject those you want to create in data base

        // Create a relation between tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User_Role>()
                .HasOne(x => x.Role)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(x => x.RoleId);

            modelBuilder.Entity<User_Role>()
                .HasOne(x => x.User)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(x => x.UserId);
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User_Role> Users_Roles { get; set; }

    }
}
