using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstJWT.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        [Route("GetData")]
        public string GetData()
        {
            return "testing ...";

        }
    }
}
