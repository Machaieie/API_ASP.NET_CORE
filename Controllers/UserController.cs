using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Produtos_API_ASP.NET.Model;

namespace Produtos_API_ASP.NET.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UserModel>> getAllUsers() {
            return Ok();
        }
    }
}
