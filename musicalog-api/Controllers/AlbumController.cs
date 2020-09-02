using Microsoft.AspNetCore.Mvc;

namespace musicalog_api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AlbumController : ControllerBase
    {
        
        [HttpPost]
        [Route("create")]
        public bool CreateAlbum(Album album)
        {
            return true;
        }

        [HttpGet]
        [Route("/{id?}")]
        public Album GetAlbum(int id)
        {
            return new Album
            {
                Artist = "Amit",
                Name = "firstAlbum"
            };
        }
    }
}
