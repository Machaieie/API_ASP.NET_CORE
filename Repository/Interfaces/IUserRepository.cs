using Produtos_API_ASP.NET.Model;

namespace Produtos_API_ASP.NET.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> findAllusers();
        Task<UserModel> findById(int id);
       
        Task<UserModel> addUser(UserModel user);
       
        Task<bool> removeById(int id); 
        Task<UserModel> updateUser(UserModel user, int id); 
 
        

    }
}
