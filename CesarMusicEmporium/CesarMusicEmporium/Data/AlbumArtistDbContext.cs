using Microsoft.EntityFrameworkCore;


namespace CesarMusicEmporium.Data
{
    public class AlbumArtistDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Floppa\Documents\CPSC-61200 - Software Architecture\Final Project\Database\AlbumArtistDb.accdb;");
        }


        public DbSet<Models.AlbumModel> Albums { get; set; }
        public DbSet<Models.ArtistModel> Artists { get; set; }
    }
}
