using CesarMusicEmporium.Models;
using Microsoft.EntityFrameworkCore;

namespace CesarMusicEmporium.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<AlbumModel> Albums { get; set; }
        public DbSet<ArtistModel> Artists { get; set; }
    }
}
