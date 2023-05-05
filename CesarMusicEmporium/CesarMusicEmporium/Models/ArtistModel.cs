using System.ComponentModel.DataAnnotations;

namespace CesarMusicEmporium.Models
{
    public class ArtistModel
    {
        [Key]
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public string GroupName { get; set; }
        public int FormedYear { get; set; }
        public string Genre { get; set; }
    }

}
