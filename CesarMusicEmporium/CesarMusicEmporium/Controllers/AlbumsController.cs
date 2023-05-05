﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CesarMusicEmporium.Data;
using CesarMusicEmporium.Models;

namespace CesarMusicEmporium.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public AlbumsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AlbumModel>> GetAlbums()
        {
            var albums = _dbContext.Albums.ToList();
            return Ok(albums);
        }

        [HttpGet("{id}")]
        public ActionResult<AlbumModel> GetAlbum(int id)
        {
            var album = _dbContext.Albums.FirstOrDefault(a => a.AlbumId == id);
            if (album == null)
            {
                return NotFound();
            }
            return Ok(album);
        }
    }
}
