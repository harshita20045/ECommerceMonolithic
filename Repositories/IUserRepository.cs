using EcommerceMonolith.Models;

namespace EcommerceMonolith.Repositories
{
    public interface IUserRepository
    {

        IEnumerable<User> GetAll();
        User GetById(int id);
        User Create(User user);
    }
}


