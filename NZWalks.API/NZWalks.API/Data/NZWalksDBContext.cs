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

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
