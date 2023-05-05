using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CesarMusicEmporium.Data;
using CesarMusicEmporium.Models;

namespace CesarMusicEmporium.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public ArtistsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ArtistModel>> GetArtists()
        {
            var artists = _dbContext.Artists.ToList();
            return Ok(artists);
        }

        [HttpGet("{id}")]
        public ActionResult<ArtistModel> GetArtist(int id)
        {
            var artist = _dbContext.Artists.FirstOrDefault(a => a.ArtistId == id);
            if (artist == null)
            {
                return NotFound();
            }
            return Ok(artist);
        }
    }
}
