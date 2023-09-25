using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AvatarWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvatarController : ControllerBase
    {
        public AvatarController() 
        {
            
        }

        public IActionResult GetAll()
        {
            return Ok();
        }

        public IActionResult Get(int id)
        {
            return Ok();
        }
        public IActionResult  Post(int id)
        {
            return Ok(new { id });
        }

    }
}
