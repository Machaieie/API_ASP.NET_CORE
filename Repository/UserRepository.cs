using Produtos_API_ASP.NET.Data;
using Produtos_API_ASP.NET.Model;
using Produtos_API_ASP.NET.Repository.Interfaces;

namespace Produtos_API_ASP.NET.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext) 
        { 
            _dataContext = dataContext;
        }
        Task<UserModel> IUserRepository.addUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        Task<List<UserModel>> IUserRepository.findAllusers()
        {
            throw new NotImplementedException();
        }

        Task<UserModel> IUserRepository.findById(int id)
        {
            throw new NotImplementedException();
        }

        Task<UserModel> IUserRepository.findByName(string name)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserRepository.removeById(int id)
        {
            throw new NotImplementedException();
        }

        Task<UserModel> IUserRepository.removeUser(int id)
        {
            throw new NotImplementedException();
        }

        Task<UserModel> IUserRepository.updateByName(string name)
        {
            throw new NotImplementedException();
        }

        Task<UserModel> IUserRepository.updateUser(UserModel user, int id)
        {
            throw new NotImplementedException();
        }
    }
}
