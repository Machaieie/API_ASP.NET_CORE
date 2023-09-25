using Microsoft.EntityFrameworkCore;
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
        public async Task<UserModel> addUser(UserModel user)
        {
            await _dataContext.User.AddAsync(user);
           await _dataContext.SaveChangesAsync();
            return user;
        }



        public async Task<List<UserModel>> findAllusers()
        {
            return await _dataContext.User.ToListAsync();
        }



        public  async Task<UserModel> findById(int id)
        {
            return await _dataContext.User.FirstOrDefaultAsync(x => x.Id == id);
        }

        
        

       

        

       public async Task<UserModel> updateUser(UserModel user, int id)
        {
          UserModel userModel = await findById(id);
            if (userModel == null)
            {
                throw new Exception($"User with id: {id} not found");
            }
            userModel.Name = user.Name;
            userModel.Username = user.Username;
            userModel.Password = user.Password; 
            userModel.Email = user.Email;
            _dataContext.User.Update(userModel);
            await _dataContext.SaveChangesAsync();

            return userModel;
         
        }

        public async Task<bool> removeById(int id)
        {
            UserModel userModel = await findById(id);
            if (userModel == null)
            {
                throw new Exception($"User with id: {id} not found");
            }
            _dataContext.User.Remove(userModel);
            await _dataContext.SaveChangesAsync();
            return true;
        }
    }
}
