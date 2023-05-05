using System.ComponentModel.DataAnnotations;

namespace CesarMusicEmporium.Models
{
    public class AlbumModel
    {
        [Key]
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
    }
}
