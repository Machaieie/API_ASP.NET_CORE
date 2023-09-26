using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Produtos_API_ASP.NET.Model;
using Produtos_API_ASP.NET.Repository.Interfaces;

namespace Produtos_API_ASP.NET.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
         
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> getAllUsers() {
           List<UserModel> userModels= await _userRepository.findAllusers();
            return Ok(userModels);
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<UserModel>> getById(int id)
        {
            UserModel user = await _userRepository.findById(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> AddUser([FromBody]UserModel userModel)
        {
           UserModel user = await _userRepository.addUser(userModel);
            return Ok(user);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserModel>> UpdateUser([FromBody] UserModel userModel, int id)
        {
            userModel.Id = id;
            UserModel user = await _userRepository.updateUser(userModel,id);
            return Ok(user);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UserModel>> DeleteUser( UserModel userModel, int id)
        {
            userModel.Id = id;
            bool userDeleted = await _userRepository.removeById( id);
            return Ok(userDeleted);

        }
    }
}
