using Microsoft.EntityFrameworkCore;
using ZeneStreamingAPI.Entities;

namespace ZeneStreamingAPI.Context
{
    public class StreamContext : DbContext
    {
        public StreamContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
